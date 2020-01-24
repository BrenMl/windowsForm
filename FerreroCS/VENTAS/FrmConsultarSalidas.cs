using ClasesCS;
using FerreroCS.CATALOGOS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.VENTAS
{
    public partial class FrmConsultarSalidas : Form
    {
        // Privadas
        private readonly ClsFunciones Funciones;
        private const string Query = "Sal.ConsultarSalidas";
        private bool BestFitColumns;

        // Propiedades
        public DataRow FilaGrid { get; set; }

        public FrmConsultarSalidas(bool BestFitColumns=true)
        {
            InitializeComponent();

            // Instanciar objetos
            Funciones = new ClsFunciones();
            this.BestFitColumns = BestFitColumns;
        }

        private void FrmConsultaEmpleados_Shown(object sender, EventArgs e)
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
            Funciones.LlenaGridControl(ref dxgDatos, Query);

            dxgvDatos.Columns["IdSalida"].Caption = "Folio";
            dxgvDatos.Columns["IdEstatusSalida"].Visible = false;
            dxgvDatos.Columns["IdEstatusSalida"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["IdPersona"].Visible = false;
            dxgvDatos.Columns["IdPersona"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["IdEmpleado"].Visible = false;
            dxgvDatos.Columns["IdEmpleado"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["Nombre"].Visible = false;
            dxgvDatos.Columns["Nombre"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["ApPaterno"].Visible = false;
            dxgvDatos.Columns["ApPaterno"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["ApMaterno"].Visible = false;
            dxgvDatos.Columns["ApMaterno"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["Foto"].Visible = false;
            dxgvDatos.Columns["INE"].Visible = false;

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
                    FrmSalidas FrmSalidas = new FrmSalidas(ModoOperacion.Consulta, FilaGrid)
                    {
                        MdiParent = this.MdiParent
                    };
                    FrmSalidas.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dxgvDatos_RowCountChanged(object sender, EventArgs e)
        {
            // Mostrar los datos en la barra de estado
            tsslblRegistrosEncontrados.Text = string.Format("Registros encontrados: {0}", dxgvDatos.RowCount);
        }

        private void dxgvDatos_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                // Mostrar en la barra de estado el registro seleccionado y la cantidad de registros seleccionados
                int ResistrosSeleccionados = dxgvDatos.SelectedRowsCount;

                switch (ResistrosSeleccionados)
                {
                    case 0:
                        {
                            tsslbFilaSeleccionada.Text = "";
                            break;
                        }

                    default:
                        {
                            tsslbFilaSeleccionada.Text = string.Format("Registros seleccionados: {0}", ResistrosSeleccionados);
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
                Funciones.CopiarDesdeGrid(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmEmpleados AltaEmpleado = new FrmEmpleados(ModoOperacion.Alta);
            AltaEmpleado.MdiParent = this.MdiParent;
            AltaEmpleado.Show();
            //this.Close();
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
