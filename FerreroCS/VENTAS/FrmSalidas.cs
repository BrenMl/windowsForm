using ClasesCS;
using enUtilerias;
using LogicaNegociosCS;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;
using static ClasesCS.ModUsuario;

namespace FerreroCS.VENTAS
{
    public partial class FrmSalidas : Form
    {
        // Privadas
        private LnSalidas LnSal;
        private Salida Salida;
        private FrmBuscadorGenerico FrmBuscarEmpleados;
        private FrmBuscadorGenerico FrmBuscarProductos;
        private ModoOperacion ModoOperacion;
        private ClsFunciones Func;
        private DataTable DtDatosEmpleado;
        private Producto Producto;

        private Sal.DETALLES_SALIDA DetalleSalida;

        public FrmSalidas(ModoOperacion ModoOperacion, DataRow FilaGrid = null)
        {
            InitializeComponent();

            // Inicializar variables     
            this.ModoOperacion = ModoOperacion;
            LnSal = new LnSalidas(SessionObjEnDatosConn);
            Salida = new Salida();
            Func = new ClsFunciones();

            FrmBuscarEmpleados = new FrmBuscadorGenerico("Emp.ConsultarEmpleados 1", "IdPersona", "Calle", "NumExt", "NumInt", "IdColonia", "Colonia",
                "IdCodigoPostal", "CodigoPostal", "IdMunicipio", "Municipio", "IdEntidadFederativa", "EntidadFederativa", "Referencia", "Foto")
            {
                Text = "Buscador de empleados"
            };

            FrmBuscarProductos = new FrmBuscadorGenerico("Pro.ConsultarProductos @Activo=1, @ConExistencia=1", "IdProducto", "IdFamilia", "IdConfeccion")
            {
                Text = "Buscador de productos"
            };

            Producto = new Producto();

            DtDatosEmpleado = new DataTable("DatosEmpleado");
            DtDatosEmpleado.Columns.Add("Identificador");
            DtDatosEmpleado.Columns.Add("Nombre");
            DtDatosEmpleado.Columns.Add("Comision");
            DtDatosEmpleado.Columns.Add("Fecha ingreso");
            DtDatosEmpleado.Columns.Add("INE");
            DtDatosEmpleado.Columns.Add("Direccion");
            
            if (FilaGrid != null)
            {
                Salida.IdSalida = (int)FilaGrid["IdSalida"];
                Salida.IdEmpleado = (int)FilaGrid["IdEmpleado"];
                Salida.IdEstatusSalida = (int)FilaGrid["IdEstatusSalida"];
                Salida.FechaSalida = FilaGrid["FechaSalida"] == System.DBNull.Value ? new DateTime() : (DateTime)FilaGrid["FechaSalida"];

                Salida.Empleado.IdEmpleado = Salida.IdEmpleado;
                Salida.Empleado.IdPersona = (int)FilaGrid["IdPersona"];
                Salida.Empleado.Comision = (int)FilaGrid["Comision"];
                Salida.Empleado.Foto = FilaGrid["Foto"].ToString();
                Salida.Empleado.FechaIngreso = FilaGrid["FechaIngreso"] == System.DBNull.Value ? new DateTime() : (DateTime)FilaGrid["FechaIngreso"];
                Salida.Empleado.INE = FilaGrid["INE"].ToString();           

                Salida.EstatusSalida.IdEstatusSalida = (int)FilaGrid["IdEstatusSalida"];
                Salida.EstatusSalida.EstatusSalida = FilaGrid["EstatusSalida"].ToString();
            }
            else
            {
                deFechaSalida.EditValue = DateTime.Now;
                lblFolio.Text = "Pendiente";
                lblEstatus.Text = "En proceso de captura";
            }          
        }

        private void FrmSalidas_Shown(object sender, System.EventArgs e)
        {
            try
            {                
                PrepararFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void PrepararFormulario()
        {
            switch (ModoOperacion)
            {
                case ModoOperacion.Alta:
                    tsbGuardar.Visible = true;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = false;
                    ModoConsulta(false);
                    MostrarPestañas(false);                    
                    break;

                case ModoOperacion.Baja:
                    tsbGuardar.Visible = false;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = true;
                    ModoConsulta(false);
                    MostrarPestañas(true);
                    break;

                case ModoOperacion.Modificacion:
                    tsbGuardar.Visible = true;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = true;
                    ModoConsulta(false);
                    MostrarPestañas(true);
                    break;

                case ModoOperacion.Consulta:
                    tsbGuardar.Visible = false;
                    tsbModificar.Visible = true;
                    tsbEliminar.Visible = true;
                    ModoConsulta(true);
                    MostrarPestañas(true);
                    LlenarDatosGrales();
                    LlenarGridDetalleSalida();
                    break;
            }
        }      

        private void MostrarPestañas(bool PageVisible)
        {
            tnpDatosGrales.PageVisible = true;
            tnpProductos.PageVisible = PageVisible;
        }

        private void ModoConsulta(bool Editable)
        {
            // Datos generales
            deFechaSalida.Enabled = !Editable;
            btnBuscarEmpleado.Enabled = !Editable;
            pbFoto.Enabled = !Editable;

            // Productos
            btnBuscarProducto.Enabled = !Editable;            
            btnAgregarProducto.Enabled = !Editable;
            btnQuitarProducto.Enabled = !Editable;            
        }

        private void LlenarDatosGrales()
        {
            // Datos salida
            lblFolio.Text = Salida.IdSalida.ToString();
            lblEstatus.Text = Salida.EstatusSalida.EstatusSalida;
            deFechaSalida.DateTime = Salida.FechaSalida;

            // Datos empleado            
            DtDatosEmpleado.Rows.Clear();
            DtDatosEmpleado.Rows.Add(Salida.Empleado.IdEmpleado,
                "",//$"{FrmBuscarEmpleados.FilaGrid["Nombre"]} {FrmBuscarEmpleados.FilaGrid["ApPaterno"]} {FrmBuscarEmpleados.FilaGrid["ApMaterno"]}",
                Salida.Empleado.Comision,
                Salida.Empleado.FechaIngreso,
                Salida.Empleado.INE,
                "");//$"{FrmBuscarEmpleados.FilaGrid["Calle"]} {FrmBuscarEmpleados.FilaGrid["NumExt"]} {FrmBuscarEmpleados.FilaGrid["NumInt"]}. Col. {FrmBuscarEmpleados.FilaGrid["Colonia"]} Cp. {FrmBuscarEmpleados.FilaGrid["CodigoPostal"]}");
            grcDatosEmpleado.DataSource = DtDatosEmpleado;

            // Cargar foto
            if (String.IsNullOrEmpty(Salida.Empleado.Foto.Trim()))                
                pbFoto.Image = null;
            else
            {
                // Revisar si existe la foto                
                if (File.Exists(Salida.Empleado.Foto.Trim()))
                {
                    FileStream fs = new FileStream(Salida.Empleado.Foto.Trim(), FileMode.Open, FileAccess.Read);
                    pbFoto.Image = Image.FromStream(fs);
                    fs.Close();
                    fs.Dispose();
                }
            }
        }

        private void LlenarGridDetalleSalida()
        {
            Func.LlenaGridControl(ref grcProductos, $"Sal.ConsultarDetalleSalida {Salida.IdSalida}");

            dgvProductos.Columns["IdDetalleSalida"].Visible = false;
            dgvProductos.Columns["IdDetalleSalida"].OptionsColumn.AllowShowHide = false;
            dgvProductos.Columns["IdSalida"].Visible = false;
            dgvProductos.Columns["IdSalida"].OptionsColumn.AllowShowHide = false;
            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["IdProducto"].OptionsColumn.AllowShowHide = false;
            dgvProductos.Columns["IdFamilia"].Visible = false;
            dgvProductos.Columns["IdFamilia"].OptionsColumn.AllowShowHide = false;
            dgvProductos.Columns["IdConfeccion"].Visible = false;
            dgvProductos.Columns["IdConfeccion"].OptionsColumn.AllowShowHide = false;
            dgvProductos.Columns["Existencia"].Visible = false;
            dgvProductos.Columns["Existencia"].OptionsColumn.AllowShowHide = false;
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FrmBuscarEmpleados.ShowDialog();

            if (FrmBuscarEmpleados.DialogResult != DialogResult.OK)
            {
                Salida.Empleado = null;
                return;
            }

            Salida.Empleado = new Emp.EMPLEADOS
            {
                Activo = (bool)FrmBuscarEmpleados.FilaGrid["Activo"] ? "1" : "0",
                Comision = (int)FrmBuscarEmpleados.FilaGrid["Comision"],
                FechaIngreso = FrmBuscarEmpleados.FilaGrid["FechaIngreso"] == DBNull.Value ? new DateTime() : (DateTime)FrmBuscarEmpleados.FilaGrid["FechaIngreso"],
                Foto = FrmBuscarEmpleados.FilaGrid["Foto"].ToString()
            };
            Salida.IdEmpleado = (int)FrmBuscarEmpleados.FilaGrid["IdEmpleado"];
            Salida.Empleado.IdEmpleado = Salida.IdEmpleado;
            Salida.Empleado.IdPersona = (int)FrmBuscarEmpleados.FilaGrid["IdEmpleado"];
            Salida.Empleado.INE = FrmBuscarEmpleados.FilaGrid["INE"].ToString();            

            // Grid datos empleado
            DtDatosEmpleado.Rows.Clear();
            DtDatosEmpleado.Rows.Add(Salida.Empleado.IdEmpleado,
                $"{FrmBuscarEmpleados.FilaGrid["Nombre"]} {FrmBuscarEmpleados.FilaGrid["ApPaterno"]} {FrmBuscarEmpleados.FilaGrid["ApMaterno"]}",
                Salida.Empleado.Comision,
                Salida.Empleado.FechaIngreso,
                Salida.Empleado.INE,
                $"{FrmBuscarEmpleados.FilaGrid["Calle"]} {FrmBuscarEmpleados.FilaGrid["NumExt"]} {FrmBuscarEmpleados.FilaGrid["NumInt"]}. Col. {FrmBuscarEmpleados.FilaGrid["Colonia"]} Cp. {FrmBuscarEmpleados.FilaGrid["CodigoPostal"]}");

            grcDatosEmpleado.DataSource = DtDatosEmpleado;

            // Cargar foto
            if (String.IsNullOrEmpty(Salida.Empleado.Foto.Trim()))
                //MessageBox.Show("El empleado no cuenta con fotografía","Actualiza datos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                pbFoto.Image = null;
            else
            {
                // Revisar si existe la foto                
                if (File.Exists(Salida.Empleado.Foto.Trim()))
                {
                    FileStream fs = new FileStream(Salida.Empleado.Foto.Trim(), FileMode.Open, FileAccess.Read);
                    pbFoto.Image = Image.FromStream(fs);
                    fs.Close();
                    fs.Dispose();
                }
            }
        }

        private void tsbGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarDatosGrales())
            {
                try
                {
                    // Llenar objeto "Salida"
                    Salida.FechaSalida = deFechaSalida.DateTime;

                    if (ModoOperacion == ModoOperacion.Alta)
                    {
                        Salida.IdEstatusSalida = (int)EstatusSalida.Captura;
                        LnSal.ABCSALIDAS('A',Salida);
                        lblFolio.Text = Salida.IdSalida.ToString();
                        MessageBox.Show("El registro de salida ha sido almacenado", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModoOperacion = ModoOperacion.Modificacion;
                        PrepararFormulario();
                        return;
                    }

                    if (ModoOperacion == ModoOperacion.Modificacion)
                    {                        
                        LnSal.ABCSALIDAS('C', Salida);
                        MessageBox.Show("El registro de salida ha sido actualizado", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool ValidarDatosGrales()
        {
            if (Salida.Empleado == null || Salida.Empleado.IdEmpleado<=0)
            {
                MessageBox.Show("Es necesario elegir al menos un empleado, por favor revise", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscarEmpleado.Focus();
                return false;
            }
            return true;
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModoOperacion = ModoOperacion.Modificacion;
            PrepararFormulario();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                LnSal.ABCSALIDAS('D', Salida);
                MessageBox.Show("El registro de salida fue eliminado", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Mostrar buscador de productos
            try
            {
                FrmBuscarProductos.ShowDialog();
                if (FrmBuscarProductos.DialogResult == DialogResult.OK)
                {
                    // Llenar objeto entidad
                    Producto = new Producto();
                    Producto.IdProducto = (int)FrmBuscarProductos.FilaGrid["IdProducto"];
                    Producto.Codigo = FrmBuscarProductos.FilaGrid["Codigo"].ToString();
                    Producto.Producto = FrmBuscarProductos.FilaGrid["Producto"].ToString();
                    Producto.IdFamilia = (int)FrmBuscarProductos.FilaGrid["IdFamilia"];
                    Producto.Familia.IdFamilia = Producto.IdFamilia;
                    Producto.Familia.Familia = FrmBuscarProductos.FilaGrid["Familia"].ToString();
                    Producto.IdConfeccion = (int)FrmBuscarProductos.FilaGrid["IdConfeccion"];
                    Producto.Confeccion.IdConfeccion = Producto.IdConfeccion;
                    Producto.Confeccion.Confeccion = FrmBuscarProductos.FilaGrid["Confeccion"].ToString();

                    // Comportamiento de interfaz
                    lblDescripcionProducto.Text = Producto.Producto;
                    nudCantidad.Value = 0;
                    nudCantidad.Maximum = (int)FrmBuscarProductos.FilaGrid["Existencia"];
                    nudCantidad.Enabled = true;
                    lblExistencia.Text = $"{nudCantidad.Maximum}";
                    btnAgregarProducto.Enabled = true;
                    btnQuitarProducto.Enabled = true;
                    nudCantidad.Focus();
                }

                //if (Producto == null)
                //{
                //    Producto = null;
                //    lblDescipcionProducto.Text = "Elija un producto";
                //    nudCantidad.Maximum = 0;
                //    nudCantidad.Enabled = false;
                //    lblExistencia.Text = $"{nudCantidad.Maximum}";
                //    btnAgregarProducto.Enabled = false;
                //    btnQuitarProducto.Enabled = false;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);             
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarDatosProducto())
            {
                Char Opc;
                try
                {
                    // Revisar si se trata de una alta
                    if (DetalleSalida == null)
                    {
                        DetalleSalida = new Sal.DETALLES_SALIDA()
                        {
                            IdDetalleSalida = 0,
                            IdSalida = Salida.IdSalida,
                            IdProducto = Producto.IdProducto,
                            Cantidad = (int)nudCantidad.Value
                        };

                        Opc = 'A';
                    }
                    else // Modificación
                    {
                        DetalleSalida.IdProducto = DetalleSalida.IdProducto;
                        DetalleSalida.Cantidad = (int)nudCantidad.Value;

                        Opc = 'C';
                    }

                    // Afectar en BD
                    LnSal.ABCDETALLES_SALIDA(Opc, DetalleSalida);

                    // Limpiar los controles de captura "detalle salida"
                    LimpiarControlesDetallesSalida();

                    // Actualizar información del grid 
                    LlenarGridDetalleSalida();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    btnAgregarProducto.BackgroundImage = Properties.Resources.anadir;
                    btnQuitarProducto.Visible = false;
                    DetalleSalida = null;
                }
            }
        }

        private void LimpiarControlesDetallesSalida()
        {
            lblDescripcionProducto.Text = "Elija un producto";
            nudCantidad.Value = 0;
            lblExistencia.Text = "0";
            Producto = null;
        }

        private bool ValidarDatosProducto()
        {
            if (Producto == null)
            {
                MessageBox.Show("Es necesario seleccionar un producto", "Sin producto seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscarProducto.Focus();

                return false;
            }

            if (nudCantidad.Value < 1)
            {
                MessageBox.Show("La cantidad mínima es 1, por favor revise", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nudCantidad.Focus();

                return false;
            }            
            return true;
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                LnSal.ABCDETALLES_SALIDA('B', DetalleSalida);
                LimpiarControlesDetallesSalida();
                DetalleSalida = null;
                LlenarGridDetalleSalida();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnAgregarProducto.BackgroundImage = Properties.Resources.anadir;
                btnQuitarProducto.Visible = false;
            }
        }

        private void dgvProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    if (e.RowHandle >= 0 && ModoOperacion == ModoOperacion.Modificacion)
                    {
                        // Cambiar imagen del botón agregar y mostrar el boton de quitar
                        btnAgregarProducto.BackgroundImage = Properties.Resources.edit_validated_40458;
                        btnQuitarProducto.Visible = true;

                        // Obtener datos de la fila selecciona y llenar objeto entidad y controles con dichos datos
                        DataRow FilaSeleccionada = dgvProductos.GetDataRow(e.RowHandle);
                        DetalleSalida = new Sal.DETALLES_SALIDA
                        {

                            IdDetalleSalida = (int)FilaSeleccionada["IdDetalleSalida"],
                            IdSalida = (int)FilaSeleccionada["IdSalida"],
                            IdProducto = (int)FilaSeleccionada["IdProducto"],
                            Cantidad = (int)FilaSeleccionada["Cantidad"]
                        };
                                                
                        lblDescripcionProducto.Text = FilaSeleccionada["Producto"].ToString();
                        nudCantidad.Value = (int)FilaSeleccionada["Cantidad"];
                        nudCantidad.Maximum = (int)FilaSeleccionada["Existencia"];
                        nudCantidad.Enabled = true;
                        lblExistencia.Text = $"{nudCantidad.Maximum}";
                        btnAgregarProducto.Enabled = true;
                        btnQuitarProducto.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAgregarProducto.BackgroundImage = Properties.Resources.anadir;
                btnQuitarProducto.Visible = false;
            }
        }
    }
}
