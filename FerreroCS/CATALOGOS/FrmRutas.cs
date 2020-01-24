using ClasesCS;
using LogicaNegociosCS;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmRutas : Form
    {
        #region Variables
        private lnRutas _LnRuta;
        private Rut.DETALLES_RUTA _DetalleRuta;
        private Rut.RUTAS _Ruta;
        private ClsFunciones _clsFunciones;
        private FrmBuscadorGenerico _FrmBuscadorGenerico;
        private readonly ClsFunciones _objFunc;
        private ModoOperacion ModoOperacion;
        private DataRow FilaDetalleRuta;
        private DataRow FilaRuta;
        private FrmConsultaRuta FrmConsultaRuta;
        #endregion

        public FrmRutas(ModoOperacion ModoOperacion, DataRow FilaRuta = null, FrmConsultaRuta frmConsultaRuta = null)
        {
            InitializeComponent();

            #region Inicializar Variables
            this.ModoOperacion = ModoOperacion;
            this.FilaRuta = FilaRuta;
            _LnRuta = new lnRutas(ModUsuario.SessionObjEnDatosConn);
            _DetalleRuta = new Rut.DETALLES_RUTA();
            _Ruta = new Rut.RUTAS();
            _clsFunciones = new ClsFunciones();
            _FrmBuscadorGenerico = new FrmBuscadorGenerico("[Cte].[ConsultarDomicilio] null,1",
                   "IdDomicilio", "IdCliente", "IdTipoDomicilio", "IdColonia", "Latitud","Longitud","Activo","Referencia","CorreoElectronico");
            _objFunc = new ClsFunciones();
            #endregion
            this.FrmConsultaRuta = frmConsultaRuta;
            //prepararFormulario();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (Validar()) {
                try
                {
                    if (FilaRuta == null && ModoOperacion ==  ModoOperacion.Alta)
                    {
                        _Ruta.Ruta = txtRuta.Text;
                        _Ruta.Activo = (chkActivo.Checked).ToString();
                        _LnRuta.ABCRUTAS('A', _Ruta);
                        MessageBox.Show("Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModoOperacion = ModoOperacion.Consulta;
                        prepararFormulario();
                    }
                    else
                    {
                        if(FilaRuta == null && ModoOperacion == ModoOperacion.Modificacion)
                        {
                            _Ruta.Ruta = txtRuta.Text;
                            _Ruta.Activo = (chkActivo.Checked).ToString();
                            _LnRuta.ABCRUTAS('C', _Ruta);
                            MessageBox.Show("Modificado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            _Ruta.IdRuta = (int)FilaRuta["IdRuta"];
                            _Ruta.Ruta = txtRuta.Text;
                            _Ruta.Activo = (chkActivo.Checked).ToString();
                            _LnRuta.ABCRUTAS('C', _Ruta);
                            MessageBox.Show("Modificado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtRuta.Text))
            {
                MessageBox.Show("Es necesario capturar el Nombre de la Ruta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRuta.Focus();
                return false;
            }

            return true;
        }

        private bool validarDetalle()
        {
            if (string.IsNullOrEmpty(txtSecuencia.Text))
            {
                MessageBox.Show("Es necesario capturar la Secuencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSecuencia.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmbDia.Text))
            {
                MessageBox.Show("Es necesario capturar el Día", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbDia.Focus();
                return false;
            }



            if (string.IsNullOrEmpty(meLocalizacion.Text))
            {
                MessageBox.Show("Es necesario capturar el Domicilio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscarDom.Focus();
                return false;
            }

            return true;
        }
        private void FrmRutas_Shown(object sender, EventArgs e)
        {
            try
            {
                llenarCombos();
                prepararFormulario();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void prepararFormulario()
        {
            switch (ModoOperacion)
            {
                case ModoOperacion.Alta:
                    tsbGuardar.Visible = true;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = false;
                    ModoConsulta(false);
                    gcDetalles.Enabled = false;
                    break;

                case ModoOperacion.Baja:
                    tsbGuardar.Visible = false;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = true;
                    ModoConsulta(false);
                    gcDetalles.Enabled = false;
                    break;

                case ModoOperacion.Modificacion:
                    tsbGuardar.Visible = true;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = false;
                    ModoConsulta(false);
                    gcDetalles.Enabled = true;
                    break;

                case ModoOperacion.Consulta:
                    tsbGuardar.Visible = false;
                    tsbModificar.Visible = true;
                    tsbEliminar.Visible = true;
                    ModoConsulta(true);
                    gcDetalles.Enabled = true;
                    LlenaCamposRuta();
                    break;
            }
        }

        private void LlenaCamposRuta()
        {
           //Al seleccionar Ruta de BuscadorGenerico :)
           if( FilaRuta != null)
            {

                txtRuta.Text = FilaRuta["Ruta"].ToString();
                chkActivo.Checked = (bool)FilaRuta["Activo"];
                LlenaGridControl();
            }
        }

        private void LlenaGridControl()
        {
            _objFunc.LlenaGridControl(ref gcDetalleRuta, "[Rut].[ConsultarDetalleRuta]", FilaRuta["IdRuta"].ToString());

            gvDetalleRuta.Columns["IdDetalleRuta"].Visible = false;
            gvDetalleRuta.Columns["IdDetalleRuta"].OptionsColumn.AllowShowHide = false;
            gvDetalleRuta.Columns["IdRuta"].Visible = false;
            gvDetalleRuta.Columns["IdRuta"].OptionsColumn.AllowShowHide = false;
            gvDetalleRuta.Columns["IdDia"].Visible = false;
            gvDetalleRuta.Columns["IdDia"].OptionsColumn.AllowShowHide = false;
            gvDetalleRuta.Columns["IdDomicilio"].Visible = false;
            gvDetalleRuta.Columns["IdDomicilio"].OptionsColumn.AllowShowHide = false;
            gvDetalleRuta.Columns["Ruta"].Visible = false;
            gvDetalleRuta.Columns["Ruta"].OptionsColumn.AllowShowHide = false;
            gvDetalleRuta.Columns["Nota"].Visible = false;
            gvDetalleRuta.Columns["Nota"].OptionsColumn.AllowShowHide = false;
            gvDetalleRuta.Columns["Referencia"].Visible = false;
            gvDetalleRuta.Columns["Referencia"].OptionsColumn.AllowShowHide = false;
        }

        private void ModoConsulta(bool Visible)
        {
            txtRuta.ReadOnly = Visible;
            chkActivo.Enabled = !Visible;
        }

        private void llenarCombos()
        {
            _clsFunciones.LlenaCombo(ref cmbDia, "Rut.ConsultarDias");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
               
                try
                {
                    
                    if(FilaDetalleRuta == null) {
                        _DetalleRuta.Secuencia = int.Parse(txtSecuencia.Text);
                        _DetalleRuta.Nota = meNotas.Text;
                        _DetalleRuta.IdRuta = FilaRuta == null ? _Ruta.IdRuta : (int)FilaRuta["IdRuta"];
                        _DetalleRuta.IdDia = (int)cmbDia.SelectedValue;
                        _DetalleRuta.Activo = "1";
                        _LnRuta.ABCDETALLES_RUTA('A', _DetalleRuta);
                        MessageBox.Show("Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gcDetalles.Enabled = true;
                    }
                    else
                    {
                        _DetalleRuta = new Rut.DETALLES_RUTA();
                        _DetalleRuta.IdDomicilio = (int)FilaDetalleRuta["IdDomicilio"];
                        _DetalleRuta.IdDetalleRuta = (int)FilaDetalleRuta["IdDetalleRuta"];
                        _DetalleRuta.Secuencia = int.Parse(txtSecuencia.Text);
                        _DetalleRuta.Nota = meNotas.Text;
                        _DetalleRuta.IdRuta = (int)FilaDetalleRuta["IdRuta"];
                        _DetalleRuta.IdDia = (int)cmbDia.SelectedValue;
                        _DetalleRuta.Activo = chEActivoDetalleRuta.Checked.ToString();
                        _LnRuta.ABCDETALLES_RUTA('C', _DetalleRuta);
                        btnAgregar.BackgroundImage = FerreroCS.Properties.Resources.anadir;
                        FilaDetalleRuta = null;
                    }

                    LlenaGridControlD();
                    LimpiaCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void LimpiaCampos()
        {
            txtSecuencia.ResetText();
            meLocalizacion.ResetText();
            meNotas.ResetText();
        }

        private void LlenaGridControlD()
        {
            //_objFunc.LlenaGridControl(ref LlenaDetalleRuta,"[Rut].[ConsultarDetalleRuta]", _DetalleRuta.IdDetalleRuta.ToString());
            _objFunc.LlenaGridControl(ref gcDetalleRuta, "[Rut].[ConsultarDetalleRuta]", _DetalleRuta.IdRuta.ToString());

            gvDetalleRuta.Columns["IdDetalleRuta"].Visible = false;
            gvDetalleRuta.Columns["IdDetalleRuta"].OptionsColumn.AllowShowHide = false;
            gvDetalleRuta.Columns["IdRuta"].Visible = false;
            gvDetalleRuta.Columns["IdRuta"].OptionsColumn.AllowShowHide = false;
            gvDetalleRuta.Columns["IdDia"].Visible = false;
            gvDetalleRuta.Columns["IdDia"].OptionsColumn.AllowShowHide = false;
            gvDetalleRuta.Columns["IdDomicilio"].Visible = false;
            gvDetalleRuta.Columns["IdDomicilio"].OptionsColumn.AllowShowHide = false;

        }

        private void btnBuscarDom_Click(object sender, EventArgs e)
        {

            _FrmBuscadorGenerico.ShowDialog();

            if (_FrmBuscadorGenerico.FilaGrid != null)
            {

                //Mostrar lo seleccionado en el buscador generico en el meLocalizacion
                meLocalizacion.Text = $"Domicilio:" + $"\r\nCalle {_FrmBuscadorGenerico.FilaGrid["Calle"]}" +
                    $"\r\nNum Ext: {_FrmBuscadorGenerico.FilaGrid["NumExt"]}" +
                    $"\r\nNum Int: {_FrmBuscadorGenerico.FilaGrid["NumInt"]}" +
                    $"\r\nReferencia: {_FrmBuscadorGenerico.FilaGrid["Referencia"]}" +
                    $"\r\nCP: {_FrmBuscadorGenerico.FilaGrid["CodigoPostal"]}" +
                    $"\r\nColonia: {_FrmBuscadorGenerico.FilaGrid["Colonia"]}";
                
                // Guardar el id del domicilio en Detalle de la Ruta en el campo IdDomicilio
                    _DetalleRuta.IdDomicilio = (int)_FrmBuscadorGenerico.FilaGrid["IdDomicilio"];

            }
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModoOperacion = ModoOperacion.Modificacion;
            prepararFormulario();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(FilaRuta != null)
                {
                    _Ruta.IdRuta = (int)FilaRuta["IdRuta"];
                    _Ruta.Ruta = FilaRuta["Ruta"].ToString();
                    _Ruta.Activo = FilaRuta["Activo"].ToString();
                    _LnRuta.ABCRUTAS('D', _Ruta);
                    MessageBox.Show("La ruta ha sido eliminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void gvDetalleRuta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2 && e.RowHandle >= 0)
            {
                btnAgregar.BackgroundImage = FerreroCS.Properties.Resources.edit_validated_40458;
                FilaDetalleRuta = gvDetalleRuta.GetDataRow(e.RowHandle);
                LlenaCampos();
            }
        }

        private void LlenaCampos()
        {
            txtSecuencia.Text = FilaDetalleRuta["Secuencia"].ToString();
            meNotas.Text = FilaDetalleRuta["Nota"].ToString();
            meLocalizacion.Text =  $"Domicilio:" + $"\r\nCalle {FilaDetalleRuta["Calle"]}" +
                    $"\r\nNum Ext: {FilaDetalleRuta["NumExt"]}" +
                    $"\r\nNum Int: {FilaDetalleRuta["NumInt"]}" +
                    $"\r\nReferencia: {FilaDetalleRuta["Referencia"]}" +
                    $"\r\nCP: {FilaDetalleRuta["CodigoPostal"]}" +
                    $"\r\nColonia: {FilaDetalleRuta["Colonia"]}";
            cmbDia.SelectedValue = FilaDetalleRuta["IdDia"];
            chEActivoDetalleRuta.Checked = (bool)FilaDetalleRuta["Activo"];
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if(FilaDetalleRuta != null)
            {
                _DetalleRuta.IdRuta = (int)FilaDetalleRuta["IdRuta"];
                _DetalleRuta.IdDia = (int)FilaDetalleRuta["IdDia"];
                _DetalleRuta.IdDomicilio = (int)FilaDetalleRuta["IdDomicilio"];
                _DetalleRuta.IdDetalleRuta = (int)FilaDetalleRuta["IdDetalleRuta"];
                _DetalleRuta.Secuencia = (int)FilaDetalleRuta["Secuencia"];
                _DetalleRuta.Nota = FilaDetalleRuta["Nota"].ToString();
                _LnRuta.ABCDETALLES_RUTA('D', _DetalleRuta);
                LlenaGridControlD();
                LimpiaCampos();
            }
        }

        private void FrmRutas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(FrmConsultaRuta != null)
            {
                FrmConsultaRuta.LlenaGrid();
            }
        }
    }
}
