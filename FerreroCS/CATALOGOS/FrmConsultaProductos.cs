using ClasesCS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmConsultaProductos : Form
    {
        // Privadas
        private readonly ClsFunciones _objFunc;
        private const string Query = "Pro.ConsultarProductos";
        private FrmProductos FrmEditaProducto;
        private FrmProductos FrmAltaProducto;
        private bool BestFitColumns;

        // Propiedades
        public DataRow FilaGrid { get; set; }

        public FrmConsultaProductos(bool BestFitColumns = true)
        {
            InitializeComponent();

            // Instanciar objetos
            _objFunc = new ClsFunciones();
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
            _objFunc.LlenaGridControl(ref dxgDatos, Query);

            dxgvDatos.Columns["IdProducto"].Visible = false;
            dxgvDatos.Columns["IdProducto"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["IdFamilia"].Visible = false;
            dxgvDatos.Columns["IdFamilia"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["IdConfeccion"].Visible = false;
            dxgvDatos.Columns["IdConfeccion"].OptionsColumn.AllowShowHide = false;

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
                    FrmEditaProducto = new FrmProductos(ModoOperacion.Consulta, FilaGrid,this)
                    {
                        MdiParent = this.MdiParent
                    };
                    FrmEditaProducto.Show(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dxgvDatos_RowCountChanged(object sender, EventArgs e)
        {
            // Mostrar datos en la barra de estado
            tsslblRegistrosEncontrados.Text = string.Format("Registros encontrados: {0}", dxgvDatos.RowCount);
        }

        private void dxgvDatos_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                // Mostrar en la cantidad de equipos que se tienen seleccioandos
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
                _objFunc.CopiarDesdeGrid(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaProducto = new FrmProductos(ModoOperacion.Alta, frmConsultaProductos:this);
            FrmAltaProducto.MdiParent = this.MdiParent;
            FrmAltaProducto.Show();
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
