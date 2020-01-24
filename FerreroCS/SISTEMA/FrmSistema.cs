using ClasesCS;
using LogicaNegociosCS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.SISTEMA
{
    public partial class FrmSistema : Form
    {
        // Objetos LogicaNegocio
        private readonly LnSistema ObjLnSistema;
        private readonly LnSistema ObjLnSistemaAdmin;
        private readonly LnFunciones ObjLnfunciones;
        private readonly ClsFunciones ObjFunciones;

        // Objetos EntidadNegocio
        private readonly Sis.PERFILES ObjEnPerfil;
        private Sis.USUARIOS objEnUsuario;
        private DataSet dataSetArbol;
        private string mensaje;

        public FrmSistema()
        {
            InitializeComponent();

            // **********  Inicialización de objetos  *************
            ObjEnPerfil = new Sis.PERFILES();
            objEnUsuario = new Sis.USUARIOS();

            ObjFunciones = new ClsFunciones();
            ObjLnSistema = new LnSistema(ModUsuario.SessionObjEnDatosConn);
            ObjLnSistemaAdmin = new LnSistema(ModUsuario.SessionObjEnParametrosGrales.UsuarioAdmSeg, 
                ModUsuario.SessionObjEnParametrosGrales.PswAdmSeg,
                ModUsuario.SessionIdUsuario);

            ObjLnfunciones = new LnFunciones(ModUsuario.SessionObjEnDatosConn);

            tvPermisos.ImageList = imgLArbol;
        }

        private void frmSistema_Shown(object sender, EventArgs e)
        {
            // Ocultar pestaña de correos
            tpIsisMail.Parent = null;

            // Se crean objetos de usuarios
            string strError = null;

            try
            {
                // registro del acceso al modulo
                ObjFunciones.RegistraSesion((int)ClsEnumeradores.Modulos.Sistema, (int)ClsEnumeradores.AccionesSesion.IngresoModulo);

                // Permisos para la visualizacion de menus 
                DataTable dt;
                dt = ObjLnSistema.ConsultaPermisosPMM(ModUsuario.SessionIdUsuario, ref strError, (int)ClsEnumeradores.Modulos.Sistema);
                if (dt != null & dt.Rows.Count > 0)
                {
                    BindingSource bind = new BindingSource
                    {
                        DataSource = dt
                    };

                    if (bind.Find("IdMenu", ClsEnumeradores.Menus.Perfiles) < 0)
                        TbcSistema.TabPages[0].Parent = null;

                    if (bind.Find("IdMenu", ClsEnumeradores.Menus.Usuarios) < 0)
                        TbcSistema.TabPages[1].Parent = null;
                }
                else
                {
                    TbcSistema.TabPages["tbpGrupoUsuarios"].Parent = null;
                    TbcSistema.TabPages["TbpUsuarios"].Parent = null;
                }

                // Permisos para la visualizacion de botones (acciones de sistema) Perfiles 
                dt = ObjLnSistema.ConsultaPermisosPMM(ModUsuario.SessionIdUsuario, ref strError, (int)ClsEnumeradores.Modulos.Sistema,
                    (int)ClsEnumeradores.Menus.Perfiles);

                if (dt != null & dt.Rows.Count > 0)
                {
                    BindingSource bind = new BindingSource
                    {
                        DataSource = dt
                    };

                    // Se habilitan los botones de acceso a los modulos
                    TsbNuevoPerfil.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.AltaPerfil) >= 0 ? true : false;
                    TsbActualizar.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.ActualizacionPerfil) >= 0 ? true : false;
                    TsbInactivar.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.CambioStatusPerfil) >= 0 ? true : false;
                    cmsOpPermisos.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.AsignacionPermisos) >= 0 ? true : false;
                    cmsPermisoTodo.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.AsignacionPermisos) >= 0 ? true : false;
                }

                // Permisos para la visualizacion de botones (acciones de sistema) Usuarios
                dt = ObjLnSistema.ConsultaPermisosPMM(ModUsuario.SessionIdUsuario, ref strError, (int)ClsEnumeradores.Modulos.Sistema,
                    (int)ClsEnumeradores.Menus.Usuarios);

                if (dt != null & dt.Rows.Count > 0)
                {
                    BindingSource bind = new BindingSource
                    {
                        DataSource = dt
                    };

                    // Se habilitan los botones de acceso a los modulos
                    TsbNuevoUsuario.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.AltaUsuario) >= 0 ? true : false;
                    TsbActualizarUsuario.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.ActualizacionUsuario) >= 0 ? true : false;
                    TsbInactivarUsuario.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.CambioStatusUsuario) >= 0 ? true : false;
                    tsbResetPsw.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.ReseteoContraseña) >= 0 ? true : false;
                    //tsbReporteUsuarios.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.ReportesUsuarios) >= 0 ? true : false;
                    tsbMonitorUsuarios.Enabled = bind.Find("IdAccion", ClsEnumeradores.AccionesSistema.MonitorUsuarios) >= 0 ? true : false;
                }

                CargarDgvPerfiles();
                CargarDgvUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void CrearNodosDelPadre(string indicePadre, TreeNode nodePadre)
        {

            // dataview con los datos de las cuentas
            DataView dataViewHijos;
            dataViewHijos = new DataView(dataSetArbol.Tables[0])
            {

                // Se filtran por numCuentaPadre
                RowFilter = dataSetArbol.Tables[0].Columns["Npadre"].ColumnName + " = '" + indicePadre.ToString() + "'"
            };

            // se agregan cada uno de los hijos de dicha cuenta
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode()
                {
                    Text = dataRowCurrent["Accion"].ToString().Trim(),
                    Tag = dataRowCurrent["idAccion"].ToString().Trim(),
                    ImageIndex = (int)dataRowCurrent["Habilitado"],
                    SelectedImageIndex = (int)dataRowCurrent["Habilitado"],
                    Checked = (int)dataRowCurrent["Habilitado"]>0 ? true : false,
                    ContextMenuStrip = dataRowCurrent["idAccion"] == DBNull.Value ? cmsPermisoTodo : cmsOpPermisos
                };

                // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                // del primer nivel que no dependen de otro nodo.
                if (nodePadre == null)
                    tvPermisos.Nodes.Add(nuevoNodo);
                else
                    // se añade el nuevo nodo al nodo padre.
                    nodePadre.Nodes.Add(nuevoNodo);

                // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
                CrearNodosDelPadre(dataRowCurrent["Id"].ToString(), nuevoNodo);
            }
        }


        /// <summary>
        ///     ''' Funcion que llena el dataGridView destinado a los perfiles 
        ///     ''' </summary>
        ///     ''' <param name="strNombrePerfil"></param>
        ///     ''' <remarks></remarks>
        private void CargarDgvPerfiles(string strNombrePerfil="")
        {
            try
            {

                ObjFunciones.LlenaDataGridView(ref DgvPerfilUsuario, "Sis.prConsultaPerfiles", strNombrePerfil);

                DgvPerfilUsuario.Columns["IdPerfil"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     ''' Alta de nuevo perfil de usuario
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCat FrmNvoPerfil;
            FrmNvoPerfil = new FrmCat("Perfiles", "Nombre del prefil:");

            FrmNvoPerfil.ShowDialog();

            if (FrmNvoPerfil.Salida == "0")
            {
                ObjEnPerfil.Perfil = FrmNvoPerfil.Nombre;
                ObjEnPerfil.Habilitado = "1";

                try
                {
                    ObjLnSistema.ABCPerfil('A', ObjEnPerfil);

                    MessageBox.Show("Perfil guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDgvPerfiles(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        ///     ''' Inhabilitar perfil de usuario
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (DgvPerfilUsuario.SelectedRows.Count > 0)
            {
                ObjEnPerfil.IdPerfil = (int)DgvPerfilUsuario.SelectedRows[0].Cells["IdPerfil"].Value;
                ObjEnPerfil.Habilitado = DgvPerfilUsuario.SelectedRows[0].Cells["Habilitado"].Value.ToString() == "Activo" ? "0" : "1";

                try
                {
                    ObjLnSistema.ABCPerfil('C', ObjEnPerfil);

                    string mensaje = "Perfil ";
                    mensaje += DgvPerfilUsuario.SelectedRows[0].Cells["Habilitado"].Value.ToString() == "Activo" ? "Inhabilitado" : "Habilitado";
                    mensaje += " correctamente";

                    MessageBox.Show( mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDgvPerfiles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        ///     ''' Actualiza Nombre de perfil
        ///     ''' </summary>
        ///     ''' <param name="intRow"></param>
        ///     ''' <remarks></remarks>
        private void actualizarPerfil(int intRow)
        {
            FrmCat FrmNvoPerfil;
            FrmNvoPerfil = new FrmCat("Perfiles", "Nombre del prefil:");

            FrmNvoPerfil.TxtDescripcion.Text = DgvPerfilUsuario.Rows[intRow].Cells["Perfil"].Value.ToString();

            FrmNvoPerfil.ShowDialog();

            if (FrmNvoPerfil.Salida == "0")
            {
                ObjEnPerfil.IdPerfil = (int)DgvPerfilUsuario.Rows[intRow].Cells["IdPerfil"].Value;
                ObjEnPerfil.Perfil = FrmNvoPerfil.Nombre;
                ObjEnPerfil.Habilitado = null;

                try
                {
                    ObjLnSistema.ABCPerfil('C', ObjEnPerfil);

                    MessageBox.Show("Perfil guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDgvPerfiles(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        ///     ''' Evento clic sobre el boton de Actualizar Perfil de usuario.
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        ///     '''
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (DgvPerfilUsuario.SelectedRows.Count > 0)
                actualizarPerfil(DgvPerfilUsuario.SelectedRows[0].Index);
        }

        /// <summary>
        ///     ''' Filtrado de perfiles
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        ///     '''
        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            FrmCat frmBuscarPerfil;
            frmBuscarPerfil = new FrmCat("Perfiles", "Nombre del prefil:");

            frmBuscarPerfil.ShowDialog();

            if (frmBuscarPerfil.Salida == "0")
                CargarDgvPerfiles(frmBuscarPerfil.Nombre);
        }

        /// <summary>
        ///     ''' Evento de cambio de seleccion del grid de perfiles, para cargar los permisos correspondientes.
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        ///     '''
        private void DgvPerfilUsuario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DgvPerfilUsuario.SelectedRows.Count > 0)
                {
                    tvPermisos.Nodes.Clear();

                    dataSetArbol = new DataSet();

                    dataSetArbol.Tables.Add(ObjLnfunciones.GetInfoQueryDt("Sis.prConsultaPermisos " + DgvPerfilUsuario.SelectedRows[0].Cells["IdPerfil"].Value.ToString()));
                    CrearNodosDelPadre("0", null);
                    tvPermisos.ExpandAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     ''' Actualiza combos y Grids del formulario
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void TbcSistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se carga solo el grid del tab Seleccionado
            switch (TbcSistema.SelectedIndex)
            {
                case 0:
                    {
                        CargarDgvPerfiles();
                        break;
                    }

                case 1:
                    {
                        CargarDgvUsuarios();
                        break;
                    }
            }
        }

        /// <summary>
        ///     ''' Funcin para Carga los usuarios en el grid
        ///     ''' </summary>
        ///     ''' <param name="IdPerfil">Identificador del perfil</param>
        ///     ''' <param name="NombreUsuario">Nombre del usuario</param>
        ///     ''' <remarks></remarks>
        public void CargarDgvUsuarios(int IdPerfil=0, string NombreUsuario="")
        {
            string sParametros;
            try
            {
                sParametros = IdPerfil == 0 ? "null" : IdPerfil.ToString();
                sParametros += ", ";
                sParametros += string.IsNullOrEmpty(NombreUsuario) ? "null" : "'" + NombreUsuario + "'";

                ObjFunciones.LlenaDataGridView(ref DgvUsuarios, "Sis.prConsultaUsuarios", sParametros);

                DgvUsuarios.Columns["IdPerfil"].Visible = false;
                DgvUsuarios.Columns["Idusuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     ''' Actualizacion de datos del usuario
        ///     ''' </summary>
        ///     ''' <param name="intFila">Numero de fila</param>
        ///     ''' <remarks></remarks>
        private void ActualizaUsuario(int intFila)
        {
            FrmUsuario frmNuevoUsuario = new FrmUsuario()
            {
                blAlta = false,
                GetUsuario = new Sis.USUARIOS()
                {
                    IdUsuario = (int)DgvUsuarios.Rows[intFila].Cells["idUsuario"].Value,
                    Nombre = DgvUsuarios.Rows[intFila].Cells["Nombre"].Value == null ? "" : DgvUsuarios.Rows[intFila].Cells["Nombre"].Value.ToString(),
                    ApPaterno = DgvUsuarios.Rows[intFila].Cells["ApPaterno"].Value == null ? "" : DgvUsuarios.Rows[intFila].Cells["ApPaterno"].Value.ToString(),
                    ApMaterno = DgvUsuarios.Rows[intFila].Cells["ApMaterno"].Value == null ? "" : DgvUsuarios.Rows[intFila].Cells["ApMaterno"].Value.ToString(),
                    IdPerfil = (int)DgvUsuarios.Rows[intFila].Cells["idPerfil"].Value,
                    NombreUsuario = DgvUsuarios.Rows[intFila].Cells["NombreUsuario"].Value.ToString(),
                }

            };          

            frmNuevoUsuario.ShowDialog();

            if (frmNuevoUsuario.Salida)
            {
                try
                {
                    ObjLnSistemaAdmin.ABCUsuarios('C', frmNuevoUsuario.GetUsuario);

                    MessageBox.Show("El usuario \"" + frmNuevoUsuario.GetUsuario.NombreUsuario + "\" ha sido actualizado.",
                        "Actualización correcta" , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDgvUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        /// <summary>
        ///     ''' Evento doble clic para la actualizacion de datos de usuario
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                ActualizaUsuario(e.RowIndex);
        }

        /// <summary>
        ///     ''' funcion que llama Forma para filtrar usuarios.
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void tsbFiltrarUsuarios_Click(object sender, EventArgs e)
        {
            FrmFiltrarUsuarios FrmBuscar;

            FrmBuscar = new FrmFiltrarUsuarios();

            FrmBuscar.ShowDialog();

            if (FrmBuscar.Salida)
                CargarDgvUsuarios(FrmBuscar.IdPerfil, FrmBuscar.Usuario);
        }

        /// <summary>
        ///     ''' Procedimiento para inactivar usuario.
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        ///     '''
        private void TsbInactivarUsuario_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count > 0)
            {
                if ((int)DgvUsuarios.SelectedRows[0].Cells["idUsuario"].Value == ModUsuario.SessionIdUsuario)
                {
                    MessageBox.Show("No es posible desactivar tu propio usuario. \nIntenta con una cuenta diferente.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                objEnUsuario = new Sis.USUARIOS()
                {
                    IdUsuario = (int)DgvUsuarios.SelectedRows[0].Cells["idUsuario"].Value,
                    IdPerfil = 0,
                    NombreUsuario = null,
                    CambioContrasena = null,
                    FechaCambioContrasena = DateTime.MinValue,
                    Password = null,
                    Habilitado = (bool)DgvUsuarios.SelectedRows[0].Cells["habilitado"].Value == true ? "0" : "1",
                    Nombre = DgvUsuarios.SelectedRows[0].Cells["Nombre"].Value == null ? "" : DgvUsuarios.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                    ApPaterno = DgvUsuarios.SelectedRows[0].Cells["ApPaterno"].Value == null ? "" : DgvUsuarios.SelectedRows[0].Cells["ApPaterno"].Value.ToString(),
                    ApMaterno = DgvUsuarios.SelectedRows[0].Cells["ApMaterno"].Value == null ? "" : DgvUsuarios.SelectedRows[0].Cells["ApMaterno"].Value.ToString()
                };

                try
                {
                    ObjLnSistemaAdmin.ABCUsuarios('C', objEnUsuario);

                    mensaje = string.Format("El usuario \"{0}\", ha sido {1} correctamente.", DgvUsuarios.SelectedRows[0].Cells["NombreUsuario"].Value.ToString(),
                        objEnUsuario.Habilitado == "1" ? "habilitado" : "inhabilitado");

                    MessageBox.Show(mensaje,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDgvUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        ///     ''' evento clik del boton de nuevo usuario.
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void TsbNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmNuevoUsuario = new FrmUsuario
            {
                blAlta = true
            };
            frmNuevoUsuario.ShowDialog();

            if (frmNuevoUsuario.Salida)
            {
                try
                {
                    ObjLnSistemaAdmin.ABCUsuarios('A', frmNuevoUsuario.GetUsuario);

                    MessageBox.Show("El usuario \"" + frmNuevoUsuario.GetUsuario.NombreUsuario + "\" ha sido dado de alta.", "Alta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDgvUsuarios(default(int), null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        ///     ''' Evento click del boton para la actualizacion del usuario.
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        ///     '''
        private void TsbActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count > 0)
                ActualizaUsuario(DgvUsuarios.SelectedRows[0].Index);
        }

        /// <summary>
        ///     ''' evento Click para el boton de reseteo de contraseña
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        ///     '''
        private void tsbResetPsw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de resetear la contraseña al usuario \"" 
                + DgvUsuarios.SelectedRows[0].Cells["NombreUsuario"].Value + "\"",
                "Restablecer contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Reseteo de la contraseña
                objEnUsuario = new Sis.USUARIOS()
                {
                    IdUsuario = (int)DgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value,
                    CambioContrasena = "1",
                    Password = ModUsuario.SessionObjEnParametrosGrales.PswDefault,
                    Nombre = DgvUsuarios.SelectedRows[0].Cells["Nombre"].Value == null ? "" : DgvUsuarios.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                    ApPaterno = DgvUsuarios.SelectedRows[0].Cells["ApPaterno"].Value == null ? "" : DgvUsuarios.SelectedRows[0].Cells["ApPaterno"].Value.ToString(),
                    ApMaterno = DgvUsuarios.SelectedRows[0].Cells["ApMaterno"].Value == null ? "" : DgvUsuarios.SelectedRows[0].Cells["ApMaterno"].Value.ToString()
                };
                
                try
                {
                    ObjLnSistemaAdmin.ABCUsuarios('D', objEnUsuario);
                    MessageBox.Show("Contraseña restablecida correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        ///     ''' Evento de cierre de la forma de modulo de sistema
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        ///     '''
        private void frmSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            // registro de la salida del modulo
            ClsFunciones fn = new ClsFunciones();
            try
            {
                fn.RegistraSesion((int)ClsEnumeradores.Modulos.Sistema, (int)ClsEnumeradores.AccionesSesion.SalidaModulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Show();
        }

        /// <summary>
        ///     ''' Evento clic sobre el menu contextual de habilitacion/inhabilitacion de permiso
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        ///     '''
        private void Detalle_Click(object sender, EventArgs e)
        {
            CambiaStatusAccion(tvPermisos.SelectedNode, tvPermisos.SelectedNode.Checked == true ? false : true);
        }

        ///// <summary>
        /////     ''' Cambia el status a una accion (Permitir/no permitir) del sistema
        /////     ''' </summary>
        /////     ''' <param name="n"></param>
        /////     ''' <param name="Status"></param>
        /////     ''' <remarks></remarks>
        /////     '''
        private void CambiaStatusAccion(TreeNode n, bool Status)
        {
            if (n.Tag!=null & (string)n.Tag != "" & n.Checked != Status)
            {
                Sis.PERMISOS_PERFIL objenPermisoPerfil = new Sis.PERMISOS_PERFIL
                {
                    IdPerfil = (int)DgvPerfilUsuario.SelectedRows[0].Cells["IdPerfil"].Value,
                    IdAccion = int.Parse(n.Tag.ToString()),
                    Habilitado = Status == true ? "1" : "0"
                };


                try
                {
                    ObjLnSistema.ABCPermisosPerfil('A', objenPermisoPerfil);

                    n.Checked = Status;
                    n.ImageIndex = n.Checked ? 1 : 0;
                    n.SelectedImageIndex = n.Checked ? 1 : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        ///     ''' Evento clic sobre la opcion habilitar permiso a todos del menu contextual del treeview
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void HabilitarinhabilitarPermisoATodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiaStatusTodos(tvPermisos.SelectedNode, true);
        }

        /// <summary>
        ///     ''' Evento clic sobre la opcion inhabilitar permiso a todos del menu contextual del treeview
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void InhabilitarPermisoATodoElMenuModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiaStatusTodos(tvPermisos.SelectedNode, false);
        }

        /// <summary>
        ///     ''' Cambia el status de todas las acciones del sistema dependientes del menu, o del modulo
        ///     ''' </summary>
        ///     ''' <param name="n"></param>
        ///     ''' <param name="Status"></param>
        ///     ''' <remarks></remarks>
        private void CambiaStatusTodos(TreeNode n, bool Status)
        {
            CambiaStatusAccion(n, Status);

        

            foreach (var aNode2 in n.Nodes)
                CambiaStatusTodos((TreeNode)aNode2, Status);
        }

        private void tvPermisos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!e.Node.IsSelected)
                tvPermisos.SelectedNode = e.Node;
        }


        private void tsbtnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvPerfilUsuario.RowCount > 0)
                {
                    ClsFunciones objFunciones = new ClsFunciones();
                    objFunciones.ExportarDataGridViewExcel(ref DgvPerfilUsuario, true, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbBuscarCorreos_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                string parametros = ckbInicioCorreo.Checked ? "'" + dtpFechaCorreo.Value.ToString("yyyyMMdd") + "'" : "NULL";
                ObjFunciones.LlenaGridControl(ref dxgcCorreo, "[Not].prConsultarCorreos " + parametros);

                var dt = ObjLnfunciones.GetInfoQueryDt("[Not].prConsultarParametrosIsisMail");
                dxgcIsisMailParametros.DataSource = dt;

                var dtSMTP = ObjLnfunciones.GetInfoQueryDt("[Not].prConsultarParametrosSMTP");
                dxgcResumen.DataSource = dtSMTP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible cargar correos. Causa:" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbExportarCorreos_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                ObjFunciones.ExportarDXGridControl(FormatosArchivo.Excel, dxgcCorreo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible exportar correos. Causa:" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbMonitorUsuarios_Click(System.Object sender, System.EventArgs e)
        {
            FrmMonitorSesiones frmMonitor = new FrmMonitorSesiones();
            frmMonitor.ShowDialog();
        }
        
        private void lbExpandir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tvPermisos.ExpandAll();
        }

        private void lbContraer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tvPermisos.CollapseAll();
        }

        private void tsbtnExportUsuarios_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DgvUsuarios.RowCount > 0)
                {
                    ObjFunciones.ExportarDataGridViewExcel(ref DgvUsuarios, true, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
