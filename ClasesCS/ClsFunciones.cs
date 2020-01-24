using ClosedXML.Excel;
using ControlesPersonalizados;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using LogicaNegociosCS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace ClasesCS
{
    public class ClsFunciones
    {
        private readonly LnFunciones objlnFunciones;


        public ClsFunciones()
        {
            objlnFunciones = new LnFunciones(ModUsuario.SessionObjEnDatosConn);
        }

        /// <summary>
        ///     ''' Rutina que registra el acceso a un modulo en la bitacora de sesiones
        ///     ''' </summary>
        ///     ''' <param name="IdModulo">En modulo al cual se accede</param>
        ///     ''' <param name="IdAccionSesion">Accion sobre el modulo (acceso/salida)</param>
        ///     ''' <remarks></remarks>   
        public void RegistraSesion(int IdModulo, int IdAccionSesion)
        {
            try
            {
                LnSistema objLnSistemas = new LnSistema(ModUsuario.SessionObjEnDatosConn);
                Sis.LOG_SESIONES objenLogSesiones = new Sis.LOG_SESIONES
                {
                    IdModulo = IdModulo,
                    IdAccionSesion = IdAccionSesion,
                    IdUsuario = ModUsuario.SessionIdUsuario
                };

                objLnSistemas.ABClogSesiones('A', objenLogSesiones);
            }
            catch (Exception )
            {
                throw;
            }
        } 

        public string GetMD5Hash(string input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
                s.Append(b.ToString("x2").ToLower());
            return s.ToString();
        }

        /// <summary>
        /// Procedimiento que permite el llenado dinamico de un DataGridView a partir de la ejecucion de un SP o consulta a la base de datos
        /// </summary>
        /// <param name="grid">Referencia al objeto DataGrivView qure se dese llenar</param>
        /// <param name="SQL">Sentencia SQL que se desea ejecutar para obtener la informaciona mostrar en el grid</param>
        /// <param name="prametros">Parametro opcional, En caso de que el SQL sea la ejecucion de un SP, aqui se manda la cadena de parametros separdos por ","</param>
        /// <param name="binsDatos">Parametro opcional, si se requiere realizar busquedas en el grid se puede utilizar el BindingSource
        /// que permite realizar la busqueda de datos de manera sencilla</param>
        /// <remarks></remarks>
        public void LlenaDataGridView(ref DataGridView grid, string SQL, string prametros = "", BindingSource binsDatos = null,
            bool AlternarEstiloCelda = true)
        {
            try
            {
                DataTable dt = objlnFunciones.GetInfoQueryDt(SQL + " " + prametros);
                grid.DataSource = dt;

                if (binsDatos!=null)
                    binsDatos.DataSource = dt;

                grid.RowsDefaultCellStyle.BackColor = Color.White;
                
                if (AlternarEstiloCelda)
                    grid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///     ''' Funcion que permite el llenado dinamico de un ComboBox a partir de la ejecucion de un comando SQL
        ///     ''' </summary>
        ///     ''' <param name="combo">Referencia al control ComboBox que se quiere llenar</param>
        ///     ''' <param name="SQL">Sentencia SQL requerida para obtener la información con la que se llenará el control ComboBox</param>
        ///     ''' <param name="parametros">Si la sentencia SQL hace referencia a un SP, en esta cadena se envian los valores de los parametros los cuales deben ir separados por ","</param>
        ///     ''' <param name="ColValueMember">Nombre de la columna que se tomara como "ValueMember". Especificar en base cero</param>
        ///     ''' <param name="ColDisplayMemeber">Nombre de la columna que se tomara como "DsiplayMember". Especificar en base cero</param>
        ///     ''' <param name="Autocompletar">Indica si el control ComboBox contará o no con la opción de "autocompletar"</param>
        ///     ''' <remarks></remarks>
        public void LlenaCombo(ref ComboBox combo, string SQL, string parametros = "", string ColValueMember = "", string ColDisplayMemeber = "", bool Autocompletar = false, string DescPrimerItem = "", string ValPrimerItem = "")
        {
            try
            {
                // Obtener datos desde la BD
                DataTable dt = objlnFunciones.GetInfoQueryDt(SQL + " " + parametros);

                // Revisar si se requiere agregar un primer item al ComboBox.
                if (DescPrimerItem.Trim() != "")
                {
                    // Asignar los valores del primer elemento a un Datarow
                    DataRow drPrimerItem = dt.NewRow();

                    // Revisar si el ValueMember y DisplayMember se establecen por defecto o bien en alguna columna especificada
                    if (ColValueMember == "")
                    {
                        drPrimerItem[0] = ValPrimerItem;
                        drPrimerItem[1] = DescPrimerItem;
                    }
                    else
                    {
                        drPrimerItem[ColValueMember] = ValPrimerItem;
                        drPrimerItem[ColDisplayMemeber] = DescPrimerItem;
                    }

                    // Insertar el Datarow al inicio del DataTable 
                    dt.Rows.InsertAt(drPrimerItem, 0);
                }

                // Revisar si el ValueMember y DisplayMember se establecen por defecto o bien en alguna columna especificada
                if (ColValueMember == "")
                {
                    combo.ValueMember = dt.Columns[0].Caption;
                    combo.DisplayMember = dt.Columns[1].Caption;
                }
                else
                {
                    combo.ValueMember = dt.Columns[ColValueMember].Caption;
                    combo.DisplayMember = dt.Columns[ColDisplayMemeber].Caption;
                }

                // Llenar el combo con la información
                combo.DataSource = dt;

                // Revisar si el combo tendrá la función de autocompletar
                if (Autocompletar)
                {
                    AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

                    foreach (DataRow row in dt.Rows)
                        stringCol.Add(Convert.ToString(row[combo.DisplayMember]));

                    combo.AutoCompleteCustomSource = stringCol;
                    combo.AutoCompleteMode = AutoCompleteMode.Suggest;
                    combo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void LlenaCombo(ref AutocompleteComboBox combo, string SQL, string parametros = "", string ColValueMember = "", string ColDisplayMemeber = "", bool Autocompletar = false, string DescPrimerItem = "", string ValPrimerItem = "")
        {
            try
            {
                // Obtener datos desde la BD
                DataTable dt = objlnFunciones.GetInfoQueryDt(SQL + " " + parametros);

                // Revisar si se requiere agregar un primer item al ComboBox.
                if (DescPrimerItem.Trim() != "")
                {
                    // Asignar los valores del primer elemento a un Datarow
                    DataRow drPrimerItem = dt.NewRow();

                    // Revisar si el ValueMember y DisplayMember se establecen por defecto o bien en alguna columna especificada
                    if (ColValueMember == "")
                    {
                        drPrimerItem[0] = ValPrimerItem;
                        drPrimerItem[1] = DescPrimerItem;
                    }
                    else
                    {
                        drPrimerItem[ColValueMember] = ValPrimerItem;
                        drPrimerItem[ColDisplayMemeber] = DescPrimerItem;
                    }

                    // Insertar el Datarow al inicio del DataTable 
                    dt.Rows.InsertAt(drPrimerItem, 0);
                }

                // Revisar si el ValueMember y DisplayMember se establecen por defecto o bien en alguna columna especificada
                if (ColValueMember == "")
                {
                    combo.ValueMember = dt.Columns[0].Caption;
                    combo.DisplayMember = dt.Columns[1].Caption;
                }
                else
                {
                    combo.ValueMember = dt.Columns[ColValueMember].Caption;
                    combo.DisplayMember = dt.Columns[ColDisplayMemeber].Caption;
                }

                // Llenar el combo con la información
                combo.DataSource = dt;

                // Revisar si el combo tendrá la función de autocompletar
                if (Autocompletar)
                {
                    AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

                    foreach (DataRow row in dt.Rows)
                        stringCol.Add(Convert.ToString(row[combo.DisplayMember]));

                    combo.AutoCompleteCustomSource = stringCol;
                    combo.AutoCompleteMode = AutoCompleteMode.Suggest;
                    combo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///     ''' Procedimiento que permite exportar un archivo a excel.
        ///     ''' </summary>
        ///     ''' <param name="Grid">El grid que contiene la información a exportar. Es necesario que el grid se llene con un DataTable.</param>
        ///     ''' <param name="AbrirArchivo">Indica si se debe abrir el archivo al terminar el proceso de exportación.</param>
        ///     ''' <param name="MostrarSaveDialog">Si se desea que el usuario seleccione la ruta donde desea guardar el echivo, esta varible lo controla.</param>
        ///     ''' <param name="FileName">En caso de que se indique que no se desea que el usuario eliga la ruta y nomnre del archivo, aqui indicar la ruta y nombre, si se envia vacio, se almacenara en la misma ruta donde se encuentra el ejecutable y se le dara un nombre default.</param>
        ///     ''' <remarks></remarks>
        public void ExportarDataGridViewExcel(ref DataGridView Grid, bool AbrirArchivo, bool MostrarSaveDialog = true, string FileName = "")
        {
            XLWorkbook workBook = new XLWorkbook();
            try
            {
                // Creamos el datatable para exportar los datos
                // Dim dtInfo As DataTable = DirectCast(Grid.DataSource, DataTable)

                DataTable dtInfo = GetContentAsDataTable(Grid, true);

                if (dtInfo.TableName == "")
                    dtInfo.TableName = "Informacion";

                workBook.Worksheets.Add(dtInfo);

                // Si el parametro MostrarSaveDialog es true, mostramos una cuadro de dialogo al usuario para que seleccione
                // la ruta y nombre del archivo
                if (MostrarSaveDialog)
                {
                    SaveFileDialog SaveDlg = new SaveFileDialog
                    {
                        InitialDirectory = @"c:\\",
                        Filter = "Archivos de Microsoft Excel (xlsx) | *.xlsx",
                        DefaultExt = ".xlsx",
                        FileName = FileName
                    };

                    if (SaveDlg.ShowDialog() == DialogResult.OK)
                        FileName = SaveDlg.FileName;
                    else
                        return;
                }
                else
                {
                    if (FileName == "")
                        FileName = Environment.CurrentDirectory + @"\ExportGrid.xlsx";

                    // Si ya existe un archivo con ese nombre, lo eliminamos
                    if (File.Exists(FileName))
                        File.Delete(FileName);
                }

                // lo guardamos en la ruta seleccionada
                workBook.SaveAs(FileName);

                // Si se creo correctamente el archivo, lo abrimos
                if (File.Exists(FileName))
                {
                    MessageBox.Show("Archivo gardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (AbrirArchivo)
                        Process.Start(FileName);
                }
                else
                    MessageBox.Show("El archivo no se pudo guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workBook.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workBook.Dispose();
            }
        }
               
        public DataTable GetContentAsDataTable(DataGridView dgv, bool IgnoreHideColumns = false)
        {
            try
            {
                if (dgv.ColumnCount == 0)
                    return null;
                DataTable dtSource = new DataTable();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (IgnoreHideColumns & !col.Visible)
                        continue;
                    if (col.Name == string.Empty)
                        continue;
                    dtSource.Columns.Add(col.Name, col.ValueType);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                if (dtSource.Columns.Count == 0)
                    return null;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///     ''' Procedimiento que permite el llenado dinamico de un dxGrid a partir de la ejecucion de un SP o consulta a la base de datos
        ///     ''' </summary>
        ///     ''' <param name="grid">Referencia del objeto dxGrid que se desea llenar</param>
        ///     ''' <param name="SQL">Sentencia SQL con la que se obtiene la información a mostrar en el grid</param>
        ///     ''' <param name="parametros">Cuando la setencia SQL requiere parametros, estos se especifican en esta cadena</param>
        ///     ''' <param name="binsDatos">Enlace de datos que se asociará al dxGrid</param>
        ///     ''' <remarks></remarks>
        public void LlenaGridControl(ref GridControl grid, string SQL, string parametros = "", BindingSource binsDatos = null, bool AlternarEstiloCelda = true, 
            DataTable dtInfo = null, bool SelectedRowColor = true, bool MultiSelectRows = true)
        {
            try
            {
                var gridview = (GridView)grid.MainView;

                // Obtener los filtros aplicados, para al final asignarlos
                CriteriaOperator ftrFiltrosAsignados = gridview.ActiveFilterCriteria;

                // Es posible llenar el combo con un datatable previamente llenado, sino esta lleno el datatable, se llenará
                // con la consulta enviada como parametro
                DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
                if (dtInfo != null)
                    dt = dtInfo;
                else
                    dt = objlnFunciones.GetInfoQueryDt(SQL + " " + parametros);

                grid.BeginUpdate();
                gridview.Columns.Clear();
                grid.DataSource = null;
                grid.DataSource = dt;
                grid.EndUpdate();

                if (binsDatos!=null)
                    binsDatos.DataSource = dt;

                gridview.OptionsView.EnableAppearanceOddRow = AlternarEstiloCelda;

                if (SelectedRowColor)
                {
                    {
                        var withBlock = gridview;
                        withBlock.OptionsSelection.EnableAppearanceFocusedCell = true;
                        withBlock.OptionsSelection.EnableAppearanceFocusedRow = true;
                        withBlock.Appearance.FocusedRow.BackColor = Color.FromArgb(0, 122, 204);
                        withBlock.Appearance.SelectedRow.BackColor = Color.FromArgb(0, 122, 204);
                        withBlock.Appearance.SelectedRow.ForeColor = Color.White;
                        withBlock.Appearance.FocusedRow.ForeColor = Color.White;
                        withBlock.Appearance.SelectedRow.Options.UseForeColor = true;
                        withBlock.Appearance.SelectedRow.Options.UseBackColor = true;
                    }
                }

                // Multiselect
                gridview.OptionsSelection.MultiSelect = MultiSelectRows;

                // If MultiSelectRows Then
                // With gridview
                // .OptionsSelection.MultiSelect = True
                // '.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
                // End With
                // End If

                // Aplicar los filtros que tenia el grid antes de su llenado
                gridview.ActiveFilterCriteria = ftrFiltrosAsignados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        /// <summary>
        ///     ''' Procedimiento que permite exportar un archivo a excel.
        ///     ''' </summary>
        ///     ''' <param name="formato">Especifica el formato al que se exportará la información del grid</param>
        ///     ''' <param name="DxGridControl">Grid que contiene la información a exportar</param>
        ///     ''' <param name="AbrirArchivo">Indica si se debe abrir el archivo al terminar el proceso de exportación.</param>
        ///     ''' <param name="MostrarSaveDialog">Indica si se mostrará un cuadro de diálogo para guardar el archivo</param>
        ///     ''' <param name="FileName">Indica el nombre del archivo, si se envia vacio se almacenara la ruta donde se encuentra el ejecutable y se le dara un nombre por default</param>
        ///     ''' <remarks></remarks>
        public void ExportarDXGridControl(FormatosArchivo formato, GridControl DxGridControl, bool AbrirArchivo = true, bool MostrarSaveDialog = true, string FileName = "")
        {

            // DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG

            try
            {
                SaveFileDialog SaveDlg = new SaveFileDialog
                {
                    InitialDirectory = @"c:\\",
                    FileName = FileName
                };

                switch (formato)
                {
                    case FormatosArchivo.csv:
                        {
                            SaveDlg.Filter = "Archivos separado por comas csv (.csv) | *.csv";
                            SaveDlg.DefaultExt = ".csv";
                            if (MostrarSaveDialog)
                            {
                                if (SaveDlg.ShowDialog() == DialogResult.OK)
                                    FileName = SaveDlg.FileName;
                                else
                                    return;
                            }
                            else if (FileName == "")
                                FileName = Environment.CurrentDirectory + @"\GridExportado.csv";

                            DxGridControl.ExportToCsv(FileName);
                            break;
                        }

                    case FormatosArchivo.Excel:
                        {
                            SaveDlg.Filter = "Archivos de Excel (.xlsx) | *.xlsx";
                            SaveDlg.DefaultExt = ".xlsx";
                            if (MostrarSaveDialog)
                            {
                                if (SaveDlg.ShowDialog() == DialogResult.OK)
                                    FileName = SaveDlg.FileName;
                                else
                                    return;
                            }
                            else if (FileName == "")
                                FileName = Environment.CurrentDirectory + @"\GridExportado.xlsx";

                            XlsxExportOptionsEx options = new XlsxExportOptionsEx
                            {
                                ExportType = DevExpress.Export.ExportType.WYSIWYG
                            };
                            DxGridControl.ExportToXlsx(FileName, options);
                            break;
                        }

                    case FormatosArchivo.html:
                        {
                            SaveDlg.Filter = "Archivos html (.html) | *.html";
                            SaveDlg.DefaultExt = ".html";
                            if (MostrarSaveDialog)
                            {
                                if (SaveDlg.ShowDialog() == DialogResult.OK)
                                    FileName = SaveDlg.FileName;
                                else
                                    return;
                            }
                            else if (FileName == "")
                                FileName = Environment.CurrentDirectory + @"\GridExportado.html";

                            DxGridControl.ExportToHtml(FileName);
                            break;
                        }

                    case FormatosArchivo.pdf:
                        {
                            SaveDlg.Filter = "Archivos de Adobe Reader (.pdf) | *.pdf";
                            SaveDlg.DefaultExt = ".pdf";
                            if (MostrarSaveDialog)
                            {
                                if (SaveDlg.ShowDialog() == DialogResult.OK)
                                    FileName = SaveDlg.FileName;
                                else
                                    return;
                            }
                            else if (FileName == "")
                                FileName = Environment.CurrentDirectory + @"\GridExportado.pdf";

                            DxGridControl.ExportToPdf(FileName);
                            break;
                        }

                    case FormatosArchivo.rtf:
                        {
                            SaveDlg.Filter = "Archivos de texto enriquecido Reader (.rtf) | *.rtf";
                            SaveDlg.DefaultExt = ".rtf";
                            if (MostrarSaveDialog)
                            {
                                if (SaveDlg.ShowDialog() == DialogResult.OK)
                                    FileName = SaveDlg.FileName;
                                else
                                    return;
                            }
                            else if (FileName == "")
                                FileName = Environment.CurrentDirectory + @"\GridExportado.rtf";

                            DxGridControl.ExportToRtf(FileName);
                            break;
                        }

                    case FormatosArchivo.text:
                        {
                            SaveDlg.Filter = "Archivos de texto e (.txt) | *.txt";
                            SaveDlg.DefaultExt = ".txt";
                            if (MostrarSaveDialog)
                            {
                                if (SaveDlg.ShowDialog() == DialogResult.OK)
                                    FileName = SaveDlg.FileName;
                                else
                                    return;
                            }
                            else if (FileName == "")
                                FileName = Environment.CurrentDirectory + @"\GridExportado.rtf";

                            DxGridControl.ExportToText(FileName);
                            break;
                        }
                }

                if (AbrirArchivo)
                    Process.Start(FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible exportar los datos del control. Causa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     ''' Habilitar las opciones de copiado desde un dxGridView.
        ///     ''' "Ctrl + C".- Copia el contenido de la celda.
        ///     ''' "Ctrl + Shift + C".- Copia el contenido de toda la fila.
        ///     ''' </summary>
        ///     ''' <param name="sender">dxGridView</param>
        ///     ''' <param name="e">Controlador del evento keydown</param>
        ///     ''' <remarks></remarks>
        public void CopiarDesdeGrid(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.Control & e.KeyCode == Keys.C & !e.Shift)
                    Clipboard.SetText(((GridView)sender).GetFocusedDisplayText());
                else if (e.Control & e.KeyCode == Keys.C & e.Shift)
                    Clipboard.SetText(GetSelectedValues((GridView)sender));

                e.Handled = true;
            }
            catch (Exception)
            {                
            }
        }

        private string GetSelectedValues(GridView View)
        {
            if ((View.SelectedRowsCount == 0))
            {
                return "";
            }

            const string CellDelimiter = "\t";
            const string LineDelimiter = "\r\n";
            string Result = "";
            int I;
            int J;
            int Row;
            for (I = (View.SelectedRowsCount - 1); (I <= 0); I = (I + -1))
            {
                Row = View.GetSelectedRows()[I];
                for (J = 0; (J
                            <= (View.VisibleColumns.Count - 1)); J++)
                {
                    Result = (Result + View.GetRowCellDisplayText(Row, View.VisibleColumns[J]));
                    if ((J
                                != (View.VisibleColumns.Count - 1)))
                    {
                        Result = (Result + CellDelimiter);
                    }

                }

                if ((I != 0))
                {
                    Result = (Result + LineDelimiter);
                }

            }

            return Result;
        }
    }
}
