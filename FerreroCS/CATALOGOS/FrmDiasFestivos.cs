using System;
using ClasesCS;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;
using LogicaNegociosCS;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmDiasFestivos : Form
    {
        #region Variables
        private LnCatalogos LnCat;
        private Cat.DIAS_FESTIVOS DiasFestivos;
        private ClsFunciones Func;
        private FrmBuscadorGenerico BuscadorGenerico;
        private ModoOperacion ModoOperacion;

        private FrmConsultaDiaFestivo FrmConsultaDiaFestivo;

        #endregion

        public FrmDiasFestivos(ModoOperacion ModoOperacion, DataRow FilaGrid = null, FrmConsultaDiaFestivo frmConsultaDiaFestivo = null)
        {
            InitializeComponent();

            this.ModoOperacion = ModoOperacion;
            LnCat = new LnCatalogos(ModUsuario.SessionObjEnDatosConn);
            DiasFestivos = new Cat.DIAS_FESTIVOS();
            Func = new ClsFunciones();
            BuscadorGenerico = new FrmBuscadorGenerico("[Cat].[ConsultarDiaFestivo]", "IdDiasFestivos");

            if (FilaGrid != null)
            {
                DiasFestivos.IdDiasFestivos = (int)FilaGrid["IdDiasFestivos"];
                DiasFestivos.DiaFestivo = FilaGrid["DiaFestivo"].ToString();
                DiasFestivos.Fecha = (DateTime)FilaGrid["Fecha"];
                DiasFestivos.Notas = FilaGrid["Notas"].ToString();
            }

            this.FrmConsultaDiaFestivo = frmConsultaDiaFestivo;
        }

        private void FrmDiasFestivos_Shown(object sender, EventArgs e)
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
                    
                    break;

                case ModoOperacion.Baja:
                    tsbGuardar.Visible = false;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = true;
                    ModoConsulta(false);
                    
                    break;

                case ModoOperacion.Modificacion:
                    tsbGuardar.Visible = true;
                    tsbModificar.Visible = false;
                    tsbEliminar.Visible = true;
                    ModoConsulta(false);
                    
                    break;

                case ModoOperacion.Consulta:
                    tsbGuardar.Visible = false;
                    tsbModificar.Visible = true;
                    tsbEliminar.Visible = true;
                    ModoConsulta(true);
                    LlenarDatos('C');
                    break;
            }
        }

        private void ModoConsulta(bool Editable)
        {
            txtDiaFestivo.ReadOnly = Editable;
            deFecha.ReadOnly = Editable;
            meNotas.ReadOnly = Editable;
        }

        private void LlenarDatos(Char op)
        {
            if (op == 'C')
            {
                txtDiaFestivo.Text = DiasFestivos.DiaFestivo;
                deFecha.DateTime = DiasFestivos.Fecha;
                meNotas.Text = DiasFestivos.Notas;
            }

        }

        private void LimpiaCampos() {
            txtDiaFestivo.ResetText();
            deFecha.ResetText();
            meNotas.ResetText();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                try
                {
                    DiasFestivos.DiaFestivo = txtDiaFestivo.Text.Trim();
                    DiasFestivos.Fecha = deFecha.DateTime;
                    DiasFestivos.Notas = meNotas.Text.Trim();

                    if (ModoOperacion == ModoOperacion.Alta)
                    {
                        LnCat.ABCDIAS_FESTIVOS('A',DiasFestivos);
                        MessageBox.Show("El día festivo ha sido dado de alta", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModoOperacion = ModoOperacion.Alta;
                        PrepararFormulario();
                        LimpiaCampos();
                    }
                    else
                    {
                        if (ModoOperacion == ModoOperacion.Modificacion)
                        {
                            LnCat.ABCDIAS_FESTIVOS('C', DiasFestivos);
                            MessageBox.Show("El día festivo ha sido actualizado", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //LlenaGrid();
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtDiaFestivo.Text))
            {
                MessageBox.Show("Es necesario capturar el día festivo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaFestivo.Focus();
                return false;
            }
            if (deFecha.DateTime == new DateTime(1,1,1))
            {
                MessageBox.Show("Es necesario capturar la fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deFecha.Focus();
                return false;
            }
           

            return true;
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModoOperacion = ModoOperacion.Modificacion;
            PrepararFormulario();
            MessageBox.Show("Los datos han sido habilitados para su edición", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                LnCat.ABCDIAS_FESTIVOS('B', DiasFestivos);
                MessageBox.Show("El día festivo ha sido eliminado", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Close();
        }

        private void FrmDiasFestivos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(FrmConsultaDiaFestivo != null)
            {
                FrmConsultaDiaFestivo.LlenarGrid();
            }
        }
    }
}
