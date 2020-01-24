using ClasesCS;
using enUtilerias;
using LogicaNegociosCS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;
using static ClasesCS.ModUsuario;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmProductos : Form
    {
        // Private
        private Producto Producto;
        private Pro.ALIAS Alias;
        private ClsFunciones Func;
        private LnProductos LnPro;
        private ModoOperacion ModoOperacion;
        private FrmConsultaProductos FrmConsultaProductos;
        public FrmProductos(ModoOperacion ModoOperacion, DataRow FilaGrid = null, FrmConsultaProductos frmConsultaProductos = null)
        {
            InitializeComponent();

            // Inicializar variables
            Producto = new Producto();
            //Alias = new Pro.ALIAS();
            Func = new ClsFunciones();
            LnPro = new LnProductos(SessionObjEnDatosConn);
            this.ModoOperacion = ModoOperacion;
            this.FrmConsultaProductos = frmConsultaProductos;
            if (FilaGrid != null)
            {
                // Producto
                Producto.IdProducto = (int)FilaGrid["IdProducto"];
                Producto.IdFamilia= (int)FilaGrid["IdFamilia"];
                Producto.IdConfeccion = (int)FilaGrid["IdConfeccion"];
                Producto.Producto = FilaGrid["Producto"].ToString();
                Producto.Codigo = FilaGrid["Codigo"].ToString();
                Producto.Activo = FilaGrid["Activo"].ToString();
                // Confección
                Producto.Confeccion.IdConfeccion = Producto.IdConfeccion;
                Producto.Confeccion.Confeccion = FilaGrid["Confeccion"].ToString();
                // Familia
                Producto.Familia.IdFamilia = Producto.IdFamilia;
                Producto.Familia.Familia = FilaGrid["Familia"].ToString();
            }            
        }

        private void FrmProductos_Shown(object sender, System.EventArgs e)
        {
            try
            {
                LlenarCombos();
                PrepararFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void LlenarCombos()
        {
            Func.LlenaCombo(ref cmbConfeccion, " Pro.ConsultarConfecciones", "1");
            Func.LlenaCombo(ref cmbFamilia, " Pro.ConsultarFamilias", "1");
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
                    MostrarPestañas(false);
                    chkActivo.Checked = true;
                    chkActivo.Enabled = false;
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
                    ModoConsulta(false);
                    MostrarPestañas(true);
                    break;

                case ModoOperacion.Consulta:
                    tsbGuardar.Visible = false;
                    tsbModificar.Visible = true;
                    tsbEliminar.Visible = true;
                    ModoConsulta(true);
                    MostrarPestañas(true);
                    LlenarDatosProducto();
                    LlenaGridAlias();
                    break;
            }
        }

        private void ModoConsulta(bool Editable)
        {
            // Datos del producto
            txtCodigo.ReadOnly = Editable;
            txtProducto.ReadOnly = Editable;
            cmbFamilia.Enabled = !Editable;
            cmbConfeccion.Enabled = !Editable;
            chkActivo.Enabled = !Editable;

            // Alias
            txtAlias.ReadOnly = Editable;            
            btnAgregarAlias.Enabled = !Editable;
            btnQuitarAlias.Enabled = !Editable;            
        }

        private void MostrarPestañas(bool PageVisible)
        {
            tnpProducto.PageVisible = true;
            tnpAlias.PageVisible = PageVisible;
        }

        private void LlenarDatosProducto()
        {
            // Producto
            txtCodigo.Text = Producto.Codigo;
            txtProducto.Text = Producto.Producto;
            cmbFamilia.SelectedValue = Producto.IdFamilia;
            cmbConfeccion.SelectedValue = Producto.IdConfeccion;
            chkActivo.Checked = Producto.Activo == "False" ? false : true;     
        }

        private void LlenaGridAlias()
        {          
            Func.LlenaGridControl(ref grcAlias, $"Pro.ConsultarAliasProducto {Producto.IdProducto}");
            dgvAlias.Columns["IdProducto"].Visible = false;
            dgvAlias.Columns["IdProducto"].OptionsColumn.AllowShowHide = false;
            dgvAlias.Columns["IdAlias"].Visible = false;
            dgvAlias.Columns["IdAlias"].OptionsColumn.AllowShowHide = false;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosProducto())
            {
                try
                {
                    // Llenar objeto "Producto"
                    Producto.IdFamilia = (int)cmbFamilia.SelectedValue;
                    Producto.IdConfeccion= (int)cmbConfeccion.SelectedValue;
                    Producto.Producto = txtProducto.Text.Trim();
                    Producto.Codigo= txtCodigo.Text.Trim();
                    Producto.Activo = chkActivo.Checked.ToString();

                    if (ModoOperacion == ModoOperacion.Alta)
                    {
                        LnPro.ABCPRODUCTOS('A', Producto);
                        MessageBox.Show("El producto ha sido dado de alta", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModoOperacion = ModoOperacion.Modificacion;
                        PrepararFormulario();
                    }
                    else if (ModoOperacion == ModoOperacion.Modificacion)
                    {
                        Producto.Activo = chkActivo.Checked ? "1" : "0";

                        LnPro.ABCPRODUCTOS('C', Producto);
                        MessageBox.Show("El producto ha sido actualizado", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool ValidarDatosProducto()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Es necesario capturar el código del producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("Es necesario la descripción del producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProducto.Focus();
                return false;
            }

            if (cmbFamilia.SelectedIndex<0)
            {
                MessageBox.Show("Es necesario seleccionar la familia del producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbFamilia.Focus();
                return false;
            }

            if (cmbConfeccion.SelectedIndex < 0)
            {
                MessageBox.Show("Es necesario seleccionar la confección del producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbFamilia.Focus();
                return false;
            }

            return true;
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModoOperacion = ModoOperacion.Modificacion;
            PrepararFormulario();
            //MessageBox.Show("Los datos han sido habilitados para su edición", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                LnPro.ABCPRODUCTOS('D', Producto);
                MessageBox.Show("El producto ha sido eliminado", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvAlias_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    if (e.RowHandle >= 0 && ModoOperacion == ModoOperacion.Modificacion)
                    {
                        // Cambiar imagen del botón agregar y mostrar el boton de quitar
                        btnAgregarAlias.BackgroundImage = Properties.Resources.edit_validated_40458;
                        btnQuitarAlias.Visible = true;

                        // Obtener datos de la fila selecciona y llenar objeto entidad y controles con dichos datos
                        DataRow FilaSeleccionada = dgvAlias.GetDataRow(e.RowHandle);
                        Alias = new Pro.ALIAS
                        {
                            IdAlias = (int)FilaSeleccionada["IdAlias"],
                            IdProducto = Producto.IdProducto,
                            Alias = FilaSeleccionada["ALias"].ToString(),
                        };
                        txtAlias.Text = Alias.Alias;                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAgregarAlias.BackgroundImage = Properties.Resources.anadir;
                btnQuitarAlias.Visible = false;
            }
        }

        private void btnAgregarAlias_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarAlias())
                {
                    // Se trata de una alta
                    if (Alias == null)
                    {
                        Alias = new Pro.ALIAS
                        {
                            IdProducto = Producto.IdProducto,
                            Alias = txtAlias.Text.Trim()
                        };

                        LnPro.ABCALIAS('A', Alias);
                    }
                    else // Es una modificación
                    {
                        Alias.Alias= txtAlias.Text.Trim();                        
                        LnPro.ABCALIAS('C', Alias);
                        btnAgregarAlias.BackgroundImage = Properties.Resources.anadir;
                    }

                    // Limpiar los controles de captura
                    txtAlias.ResetText();
                    LlenaGridAlias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnAgregarAlias.BackgroundImage = Properties.Resources.anadir;
                btnQuitarAlias .Visible = false;
                Alias = null;
            }
        }

        private bool ValidarAlias()
        {
            if (string.IsNullOrEmpty(txtAlias.Text.Trim()))
            {
                MessageBox.Show("Es necesario capturar el alias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAlias.Focus();
                return false;
            }

            return true;
        }

        private void btnQuitarAlias_Click(object sender, EventArgs e)
        {
            try
            {
                LnPro.ABCALIAS('B', Alias);
                txtAlias.ResetText();
                LlenaGridAlias();
                Alias = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnAgregarAlias.BackgroundImage = Properties.Resources.anadir;
                btnQuitarAlias.Visible = false;
            }
        }

        private void FrmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(FrmConsultaProductos != null)
            {
                FrmConsultaProductos.LlenarGrid();
            }
        }
    }
}
