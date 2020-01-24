using ClasesCS;
using FerreroCS.CATALOGOS;
using LogicaNegociosCS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.VENTAS
{
    public partial class FrmEntradas : Form
    {
        private ClsFunciones _Funciones;
        private Entr.ENTRADAS _Entradas;
        private Entr.DETALLES_ENTRADA _DetallesEntrada;
        private LnEntradas _lnEntradas;
        private LnInventario _lnInventario;
        private FrmBuscadorGenerico FrmBucadorProductos;
        private readonly ClsFunciones _objFunc;
        private DataRow FilaDetalleEntrada;
        private ModoOperacion ModoOperacion;
        private DataRow FilaEntrada;
        private string estatus;

        private FrmConsultaEntradas ConsultaEntradas;

        public FrmEntradas(ModoOperacion ModoOperacion, DataRow FilaEntrada = null, FrmConsultaEntradas ConsultaEntradas = null)
        {
            InitializeComponent();
            this.ModoOperacion = ModoOperacion;
            this.FilaEntrada = FilaEntrada;
            _Funciones = new ClsFunciones();
            _lnEntradas = new LnEntradas(ModUsuario.SessionObjEnDatosConn);
            _lnInventario = new LnInventario(ModUsuario.SessionObjEnDatosConn);
            _Entradas = new Entr.ENTRADAS();
            _DetallesEntrada = new Entr.DETALLES_ENTRADA();
            FrmBucadorProductos = new FrmBuscadorGenerico("[Pro].[ConsultarProductos] 1",
                   "IdProducto", "IdFamilia", "IdConfeccion")
            {
                Text = "Buscador de productos"
            };
            _objFunc = new ClsFunciones();

            this.ConsultaEntradas = ConsultaEntradas;

  
            if(FilaEntrada != null)
            {
                _Entradas.IdEntrada = (int)FilaEntrada["IdEntrada"];
                _Entradas.IdEstatusEntrada = (int)FilaEntrada["IdEstatusEntrada"];
                _Entradas.IdProveedor = (int)FilaEntrada["IdProveedor"];
                _Entradas.FechaEntrada = (DateTime)FilaEntrada["FechaEntrada"];
                _Entradas.FechaEntrega = (DateTime)FilaEntrada["FechaEntrega"];
                _Entradas.FolioFactura = FilaEntrada["FolioFactura"].ToString();
            }
        }
 
        private void FrmEntradas_Shown(object sender, EventArgs e)
        {
            try
            {
                lblEstatusEntrada.Text ="Captura";
                LlenarCombos();
                PrepararFormulario();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    ModoConsulta(true);
                    MostrarPestañas(false);
                    break;

                case ModoOperacion.Baja:
                    tsbGuardar.Visible = false;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = true;
                    //ModoConsulta(false);
                    //MostrarPestañas(true);
                    break;

                case ModoOperacion.Modificacion:
                    tsbGuardar.Visible = true;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = false;
                    ModoConsulta(true);
                    MostrarPestañas(true);
                    break;

                case ModoOperacion.Consulta:
                    
                    //if (FilaEntrada != null)
                    //{
                        if (_Entradas.IdEstatusEntrada == (int)EstatusEntrada.Captura)
                        {
                            tsbGuardar.Visible = false;
                            tsbModificar.Visible = true;
                            tsbEliminar.Visible = true;
                            estatus = "Captura";
                            //MostrarPestañas(true);
                        }
                        else
                        {
                            if (_Entradas.IdEstatusEntrada == (int)EstatusEntrada.Afectado)
                            {
                                tsbGuardar.Visible = false;
                                tsbModificar.Visible = false;
                                tsbEliminar.Visible = false;
                                //gpcDetalleEntradas.Enabled = false;
                                btnAfectaInventario.Visible = false;
                                dgvEntradas.OptionsBehavior.ReadOnly = true;
                                estatus = "Afectado";
                            }

                        }
                    //}
                    //else
                    //{
                    //    tsbGuardar.Visible = false;
                    //    tsbModificar.Visible = true;
                    //    tsbEliminar.Visible = true;
                       
                    //}
                    MostrarPestañas(true);
                    ModoConsulta(false);
                    LlenaCampos(estatus);
                    break;
            }
        }

        private void LlenaCampos(string v)
        {
            if(FilaEntrada != null)
            {
                cmbProveedor.SelectedValue = _Entradas.IdProveedor;// FilaEntrada["IdProveedor"];
                lblEstatusEntrada.Text = v;
                deFechaEntrada.DateTime = _Entradas.FechaEntrada; // (DateTime)FilaEntrada["FechaEntrada"];
                deFechaEntrega.DateTime = _Entradas.FechaEntrega;
                txtFactura.Text = _Entradas.FolioFactura;
                LlenaGriDetalle('L');
            }
        }

        private void MostrarPestañas(bool PageVisible)
        {
            tnpProductos.PageVisible = PageVisible;
            
        }

        private void ModoConsulta(bool Visible)
        {
            txtFactura.ReadOnly = !Visible;
            cmbProveedor.Enabled = Visible;
            deFechaEntrada.Enabled = Visible;
            deFechaEntrega.Enabled = Visible;
            btn_BuscarProducto.Enabled = Visible;
            txtCosto.ReadOnly = !Visible;
            txtCantidad.ReadOnly = !Visible;
            btn_Agregar.Enabled = Visible;
            btn_Eliminar.Enabled = Visible;
           // grcEntradas.Enabled = Visible;
        }
        private void LlenarCombos()
        {
            _Funciones.LlenaCombo(ref cmbProveedor, "Prov.ConsultarProveedores");

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    if (ModoOperacion == ModoOperacion.Alta)
                    {
                        _Entradas.FechaEntrada = deFechaEntrada.DateTime;
                        _Entradas.FechaEntrega = deFechaEntrega.DateTime;
                        _Entradas.FolioFactura = txtFactura.Text;
                        _Entradas.IdEstatusEntrada = (int)EstatusEntrada.Captura;
                        _Entradas.IdProveedor = (int)cmbProveedor.SelectedValue;
                        _lnEntradas.ABCENTRADAS('A', _Entradas);
                        MessageBox.Show("El registro se completo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModoOperacion = ModoOperacion.Modificacion;
                        PrepararFormulario();
                    }
                    else
                    {
                        if (ModoOperacion == ModoOperacion.Modificacion)
                        {

                            //_Entradas.IdEntrada = FilaEntrada != null ? (int)FilaEntrada["IdEntrada"] : _Entradas.IdEntrada;
                            _Entradas.FechaEntrada = deFechaEntrada.DateTime;
                            _Entradas.FechaEntrega = deFechaEntrega.DateTime;
                            _Entradas.FolioFactura = txtFactura.Text;
                            //_Entradas.IdEstatusEntrada = (int)EstatusEntrada.Captura;
                            _Entradas.IdProveedor = (int)cmbProveedor.SelectedValue;
                            _lnEntradas.ABCENTRADAS('C', _Entradas);
                            cmbProveedor.Enabled = false;
                            deFechaEntrada.Enabled = false;
                            MessageBox.Show("La modificación se completo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    
                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        private bool Validar()
        {
            
            if (cmbProveedor.SelectedIndex < 0)
            {
                MessageBox.Show("Es necesario selccionar un proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (deFechaEntrega.DateTime == new DateTime(1, 1, 1))
            {
                MessageBox.Show("Es necesario seleccionar una fecha de entrega", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (deFechaEntrada.DateTime == new DateTime(1, 1, 1))
            {
                MessageBox.Show("Es necesario seleccionar una fecha de compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (ValidarDetalle())
            {
                try
                {
                    if(FilaDetalleEntrada == null)
                    {
                        _DetallesEntrada.IdEntrada = _Entradas.IdEntrada;
                        _DetallesEntrada.IdProducto = (int)FrmBucadorProductos.FilaGrid["IdProducto"];
                        _DetallesEntrada.Costo = txtCosto.Text;
                        _DetallesEntrada.Cantidad = int.Parse(txtCantidad.Text);
                        _lnEntradas.ABCDETALLES_ENTRADA('A', _DetallesEntrada);
                        LimpiarCamposDetalle();
                        LlenaGriDetalle('R');
                    }
                    else
                    {
                        _DetallesEntrada.IdDetalleEntrada = (int)FilaDetalleEntrada["IdDetalleEntrada"];
                        _DetallesEntrada.IdEntrada = (int)FilaDetalleEntrada["IdEntrada"];
                        _DetallesEntrada.IdProducto = FrmBucadorProductos.FilaGrid == null ? (int)FilaDetalleEntrada["IdProducto"] : (int)FrmBucadorProductos.FilaGrid["IdProducto"];
                        _DetallesEntrada.Costo = txtCosto.Text;
                        _DetallesEntrada.Cantidad = int.Parse(txtCantidad.Text);
                        _lnEntradas.ABCDETALLES_ENTRADA('C', _DetallesEntrada);
                        LimpiarCamposDetalle();
                        LlenaGriDetalle('R');
                    }

                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LimpiarCamposDetalle()
        {
            lblNombreProducto.ResetText();
            txtCantidad.ResetText();
            txtCosto.ResetText();
        }

        private void LlenaGriDetalle(char opc)
        {
           //  if(opc == 'R')
            _objFunc.LlenaGridControl(ref grcEntradas, "[Entr].[ConsultarDetalles_Entrada]", _Entradas.IdEntrada.ToString());
            //else
            //    _objFunc.LlenaGridControl(ref grcEntradas, "[Entr].[ConsultarDetalles_Entrada]", FilaEntrada["IdEntrada"].ToString());

            dgvEntradas.Columns["IdDetalleEntrada"].Visible = false;
            dgvEntradas.Columns["IdDetalleEntrada"].OptionsColumn.AllowShowHide = false;
            dgvEntradas.Columns["IdEntrada"].Visible = false;
            dgvEntradas.Columns["IdEntrada"].OptionsColumn.AllowShowHide = false;
            dgvEntradas.Columns["IdProducto"].Visible = false;
            dgvEntradas.Columns["IdProducto"].OptionsColumn.AllowShowHide = false;
            dgvEntradas.Columns["Suma"].Visible = false;
            dgvEntradas.Columns["Suma"].OptionsColumn.AllowShowHide = false;
            dgvEntradas.Columns["Suma2"].Visible = false;
            dgvEntradas.Columns["Suma2"].OptionsColumn.AllowShowHide = false;
            dgvEntradas.Columns["Suma3"].Visible = false;
            dgvEntradas.Columns["Suma3"].OptionsColumn.AllowShowHide = false;
            dgvEntradas.Columns["Suma4"].Visible = false;
            dgvEntradas.Columns["Suma4"].OptionsColumn.AllowShowHide = false;
            if (dgvEntradas.RowCount > 0)
            {
                //lblSubtotalpesos.Text = string.Format("{0:C}", double.Parse(dgvEntradas.GetDataRow(0)["Suma"].ToString()));

                // double var = double.Parse(dgvEntradas.GetDataRow(0)["Suma2"].ToString());

                // lblivapesos.Text = string.Format("{0:C}", (var * 0.16)).ToString();
                lblSubtotal.Text = string.Format("{0:C}", (double.Parse(dgvEntradas.GetDataRow(0)["Suma"].ToString())));
                lblTotalDesc.Text = string.Format("{0:C}", (double.Parse(dgvEntradas.GetDataRow(0)["Suma3"].ToString())));
                lblTotalIEPS.Text = string.Format("{0:C}", (double.Parse(dgvEntradas.GetDataRow(0)["Suma4"].ToString())));
                lbltotalpesos.Text = string.Format("{0:C}", (double.Parse(dgvEntradas.GetDataRow(0)["Suma2"].ToString())));

            }
          
        }

        private bool ValidarDetalle()
        {

            if (string.IsNullOrEmpty(txtCosto.Text))
            {
                MessageBox.Show("El campo costo no puede estar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("El campo cantidad no puede estar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(lblNombreProducto.Text))
            {
                MessageBox.Show("Es necesario seleccionar un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
           
            return true;
        }

        private void btn_BuscarProducto_Click(object sender, EventArgs e)
        {
            FrmBucadorProductos.ShowDialog();

            if (FrmBucadorProductos.FilaGrid != null)
            {
                lblNombreProducto.Text = FrmBucadorProductos.FilaGrid["Producto"].ToString();
            }
        }

        private void dgvEntradas_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(ModoOperacion != ModoOperacion.Consulta)
            {
                if (e.Clicks == 2 && e.RowHandle >= 0)
                {
                    btn_Agregar.BackgroundImage = FerreroCS.Properties.Resources.edit_validated_40458;
                    FilaDetalleEntrada = dgvEntradas.GetDataRow(e.RowHandle);
                    LlenaCamposDetalle();
                }
            }
           
        }

        private void LlenaCamposDetalle()
        {
            lblNombreProducto.Text =  FilaDetalleEntrada["Producto"].ToString();
            txtCantidad.Text = FilaDetalleEntrada["Cantidad"].ToString();
            txtCosto.Text = FilaDetalleEntrada["Costo"].ToString();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModoOperacion = ModoOperacion.Modificacion;
            PrepararFormulario();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(FilaDetalleEntrada != null)
            {
                _DetallesEntrada.IdDetalleEntrada = (int)FilaDetalleEntrada["IdDetalleEntrada"];
                _DetallesEntrada.IdEntrada = (int)FilaDetalleEntrada["IdEntrada"];
                _DetallesEntrada.IdProducto = (int)FilaDetalleEntrada["IdProducto"];
                _DetallesEntrada.Costo = txtCosto.Text;
                _DetallesEntrada.Cantidad = int.Parse(txtCantidad.Text);
                _lnEntradas.ABCDETALLES_ENTRADA('B', _DetallesEntrada);
                LimpiarCamposDetalle();
                LlenaGriDetalle('R');
            }
            
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(FilaEntrada != null){

                    _Entradas.IdEntrada = (int)FilaEntrada["IdEntrada"];
                    _Entradas.IdEstatusEntrada = (int)FilaEntrada["IdEstatusEntrada"];

                    _Entradas.IdProveedor = (int)FilaEntrada["IdProveedor"];
                    _Entradas.FechaEntrada = (DateTime)FilaEntrada["FechaEntrada"];
                    _lnEntradas.ABCENTRADAS('B', _Entradas);
                    MessageBox.Show("La entrada ha sido eliminado", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    
                    _lnEntradas.ABCENTRADAS('B', _Entradas);
                    MessageBox.Show("La entrada ha sido eliminada", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnAfectaInventario_Click(object sender, EventArgs e)
        {
            //DetalleEntrada = (DataTable)dgvEntradas.DataSource;
            try
            {
                //if (FilaEntrada == null)
                //{
                if (!dgvEntradas.IsEmpty) {

                    _lnInventario.AfectarInventarioEntrada(_Entradas.IdEntrada);
                    MessageBox.Show("El inventario se ha afectado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModoOperacion = ModoOperacion.Consulta;
                    _Entradas.IdEstatusEntrada = (int)EstatusEntrada.Afectado;
                    PrepararFormulario();
                }
                else
                {
                    MessageBox.Show("No existen productos en la entrada para afectar el inventario ","Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                    
                //}
                //else
                //{
                    //_lnInventario.AfectarInventarioEntrada((int)FilaEntrada["IdEntrada"]);
                    //MessageBox.Show("El inventario se ha afectado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ModoOperacion = ModoOperacion.Consulta;
                    //PrepararFormulario();
               // }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FrmEntradas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if( ConsultaEntradas != null)
            {
                ConsultaEntradas.LlenaGrid();
            }
        }

        private void FrmEntradas_Load(object sender, EventArgs e)
        {

        }
    }
}
