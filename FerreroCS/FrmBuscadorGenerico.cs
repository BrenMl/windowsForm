using ClasesCS;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS
{
    public partial class FrmBuscadorGenerico : Form
    {
        // Privadas
        private readonly ClsFunciones _objFunc;
        private readonly string _querySql;
        private readonly string [] _columnasOcultar;
        private bool cerrarClick = true;
        // Propiedades
        public bool BestFitColumns { get; set; } = false;
        public DataRow FilaGrid { get; set; }

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <param name="querySql"></param>
        ///     ''' <param name="columnasOcultar"></param>
        ///     ''' <remarks></remarks>
        public FrmBuscadorGenerico(string querySql, params string[] columnasOcultar)
        {
            InitializeComponent();

            // Instanciar objetos
            _objFunc = new ClsFunciones();
            
            // Asignar variables
            _querySql = querySql;
            _columnasOcultar = columnasOcultar;
        }
        public FrmBuscadorGenerico(string querySql, bool cerrarclick, params string[] columnasOcultar)
        {
            InitializeComponent();

            // Instanciar objetos
            _objFunc = new ClsFunciones();
            cerrarClick = cerrarclick;
            // Asignar variables
            _querySql = querySql;
            _columnasOcultar = columnasOcultar;
        }
        /// <summary>
        ///     ''' Evento ejecutado al mostrarse el formulario
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void FrmBuscadorGenerico_Shown(System.Object sender, EventArgs e)
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

        /// <summary>
        ///     ''' Llena el Grid con los datos de una sentencia SQL
        ///     ''' </summary>
        ///     ''' <remarks></remarks>
        private void LlenarGrid()
        {
            _objFunc.LlenaGridControl(ref dxgDatos, _querySql);

            for (var i = 0; i <= _columnasOcultar.Length - 1; i++)
            {
                dxgvDatos.Columns[_columnasOcultar[i]].Visible = false;
                dxgvDatos.Columns[_columnasOcultar[i]].OptionsColumn.AllowShowHide = false;
            }
        }

        /// <summary>
        ///     ''' Evento ejecutado al dar click en el botón de refrescar
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void tsbRefrescar_Click(System.Object sender, EventArgs e)
        {
            LlenarGrid();
        }

        /// <summary>
        ///     ''' Evento ejecutado al dar cick en el botón de exportar a Excel
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void tsbExcel_Click(System.Object sender, EventArgs e)
        {
            if (dxgvDatos.RowCount > 0)
                _objFunc.ExportarDXGridControl(FormatosArchivo.Excel, dxgDatos);
            else
                MessageBox.Show("No existe información para exportar a Excel.", "Tabla sin información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     ''' Evento ejecutado al dar click sobre una fila del grid
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void dxgvDatos_RowClick(System.Object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                
                if (e.Clicks == 2)
                {
                    if (e.RowHandle >= 0 && cerrarClick)
                    {
                        FilaGrid = dxgvDatos.GetDataRow(e.RowHandle);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     ''' Evento ejecutado al presionar una tecla cuando el foco esta en el grid
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void dxgvDatos_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
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

        private void dxgvDatos_RowCountChanged(object sender, EventArgs e)
        {
            // mostramos los datos en la barra de estado
            tsslblRegistrosEncontrados.Text = string.Format("Registros encontrados: {0}", dxgvDatos.RowCount);
        }

        private void btnBuscar_Click(System.Object sender, System.EventArgs e)
        {
            tsbRefrescar.PerformClick();
        }

        public void AjustarColumnas()
        {
            dxgvDatos.BestFitColumns();
        }
    }
}
