﻿using ClasesCS;
using FerreroCS.CATALOGOS;
using LogicaNegociosCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.SISTEMA
{
    public partial class MDICatalogos : Form
    {
        private int childFormNumber = 0;

        // *************************  VARIABLES   ****************************
        private ToolStripMenuItem tsmnuBarraHerramientas; 
        private ToolStripMenuItem tsmnuBarraEstado;

        public void MDIParent1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     ''' Genera los menus del formulario dinámicamente
        ///     ''' </summary>
        ///     ''' <param name="Menu">mnuCatalagos</param>
        ///     ''' <param name="BarraBotones">Barra de botones</param>
        ///     ''' <param name="IdUsuario">Identificador del usuario</param>
        ///     ''' <param name="IdModulo">Identificador del módulo</param>
        ///     ''' <remarks></remarks>
        private void GeneraMenu(ref MenuStrip Menu, ref ToolStrip BarraBotones, int IdUsuario, int IdModulo)
        {
            LnSistema objLnSistema = new LnSistema(ModUsuario.SessionObjEnDatosConn);
            DataTable dtMenus;
            DataTable dtAcciones;
            string Mensaje;

            // Limpiamos tanto el menu como la barra de botones y les indicamos la lista de imagenes que tomará
            Menu.Items.Clear();
            BarraBotones.Items.Clear();
            Menu.ImageList = imgListBotones;
            BarraBotones.ImageList = imgListBotones;
            // Llenamos el DataTable con los menus que tiene el modulo que se mande por referencia
            Mensaje = "";
            dtMenus = objLnSistema.ConsultaPermisosPMM(IdUsuario, ref Mensaje, IdModulo, 0);
            // Validamos que no haya ocurrido ningun error
            if (Mensaje != "")
            {
                MessageBox.Show(Mensaje, "Error al cargar el menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Revisamos que haya menus a los que tenga acceso el usuario
            if (dtMenus.Rows.Count == 0)
            {
                MessageBox.Show("No tienes menus habilitados en este módulo", "Modulo denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Recorremos los renglones para construir el menu con las opciones
            foreach (DataRow drMenu in dtMenus.Rows)
            {
                ToolStripMenuItem mnuItem = new ToolStripMenuItem();
                // Agregamos el menuitem que trae las opciones al menustrip
                Menu.Items.Add(mnuItem);
                {
                    var withBlock = mnuItem;
                    withBlock.Text = drMenu["Menu"].ToString();
                    withBlock.Name = "mnu" + drMenu["IdMenu"].ToString();
                    // Si trae imagen, se la asignamos al menu
                    if (drMenu["imagen"].ToString() != "")
                        withBlock.Image = imgListBotones.Images[drMenu["imagen"].ToString()];
                    // Si trae texto de ayuda lo ponemos
                    if (drMenu["ayuda"].ToString() != "")
                        withBlock.ToolTipText = drMenu["ayuda"].ToString();
                    // Obtenemos las acciones, osea los items de cada menu segun los permisos del usuario
                    dtAcciones = objLnSistema.ConsultaPermisosPMM(IdUsuario, ref Mensaje,  IdModulo, (int)drMenu["IdMenu"]);
                    // Agregamos las opciones del menu, en base a las acciones del menu
                    foreach (DataRow drMenuItem in dtAcciones.Rows)
                    {
                        ToolStripItem botonStrip = null/* TODO Change to default(_) if this is not a reference type */;
                        string mnuItemNombre = "mnuItem" + drMenuItem["IdAccion"].ToString().Trim();
                        string mnuBotonItemNombre = "tsboton" + drMenuItem["IdAccion"].ToString().Trim();
                        // Creamos la opcion del menu
                        ToolStripMenuItem mnuItemOpcion = new ToolStripMenuItem(drMenuItem["Accion"].ToString().Trim(), null, new EventHandler(Menu_Click));
                        // Si el valor del campo boton es true, generamos un boton que haga referencia
                        if ((bool)drMenuItem["boton"])
                        {
                            botonStrip = new ToolStripButton(drMenuItem["Accion"].ToString().Trim(), null, new EventHandler(Menu_Click));
                            botonStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
                            BarraBotones.Items.Add(botonStrip);
                            if ((bool)drMenuItem["separador"])
                                BarraBotones.Items.Add(new ToolStripSeparator());
                        }
                        // Si trae un separador esta opcion, lo agregamos
                        if ((bool)drMenuItem["separador"] & (int)drMenuItem["Orden"] != 1)
                            withBlock.DropDownItems.Add("-");
                        withBlock.DropDownItems.Add(mnuItemOpcion);
                        {
                            var withBlock1 = mnuItemOpcion;
                            withBlock1.Name = mnuItemNombre;
                            if ((bool)drMenuItem["boton"])
                                botonStrip.Name = mnuBotonItemNombre;
                            // Si trae imagen, se la asignamos al menu
                            if (drMenuItem["imagen"].ToString() != "")
                            {
                                withBlock1.Image = imgListBotones.Images[(int)drMenuItem["imagen"]];
                                // Agregamo la imagen al boton de acceso rapido
                                if ((bool)drMenuItem["boton"])
                                    botonStrip.Image = imgListBotones.Images[(int)drMenuItem["imagen"]];
                            }
                            // Si trae texto de ayuda lo ponemos
                            if (drMenuItem["ayuda"].ToString() != "")
                            {
                                withBlock1.ToolTipText = drMenuItem["ayuda"].ToString();
                                // Agregamo la ayuda al boton de acceso rapido
                                if ((bool)drMenuItem["boton"])
                                    botonStrip.ToolTipText = drMenuItem["ayuda"].ToString();
                            }
                            // Verificamos si trae teclas de acceso rapido
                            if (drMenuItem["Caracter"].ToString().Trim() != "")
                            {
                                int CodigoTecla;
                                CodigoTecla = int.Parse(drMenuItem["Caracter"].ToString());
                                CodigoTecla += (bool)drMenuItem["Ctrl"] ? (int)ClsEnumeradores.TeclasAtajos.Ctrl : 0;
                                CodigoTecla += (bool)drMenuItem["Alt"] ? (int)ClsEnumeradores.TeclasAtajos.Alt : 0;
                                CodigoTecla += (bool)drMenuItem["Shift"] ? (int)ClsEnumeradores.TeclasAtajos.Shift : 0;

                                withBlock1.ShortcutKeys = (Keys)CodigoTecla;
                                withBlock1.ShowShortcutKeys = true;
                            }
                        }
                    }
                }
            }

            // Una vez creados los menus a partir de la bd, se generá el menu de "ver"
            ToolStripMenuItem tsmnuVer = new ToolStripMenuItem();

            tsmnuBarraHerramientas = new ToolStripMenuItem("&Barra de herramientas", imgListBotones.Images[""], new EventHandler(Menu_Click));
            tsmnuBarraEstado = new ToolStripMenuItem("B&arra de estado", imgListBotones.Images[""], new EventHandler(Menu_Click));

            tsmnuBarraHerramientas.Checked = true;
            tsmnuBarraHerramientas.CheckOnClick = true;
            tsmnuBarraHerramientas.CheckState = CheckState.Checked;
            tsmnuBarraHerramientas.Name = "mnuItemBarraHerrmaientas";

            tsmnuBarraEstado.Checked = true;
            tsmnuBarraEstado.CheckOnClick = true;
            tsmnuBarraEstado.CheckState = CheckState.Checked;
            tsmnuBarraEstado.Name = "mnuItemBarraEstado";

            tsmnuVer.Text = "&Ver";
            tsmnuVer.Name = "mnuVer";
            // Agregamos las opciones que tendra el menu de ver
            tsmnuVer.DropDown.Items.Add(tsmnuBarraHerramientas);
            tsmnuVer.DropDown.Items.Add(tsmnuBarraEstado);
            
            Menu.Items.Add(tsmnuVer);
            Menu.MdiWindowListItem = tsmnuVer;

            // Se genera el menu de "ventana"
            var toolmnuVentana = new ToolStripMenuItem();
            {
                toolmnuVentana.Text = "V&entanas";
                toolmnuVentana.Name = "mnuVentanas";
                // Agregamos las opciones que tendra el menu de ventanas
                toolmnuVentana.DropDown.Items.Add("Cascada", imgListBotones.Images["VentanasCascada.png"], new EventHandler(Menu_Click)).Name = "mnuItemCascada";
                toolmnuVentana.DropDown.Items.Add("Horizontal", imgListBotones.Images["VentanasHorizontal.png"], new EventHandler(Menu_Click)).Name = "mnuItemHorizontal";
                toolmnuVentana.DropDown.Items.Add("Vertical", imgListBotones.Images["VentanasVertical.png"], new EventHandler(Menu_Click)).Name = "mnuItemVertical";
                toolmnuVentana.DropDown.Items.Add("Cerrar Todo", imgListBotones.Images["Delete3.png"], new EventHandler(Menu_Click)).Name = "mnuItemCerrarTodo";
            }
            Menu.Items.Add(toolmnuVentana);
            Menu.MdiWindowListItem = toolmnuVentana;

            // Se genera el menu de "salir" 
            Menu.Items.Add("&Salir", imgListBotones.Images["Cancel2.png"], new EventHandler(Menu_Click)).Name = "mnuItemSalir";
        }

        /// <summary>
        ///     ''' Metodo que controla el click del mnuCatalagos que se genera dinamicamente
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void Menu_Click(object sender, EventArgs e)
        {
            string Nombre;
            ToolStripMenuItem Item = (ToolStripMenuItem)sender;
            try
            {
                Nombre = Item.Name;
            }
            catch (Exception ex)
            {
                Nombre = Item.Name;
            }

            // Dependiendo de la opcion seleccionada se ejecuta el codigo correspondiente
            switch (Nombre)
            {
                case "mnuItem12":
                case  "tsboton12":
                    {
                        FrmClientes frmClientes = new FrmClientes(ModoOperacion.Alta);
                        {
                            MdiParent = this;
                        };
                        frmClientes.Show();
                        
                        //FrmBuscadorGenerico frmBuscadorExcepciones = new FrmBuscadorGenerico("Bec.prConsultarExcepciones");
                        //frmBuscadorExcepciones.Text = tituloVentana + "Buscador de excepciones";
                        //frmBuscadorExcepciones.ShowDialog();

                        // If Not IsNothing(frmBuscadorExcepciones.FilaGrid) Then
                        // Dim FrmNvaExcepcion As New FrmAdministradorExcepciones(OperacionesExcepciones.Modificacion,
                        // frmBuscadorExcepciones.FilaGrid("Folio"))
                        // FrmNvaExcepcion.Text += " - Modificar datos de excepción"
                        // FrmNvaExcepcion.MdiParent = Me
                        // FrmNvaExcepcion.Show()
                        // End If

                        //frmBuscadorExcepciones.Dispose();
                        break;
                    }

                case "mnuItem14":
                case "tsboton14":
                    {
                        FrmEmpleados frmEmpleados = new FrmEmpleados(ModoOperacion.Alta)
                        {
                            MdiParent = this
                        };
                        frmEmpleados.Show();


                        //FrmBuscadorGenerico frmBuscadorExcepciones = new FrmBuscadorGenerico("Bec.prConsultarExcepciones");
                        //frmBuscadorExcepciones.Text = tituloVentana + "Buscador de excepciones";
                        //frmBuscadorExcepciones.MdiParent = this;
                        //frmBuscadorExcepciones.Show();
                        break;
                    }

                case "mnuItem16":
                case "tsboton16":
                    {
                        FrmRutas frmRutas = new FrmRutas
                        {
                            MdiParent = this
                        };
                        frmRutas.Show();


                        //FrmBuscadorGenerico frmBuscadorExcepciones = new FrmBuscadorGenerico("Bec.prConsultarExcepciones");
                        //frmBuscadorExcepciones.Text = tituloVentana + "Buscador de excepciones";
                        //frmBuscadorExcepciones.MdiParent = this;
                        //frmBuscadorExcepciones.Show();
                        break;
                    }

                case ("mnuItemBarraHerrmaientas"):
                    {
                        tsCatalogos.Visible = tsmnuBarraHerramientas.Checked;
                        break;
                    }

                case ("mnuItemBarraEstado"):
                    {
                        StatusStrip.Visible = tsmnuBarraEstado.Checked;
                        break;
                    }

                case ("mnuItemCascada"):
                    {
                        LayoutMdi(MdiLayout.Cascade);
                        break;
                    }

                case "mnuItemHorizontal":
                    {
                        LayoutMdi(MdiLayout.TileHorizontal);
                        break;
                    }

                case "mnuItemVertical":
                    {
                        LayoutMdi(MdiLayout.TileVertical);
                        break;
                    }

                case "mnuItemCerrarTodo":
                    {
                        // Close all child forms of the parent.
                        foreach (Form ChildForm in MdiChildren)
                            ChildForm.Close();
                        break;
                    }

                case "mnuItemSalir":
                    {
                        Close();
                        Dispose();
                        break;
                    }
            }
        }


















        //private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    tsmnuBarraHerramientas.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    tsmnuBarraEstado.Visible = statusBarToolStripMenuItem.Checked;
        //}

        //private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.Cascade);
        //}

        //private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.TileVertical);
        //}

        //private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.TileHorizontal);
        //}

        //private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.ArrangeIcons);
        //}

        //private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (Form childForm in MdiChildren)
        //    {
        //        childForm.Close();
        //    }
        //}
    }
}
