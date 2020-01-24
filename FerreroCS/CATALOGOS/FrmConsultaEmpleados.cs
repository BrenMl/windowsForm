using ClasesCS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmConsultaEmpleados : Form
    {
        // Privadas
        private readonly ClsFunciones _objFunc;
        private const string Query = "Emp.ConsultarEmpleados";
        private bool BestFitColumns;

        // Propiedades

        public DataRow FilaGrid { get; set; }

        public FrmConsultaEmpleados(bool BestFitColumns=true)
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

            dxgvDatos.Columns["IdEmpleado"].Caption = "Id";            
            dxgvDatos.Columns["IdPersona"].Visible = false;
            dxgvDatos.Columns["IdPersona"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["Calle"].Visible = false;
            dxgvDatos.Columns["Calle"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["NumExt"].Visible = false;
            dxgvDatos.Columns["NumExt"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["NumInt"].Visible = false;
            dxgvDatos.Columns["NumInt"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["IdColonia"].Visible = false;
            dxgvDatos.Columns["IdColonia"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["Colonia"].Visible = false;
            dxgvDatos.Columns["Colonia"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["IdCodigoPostal"].Visible = false;
            dxgvDatos.Columns["IdCodigoPostal"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["CodigoPostal"].Visible = false;
            dxgvDatos.Columns["CodigoPostal"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["IdMunicipio"].Visible = false;
            dxgvDatos.Columns["IdMunicipio"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["Municipio"].Visible = false;
            dxgvDatos.Columns["Municipio"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["IdEntidadFederativa"].Visible = false;
            dxgvDatos.Columns["IdEntidadFederativa"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["EntidadFederativa"].Visible = false;
            dxgvDatos.Columns["EntidadFederativa"].OptionsColumn.AllowShowHide = false;
            dxgvDatos.Columns["Referencia"].Visible = false;
            dxgvDatos.Columns["Referencia"].OptionsColumn.AllowShowHide = false;            
            dxgvDatos.Columns["Foto"].Visible = false;
            dxgvDatos.Columns["Foto"].OptionsColumn.AllowShowHide = false;

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
                    FrmEmpleados EditaEmpleado = new FrmEmpleados(ModoOperacion.Consulta, FilaGrid, this)
                    {
                        MdiParent = this.MdiParent
                    };
                    EditaEmpleado.Show(); 
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
            FrmEmpleados AltaEmpleado = new FrmEmpleados(ModoOperacion.Alta, prueba:this);
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
