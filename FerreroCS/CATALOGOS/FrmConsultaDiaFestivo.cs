using ClasesCS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmConsultaDiaFestivo : Form
    {
        private readonly ClsFunciones _objFunc;
        private const string Query = "Cat.ConsultarDiaFestivo";
        private bool BestFitColumns;

        // Propiedades        
        public DataRow FilaGrid { get; set; }

        public FrmConsultaDiaFestivo(bool BestFitColumns = true)
        {            
            InitializeComponent();

            _objFunc = new ClsFunciones();
            this.BestFitColumns = BestFitColumns;
        }

        private void FrmConsultaDiaFestivo_Shown(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public void LlenarGrid()
        {
            _objFunc.LlenaGridControl(ref dxgDatos, Query);

            dxgvDatos.Columns["IdDiasFestivos"].Visible = false;
            dxgvDatos.Columns["IdDiasFestivos"].OptionsColumn.AllowShowHide = false;

            // Ajustar ancho de columnas
            if (BestFitColumns)
                dxgvDatos.BestFitColumns();
        }

        private void dxgvDatos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2 && e.RowHandle >= 0)
                {
                    FilaGrid = dxgvDatos.GetDataRow(e.RowHandle);
                    FrmDiasFestivos EditaDiaFestivo = new FrmDiasFestivos(ModoOperacion.Consulta, FilaGrid,this)
                    {
                        MdiParent = this.MdiParent
                    };
                    EditaDiaFestivo.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dxgvDatos_RowCountChanged(object sender, EventArgs e)
        {
            // mostramos los datos en la barra de estado
            tsslblRegistrosEncontrados.Text = string.Format("Registros encontrados: {0}", dxgvDatos.RowCount);
        }

        private void dxgvDatos_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                // Mostramos en la barra de estado la serie del equipo que está seleccionado o la cantidad de equipos que se tienen seleccioandos
                int RegistrosSeleccionados = dxgvDatos.SelectedRowsCount;

                switch (RegistrosSeleccionados)
                {
                    case 0:
                        {
                            tsslbFilaSeleccionada.Text = "";
                            break;
                        }

                    default:
                        {
                            tsslbFilaSeleccionada.Text = string.Format("Registros seleccionados: {0}", RegistrosSeleccionados);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

        }

        private void dxgvDatos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                _objFunc.CopiarDesdeGrid(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmDiasFestivos AltaDiaFestivo = new FrmDiasFestivos(ModoOperacion.Alta);
            AltaDiaFestivo.MdiParent = this.MdiParent;
            AltaDiaFestivo.Show();
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();
                // Ajustar ancho de columnas
                if (BestFitColumns)
                    dxgvDatos.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
