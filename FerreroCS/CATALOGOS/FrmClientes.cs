using System;
using System.Data;
using System.Windows.Forms;
using ClasesCS;
using LogicaNegociosCS;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmClientes : Form
    {
        private LnClientes _lnClientes;

        private ClsFunciones _Funciones;
        private Cte.CLIENTES _Cliente;
        private Cte.DOMICILIOS _Domicilio;
        private Cte.TELEFONOS _Telefonos;
        private FrmBuscadorGenerico FrmBucadorColonias;
        private readonly ClsFunciones _objFunc;
        private FrmBuscadorGenerico FrmBuscadorDomicilio;
        private ModoOperacion ModoOperacion;
        private DataRow FilaCliente;
        private DataRow FilaDomicilio;
        private DataRow FilaTelefono;
        private FrmMapa FrmMapa;
        private FrmConsultaClientes  FrmConsultaClientes;

        public FrmClientes(ModoOperacion ModoOperacion, DataRow FilaCliente = null, FrmConsultaClientes FrmConsultaClientes = null)
        {
            InitializeComponent();
            this.ModoOperacion = ModoOperacion;
            this.FilaCliente = FilaCliente;
            _lnClientes = new LnClientes(ModUsuario.SessionObjEnDatosConn);
           
            _Domicilio = new Cte.DOMICILIOS();
            _Funciones = new ClsFunciones();
            _Telefonos = new Cte.TELEFONOS();
            _Cliente = new Cte.CLIENTES();
            FrmBucadorColonias = new FrmBuscadorGenerico("[Loc].[prConsultaColonias]",
                   "IdEntidadFederativa", "IdMunicipio", "IdCodigoPostal", "IdColonia");
            FrmBuscadorDomicilio = new FrmBuscadorGenerico($"[Cte].[ConsultarDomicilio] {(FilaCliente != null ? (int)FilaCliente["IdCliente"] : _Cliente.IdCliente)} ", "IdDomicilio", "IdCliente", "IdColonia", "IdTipoDomicilio", "Activo");
            _objFunc = new ClsFunciones();
            this.FrmConsultaClientes = FrmConsultaClientes;
        }

        private void FrmClientes_Shown(object sender, EventArgs e)
        {           
            try
            {
                LlenarCombos();
                PrepararFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                   if(ModoOperacion == ModoOperacion.Alta)
                    {
                        _Cliente.Cliente = txtNombre.Text;
                        _Cliente.IdGiro = (int)cmbGiro.SelectedValue;
                        _lnClientes.ABCCLIENTES('A', _Cliente);
                        MessageBox.Show("Cliente registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModoOperacion = ModoOperacion.Modificacion;
                        PrepararFormulario();
                    }
                    else
                    {
                        if (ModoOperacion == ModoOperacion.Modificacion)
                        {
                            if(FilaCliente == null)
                            {
                                _Cliente.Cliente = txtNombre.Text;
                                _Cliente.IdGiro = (int)cmbGiro.SelectedValue;
                                _lnClientes.ABCCLIENTES('C', _Cliente);

                                MessageBox.Show("Cliente Modificado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNombre.ReadOnly = true;
                                cmbGiro.Enabled = false;
                                chEActivoCliente.ReadOnly = true;
                            }
                            else
                            {
                                _Cliente = new Cte.CLIENTES();
                                _Cliente.IdCliente = (int)FilaCliente["IdCliente"];
                                _Cliente.Cliente = txtNombre.Text;
                                _Cliente.IdGiro = (int)cmbGiro.SelectedValue;
                                _Cliente.Activo = chEActivoCliente.Checked.ToString();
                                _lnClientes.ABCCLIENTES('C', _Cliente);

                                MessageBox.Show("Cliente Modificado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNombre.ReadOnly = true;
                                cmbGiro.Enabled = false;
                                chEActivoCliente.ReadOnly = true;
                            }
                           
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarDomicilio())
            {
                try
                {
                    if(FilaDomicilio == null)
                    {
                        _Domicilio = new Cte.DOMICILIOS();
                        _Domicilio.Activo = chEActivoDom.Checked.ToString();
                        _Domicilio.Calle = txtCalle.Text;
                        _Domicilio.NumExt = txtNumE.Text;
                        _Domicilio.NumInt = txtNumI.Text;
                        _Domicilio.Referencia = meReferencia.Text;
                        _Domicilio.IdTipoDomicilio = (int)cmbTipoDomicilio.SelectedValue;
                        _Domicilio.IdCliente = FilaCliente == null ? _Cliente.IdCliente : (int)FilaCliente["IdCliente"];
                        _Domicilio.IdColonia = (int)FrmBucadorColonias.FilaGrid["IdColonia"];
                        _Domicilio.Latitud = float.Parse(lblLatitud.Text);
                        _Domicilio.Longitud = float.Parse(lblLongitud.Text);
                        _Domicilio.CorreoElectronico = txtEmail.Text;
                        _lnClientes.ABCDOMICILIOS('A', _Domicilio);
                        LimpiaCampos('D');
                        LlenarGridControl('A');
                        FrmBuscadorDomicilio = new FrmBuscadorGenerico($"[Cte].[ConsultarDomicilio] {(FilaCliente != null ? (int)FilaCliente["IdCliente"] : _Cliente.IdCliente)} ", "IdDomicilio", "IdCliente", "IdColonia", "IdTipoDomicilio", "Activo");
                        tnpTelefono.PageVisible = true;
                    }
                    else
                    {
                            _Domicilio = new Cte.DOMICILIOS();
                             _Domicilio.Activo = chEActivoDom.Checked.ToString();
                            _Domicilio.IdDomicilio = (int)FilaDomicilio["IdDomicilio"];
                            _Domicilio.Calle = txtCalle.Text;
                            _Domicilio.NumExt = txtNumE.Text;
                            _Domicilio.NumInt = txtNumI.Text;
                            _Domicilio.Referencia = meReferencia.Text;
                            _Domicilio.IdTipoDomicilio = (int)cmbTipoDomicilio.SelectedValue;
                            _Domicilio.IdCliente = FilaCliente == null ? _Cliente.IdCliente : (int)FilaCliente["IdCliente"];
                            _Domicilio.IdColonia = FrmBucadorColonias.FilaGrid != null ? (int)FrmBucadorColonias.FilaGrid["IdColonia"] : _Domicilio.IdColonia = (int)FilaDomicilio["IdColonia"];
                            _Domicilio.Latitud = float.Parse(lblLatitud.Text);
                            _Domicilio.Longitud = float.Parse(lblLongitud.Text);
                            _Domicilio.CorreoElectronico = txtEmail.Text;
                            _lnClientes.ABCDOMICILIOS('C', _Domicilio);
                            btnAgregar.BackgroundImage = FerreroCS.Properties.Resources.anadir;
                            LimpiaCampos('D');
                            LlenarGridControl('M');
                            FrmBuscadorDomicilio = new FrmBuscadorGenerico($"[Cte].[ConsultarDomicilio] {(FilaCliente != null ? (int)FilaCliente["IdCliente"] : _Cliente.IdCliente)} ", "IdDomicilio", "IdCliente", "IdColonia", "IdTipoDomicilio", "Activo");
                            FilaDomicilio = null;                                                                                            
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnAgregarTel_Click(object sender, EventArgs e)
        {
            if (validarTelfonos())
            {
                try
                {
                    if (FilaTelefono == null)
                    {
                        _Telefonos.IdDomicilio = (int)FrmBuscadorDomicilio.FilaGrid["IdDomicilio"];
                        _Telefonos.IdTipoTelefono = (int)cmbTipoTelefono.SelectedValue;
                        _Telefonos.Telefono = txtTelefono.Text;

                        _lnClientes.ABCTELEFONOS('A', _Telefonos);
                        LimpiaCampos('T');
                        LlenaGridControlTel();
                    }
                    else
                    {
                        _Telefonos.IdTelefono = (int)FilaTelefono["IdTelefono"];
                        _Telefonos.IdDomicilio = (int)FilaTelefono["IdDomicilio"];
                        _Telefonos.IdTipoTelefono = (int)cmbTipoTelefono.SelectedValue;
                        _Telefonos.Telefono = txtTelefono.Text;
                        _Telefonos.Activo = chEActivoTel.Checked.ToString();
                        _lnClientes.ABCTELEFONOS('C', _Telefonos);
                        LimpiaCampos('T');
                        LlenaGridControlTel();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminarDom_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (FilaDomicilio != null) {
                    _Domicilio = new Cte.DOMICILIOS();
                    _Domicilio.IdDomicilio = (int)FilaDomicilio["IdDomicilio"];
                    _Domicilio.IdCliente = (int)FilaDomicilio["IdCliente"];
                    _Domicilio.IdColonia = (int)FilaDomicilio["IdColonia"];
                    _Domicilio.IdTipoDomicilio = (int)FilaDomicilio["IdTipoDomicilio"];
                    _Domicilio.Latitud = 121323.0f;
                    _Domicilio.Longitud = 121323.0f;
                    _Domicilio.NumExt = FilaDomicilio["NumExt"].ToString();
                    _Domicilio.NumInt = FilaDomicilio["NumInt"].ToString();
                    _Domicilio.Calle = FilaDomicilio["Calle"].ToString();
                    _Domicilio.Activo = FilaDomicilio["Activo"].ToString();
                    _Domicilio.CorreoElectronico = FilaDomicilio["CorreoElectronico"].ToString();
                    _lnClientes.ABCDOMICILIOS('D', _Domicilio);
                    LimpiaCampos('D');
                    LlenarGridControl('M');
                }                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnEliminarTel_Click(object sender, EventArgs e)
        {
            if (validarTelfonos())
            {
                try
                {
                    if(FilaTelefono != null)
                    {
                        _Telefonos.IdTelefono = (int)FilaTelefono["IdTelefono"];
                        _Telefonos.IdTipoTelefono = (int)FilaTelefono["IdTipoTelefono"];
                        _Telefonos.IdDomicilio = (int)FilaTelefono["IdDomicilio"];
                        _Telefonos.Telefono = FilaTelefono["Telefono"].ToString();
                        _lnClientes.ABCTELEFONOS('D', _Telefonos);
                        LlenaGridControlTel();
                    }                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnBuscarColonia_Click(object sender, EventArgs e)
        {
            FrmBucadorColonias.ShowDialog();

            if (FrmBucadorColonias.FilaGrid != null)
            {
                meColonia.Text = $"Estado: {FrmBucadorColonias.FilaGrid["EntidadFederativa"]}" +
                    $"\r\nMnpio: {FrmBucadorColonias.FilaGrid["Municipio"]}" +
                    $"\r\nCP: {FrmBucadorColonias.FilaGrid["CodigoPostal"]}" +
                    $"\r\nColonia: {FrmBucadorColonias.FilaGrid["Colonia"]}";

            }
        }

        private void btnBuscarDom_Click(object sender, EventArgs e)
        {

            FrmBuscadorDomicilio.ShowDialog();

            if (FrmBuscadorDomicilio.FilaGrid != null)
            {
                meDomicilioCliente.Text = $"Col: {FrmBuscadorDomicilio.FilaGrid["Colonia"]}" +
                    $"\r\nCale: {FrmBuscadorDomicilio.FilaGrid["Calle"]}" +
                    $"\r\nN°E: {FrmBuscadorDomicilio.FilaGrid["NumExt"]}" +
                    $"\r\nCP: {FrmBuscadorDomicilio.FilaGrid["CodigoPostal"]}" +
                    $"\r\nRef: {FrmBuscadorDomicilio.FilaGrid["Referencia"]}";
                LlenaGridControlTel();
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
                    chEActivoCliente.Checked = true;
                    chEActivoCliente.ReadOnly = true;
                    chEActivoDom.Checked = true;
                    chEActivoDom.ReadOnly = true;
                    chEActivoTel.Checked = true;
                    chEActivoTel.ReadOnly = true;
                    ModoConsulta(true);
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
                    chEActivoCliente.ReadOnly = false;
                    ModoConsulta(true);
                    MostrarPestañas(true);
                    break;

                case ModoOperacion.Consulta:
                    tsbGuardar.Visible = false;
                    tsbModificar.Visible = true;
                    tsbEliminar.Visible = true;
                    chEActivoCliente.ReadOnly = true;
                    ModoConsulta(false);
                    MostrarPestañas(true);
                    LlenaCampos('C');
                    break;
            }
        }

        private void LlenaCampos(Char op)
        {
            if (op == 'C' && FilaCliente != null){
                txtNombre.Text = FilaCliente["Cliente"].ToString() ;
                cmbGiro.SelectedValue = (int)FilaCliente["IdGiro"] ;
                chEActivoCliente.Checked = (bool)FilaCliente["Activo"];
                LlenarGridControl('M');
                chEActivoDom.Checked = true;
                chEActivoDom.ReadOnly = true;
                chEActivoTel.Checked = true;
                chEActivoTel.ReadOnly = true;
            }
            else
            {
                if (op == 'C')
                {
                    chEActivoDom.Checked = true;
                    chEActivoDom.ReadOnly = true;
                    chEActivoTel.Checked = true;
                    chEActivoTel.ReadOnly = true;
                }
            }
            if (op == 'D')
            {
                chEActivoDom.ReadOnly = false;
                cmbTipoDomicilio.SelectedValue = FilaDomicilio["IdTipoDomicilio"];
                lblLatitud.Text = FilaDomicilio["Latitud"].ToString();
                lblLongitud.Text = FilaDomicilio["Longitud"].ToString();
                txtCalle.Text = FilaDomicilio["Calle"].ToString();
                txtNumE.Text = FilaDomicilio["NumExt"].ToString();
                txtNumI.Text = FilaDomicilio["NumInt"].ToString();
                chEActivoDom.Checked = (bool)FilaDomicilio["Activo"];
                meColonia.Text = FilaDomicilio["Colonia"].ToString();
                meReferencia.Text = FilaDomicilio["Referencia"].ToString();
                txtEmail.Text = FilaDomicilio["CorreoElectronico"].ToString();
            }
            if( op == 'T')
            {
                chEActivoTel.ReadOnly = false;
                txtTelefono.Text = FilaTelefono["Telefono"].ToString();
                cmbTipoTelefono.SelectedValue = FilaTelefono["IdTipoTelefono"];
                chEActivoTel.Checked = (bool)FilaTelefono["Activo"];
            }
            
        }

        private void MostrarPestañas(bool PageVisible)
        {
            tabClientes.Enabled = true;
            tnpDomicilio.PageVisible = true;
            tnpTelefono.PageVisible = PageVisible;
            gcDomicilio.Enabled = PageVisible;
        }

        private void ModoConsulta(bool Visible)
        {

            txtNombre.ReadOnly = !Visible;
            cmbGiro.Enabled = Visible;
            btnBuscarColonia.Enabled = Visible;
            //btnBuscarDom.Enabled = Visible;
            btnBuscarLocalizacion.Enabled = Visible;
            btnAgregar.Enabled = Visible;
            btnAgregarTel.Enabled = Visible;
            btnEliminarDom.Enabled = Visible;
            btnEliminarTel.Enabled = Visible;
            chEActivoDom.Enabled = Visible;
            chEActivoTel.Enabled = Visible;
            txtCalle.ReadOnly = !Visible;
            txtEmail.ReadOnly = !Visible;
            txtNumE.ReadOnly = !Visible;
            txtNumI.ReadOnly = !Visible;
            txtTelefono.ReadOnly = !Visible;
            cmbTipoTelefono.Enabled = Visible;
            cmbTipoDomicilio.Enabled = Visible;
            meReferencia.ReadOnly = !Visible;

        }
        private void LlenarCombos()
        {
            _Funciones.LlenaCombo(ref cmbGiro, "Cte.ConsultarGiros 1");
            _Funciones.LlenaCombo(ref cmbTipoDomicilio, "Cte.ConsultarTiposDomicilio 1");
            _Funciones.LlenaCombo(ref cmbTipoTelefono, "Cte.ConsultarTiposTelefono 1");

        }

        private void LlenarGridControl(char op)
        {
            if (op == 'A')
            {
                if (FilaCliente == null)
                    _objFunc.LlenaGridControl(ref gcDomicilios, $"[Cte].[ConsultarDomicilio] {_Cliente.IdCliente.ToString()} ");
                else
                    _objFunc.LlenaGridControl(ref gcDomicilios, $"[Cte].[ConsultarDomicilio] {FilaCliente["IdCliente"].ToString()} ");
            }
         

            if (op == 'M')
            {   
                if(FilaCliente == null)
                  _objFunc.LlenaGridControl(ref gcDomicilios, $"[Cte].[ConsultarDomicilio] { _Cliente.IdCliente.ToString()} ");
                else
                    _objFunc.LlenaGridControl(ref gcDomicilios, $"[Cte].[ConsultarDomicilio] {FilaCliente["IdCliente"].ToString()}");
            }
              

            gvDomicilios.Columns["IdDomicilio"].Visible = false;
            gvDomicilios.Columns["IdDomicilio"].OptionsColumn.AllowShowHide = false;
            gvDomicilios.Columns["IdColonia"].Visible = false;
            gvDomicilios.Columns["IdColonia"].OptionsColumn.AllowShowHide = false;
            gvDomicilios.Columns["IdCliente"].Visible = false;
            gvDomicilios.Columns["IdCliente"].OptionsColumn.AllowShowHide = false;
            gvDomicilios.Columns["IdTipoDomicilio"].Visible = false;
            gvDomicilios.Columns["IdTipoDomicilio"].OptionsColumn.AllowShowHide = false;
          

        }

        private void LimpiaCampos(char tipo)
        {
            if (tipo == 'D')
            {
                txtCalle.ResetText();
                txtNumE.ResetText();
                txtNumI.ResetText();
                lblLatitud.ResetText();
                lblLongitud.ResetText();
                meReferencia.ResetText();
                meColonia.ResetText();
            }
            if (tipo == 'T')
            {
                txtTelefono.ResetText();
            }
            

        }

        private void LlenaGridControlTel()
        {
            if (FrmBuscadorDomicilio == null)
                _objFunc.LlenaGridControl(ref gcTelefonos, "[Cte].[ConsultarTelefonos]", _Telefonos.IdDomicilio.ToString());
            else
                 _objFunc.LlenaGridControl(ref gcTelefonos, "[Cte].[ConsultarTelefonos]", FrmBuscadorDomicilio.FilaGrid["IdDomicilio"].ToString());

            gvTelefono.Columns["IdTelefono"].Visible = false;
            gvTelefono.Columns["IdTelefono"].OptionsColumn.AllowShowHide = false;
            gvTelefono.Columns["IdDomicilio"].Visible = false;
            gvTelefono.Columns["IdDomicilio"].OptionsColumn.AllowShowHide = false;
            gvTelefono.Columns["IdTipoTelefono"].Visible = false;
            gvTelefono.Columns["IdTipoTelefono"].OptionsColumn.AllowShowHide = false;
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Es necesario llenar el campo nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }
            if (cmbGiro.SelectedIndex < 0)
            {
                MessageBox.Show("Es necesario selccionar un giro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            return true;
        }

        private bool validarDomicilio()
        {
            if (cmbTipoDomicilio.SelectedIndex < 0)
            {
                MessageBox.Show("Es necesario selccionar un tipo de domicilio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                MessageBox.Show("Es necesario llenar el campo de calle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCalle.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNumE.Text))
            {
                MessageBox.Show("Es necesario llenar el número exterior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumE.Focus();
                return false;
            }
            


            return true;
        }

      

        private bool validarTelfonos()
        {
            if (string.IsNullOrEmpty(meDomicilioCliente.Text))
            {
                MessageBox.Show("Es necesario seleccionar el domicilio a asignar");
                return false;
            }
            if (cmbTipoTelefono.SelectedIndex < 0)
            {
                MessageBox.Show("Es necesario seleccionar el tipo de teléfono");
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Es necesario llenar el campo de teléfono");
                txtTelefono.Focus();
                return false;
            }
            return true;
        }

        private void gvDomicilios_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(ModoOperacion != ModoOperacion.Consulta)
            {
                if (e.Clicks == 2 && e.RowHandle >= 0)
                {
                    btnAgregar.BackgroundImage = FerreroCS.Properties.Resources.edit_validated_40458;
                    FilaDomicilio = gvDomicilios.GetDataRow(e.RowHandle);
                    LlenaCampos('D');
                }
            }
            
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModoOperacion = ModoOperacion.Modificacion;
            PrepararFormulario();
        }

        private void gvTelefono_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(ModoOperacion != ModoOperacion.Consulta)
            {
                if (e.Clicks == 2 && e.RowHandle >= 0)
                {
                    btnAgregarTel.BackgroundImage = FerreroCS.Properties.Resources.edit_validated_40458;
                    FilaTelefono = gvTelefono.GetDataRow(e.RowHandle);
                    LlenaCampos('T');
                }
            }
            
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (FilaCliente != null)
            {
                _Cliente.IdCliente = (int)FilaCliente["IdCliente"];
                _Cliente.Cliente = FilaCliente["Cliente"].ToString();
                _Cliente.IdGiro = (int)FilaCliente["IdGiro"];
                _Cliente.Activo = FilaCliente["Activo"].ToString();
                _lnClientes.ABCCLIENTES('D', _Cliente);
                MessageBox.Show("El cliente ha sido eliminado", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                _lnClientes.ABCCLIENTES('D', _Cliente);
                MessageBox.Show("El cliente ha sido eliminado", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnBuscarLocalizacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (FrmBucadorColonias.FilaGrid == null || string.IsNullOrEmpty(txtCalle.Text.Trim()))
                {
                    MessageBox.Show("Es necesario llenar el campo de Calle y seleccionar colonia", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string cadena = $"{txtCalle.Text} {txtNumE.Text}, {FrmBucadorColonias.FilaGrid["Colonia"]}, {FrmBucadorColonias.FilaGrid["Municipio"]}, " +
                    $"{FrmBucadorColonias.FilaGrid["EntidadFederativa"]}";

                FrmMapa = new FrmMapa(cadena);
                if (FrmMapa.ShowDialog() == DialogResult.OK)
                {
                    lblLatitud.Text = FrmMapa.Marker.Position.Lat.ToString();                        
                    lblLongitud.Text = FrmMapa.Marker.Position.Lng.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gcDomicilio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(FrmConsultaClientes != null)
            {
                FrmConsultaClientes.LlenarGrid();
            }
        }
    }
}
