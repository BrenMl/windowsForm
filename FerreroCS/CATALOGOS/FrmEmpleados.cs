using LogicaNegociosCS;
using System;
using System.Windows.Forms;
using enUtilerias;
using static ClasesCS.ClsEnumeradores;
using static ClasesCS.ModUsuario;
using ClasesCS;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmEmpleados : Form
    {
        // Privadas 
        private LnEmpleados LnEmp;
        private Empleado Empleado;
        private Emp.TELEFONOS Telefono;
        private FrmBuscadorGenerico FrmBucadorColonias;
        private ModoOperacion ModoOperacion;
        private ClsFunciones Func;                
        private String RutaFoto;

        private FrmConsultaEmpleados prueba;


        public FrmEmpleados(ModoOperacion ModoOperacion, DataRow FilaGrid = null, FrmConsultaEmpleados prueba = null)
        {
            InitializeComponent();

            // Inicializar variables     
            this.ModoOperacion = ModoOperacion;
            LnEmp = new LnEmpleados(SessionObjEnDatosConn);
            RutaFoto = SessionObjEnParametrosGrales.RutaFotos;
            Func = new ClsFunciones();
            FrmBucadorColonias = new FrmBuscadorGenerico("[Loc].[prConsultaColonias]", "IdEntidadFederativa", "IdMunicipio"
                , "IdCodigoPostal", "IdColonia");

            this.prueba = prueba;


            if (FilaGrid != null)
            {
                Empleado = new Empleado();

                Empleado.IdEmpleado = (int)FilaGrid["IdEmpleado"];
                Empleado.IdPersona = (int)FilaGrid["IdPersona"];
                Empleado.Comision = (int)FilaGrid["Comision"];
                Empleado.Foto = FilaGrid["Foto"].ToString();
                Empleado.FechaIngreso = FilaGrid["FechaIngreso"] == System.DBNull.Value ? new DateTime() : (DateTime)FilaGrid["FechaIngreso"];
                Empleado.INE = FilaGrid["INE"].ToString();
                Empleado.Activo = FilaGrid["Activo"].ToString();

                Empleado.Persona.IdPersona = Empleado.IdPersona;
                Empleado.Persona.IdColonia = (int)FilaGrid["IdColonia"];
                Empleado.Persona.Nombre = FilaGrid["Nombre"].ToString();
                Empleado.Persona.ApPaterno = FilaGrid["ApPaterno"].ToString();
                Empleado.Persona.ApMaterno = FilaGrid["ApMaterno"].ToString();
                Empleado.Persona.Calle = FilaGrid["Calle"].ToString();
                Empleado.Persona.NumExt = FilaGrid["NumExt"].ToString();
                Empleado.Persona.NumInt = FilaGrid["NumInt"].ToString();
                Empleado.Persona.Referencia = FilaGrid["Referencia"].ToString();

                Empleado.Persona.Colonia.IdColonia = Empleado.Persona.IdColonia;
                Empleado.Persona.Colonia.IdCodigoPostal = (int)FilaGrid["IdCodigoPostal"];
                Empleado.Persona.Colonia.Colonia = FilaGrid["Colonia"].ToString();

                Empleado.Persona.Colonia.CodigoPostal.IdCodigoPostal = Empleado.Persona.Colonia.IdCodigoPostal;
                Empleado.Persona.Colonia.CodigoPostal.CodigoPostal = (int)FilaGrid["CodigoPostal"];
                Empleado.Persona.Colonia.CodigoPostal.IdMunicipio = (int)FilaGrid["IdMunicipio"];

                Empleado.Persona.Colonia.CodigoPostal.Municipio.IdMunicipio = Empleado.Persona.Colonia.CodigoPostal.IdMunicipio;
                Empleado.Persona.Colonia.CodigoPostal.Municipio.IdEntidadFederativa = (int)FilaGrid["IdEntidadFederativa"];
                Empleado.Persona.Colonia.CodigoPostal.Municipio.Municipio = FilaGrid["Municipio"].ToString();

                Empleado.Persona.Colonia.CodigoPostal.Municipio.EntidadFederativa.IdEntidadFederativa = Empleado.Persona.Colonia.CodigoPostal.Municipio.IdEntidadFederativa;
                Empleado.Persona.Colonia.CodigoPostal.Municipio.EntidadFederativa.IdPais = (int)FilaGrid["IdEntidadFederativa"];
                Empleado.Persona.Colonia.CodigoPostal.Municipio.EntidadFederativa.EntidadFederativa = FilaGrid["EntidadFederativa"].ToString();
            }
            else
                Empleado = new Empleado();
        }

        private void FrmEmpleados_Shown(object sender, EventArgs e)
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
            Func.LlenaCombo(ref cmbTipoTelefono, "Cte.ConsultarTiposTelefono", "1");                       
        }

        private void PrepararFormulario()
        {
            switch (ModoOperacion)
            {
                case ModoOperacion.Alta:
                    tsbGuardarEmpleado.Visible = true;
                    tsbModificarEmpleado.Visible = false;
                    tsbEliminarEmpleado.Visible = false;                    
                    ModoConsulta(false);
                    MostrarPestañas(false);
                    chkActivo.Checked = true;
                    chkActivo.Enabled = false;
                    break;

                case ModoOperacion.Baja:
                    tsbGuardarEmpleado.Visible = false;
                    tsbModificarEmpleado.Visible = false;
                    tsbEliminarEmpleado.Visible = true;
                    ModoConsulta(false);
                    MostrarPestañas(true);
                    break;

                case ModoOperacion.Modificacion:
                    tsbGuardarEmpleado.Visible = true;
                    tsbModificarEmpleado.Visible = false;
                    tsbEliminarEmpleado.Visible = true;
                    ModoConsulta(false);
                    MostrarPestañas(true);                    
                    break;

                case ModoOperacion.Consulta:
                    tsbGuardarEmpleado.Visible = false;
                    tsbModificarEmpleado.Visible = true;
                    tsbEliminarEmpleado.Visible = true;
                    ModoConsulta(true);
                    MostrarPestañas(true);
                    LlenarDatosEmpledo();
                    LlenaGridTelefonos();
                    break;
            }
        }        

        private void MostrarPestañas(bool PageVisible)
        {
            tnpPersona.PageVisible = true;
            tnpTelefonos.PageVisible = PageVisible;
            tnpEmpleado.PageVisible = PageVisible;
        }

        private void ModoConsulta(bool Editable)
        {
            // Datos personales
            txtNombre.ReadOnly = Editable;
            txtApPaterno.ReadOnly = Editable;
            txtApMaterno.ReadOnly = Editable;
            chkActivo.Enabled = !Editable;
            txtCalle.ReadOnly = Editable;
            btnBuscarColonia.Enabled = !Editable;           
            txtNumExt.ReadOnly = Editable;
            txtNumInt.ReadOnly = Editable;
            meReferencia.ReadOnly = Editable;

            // Telefonos
            txtTelefono.ReadOnly = Editable;
            cmbTipoTelefono.Enabled = !Editable;
            btnAgregarTelefono.Enabled = !Editable;
            btnQuitarTelefono.Enabled = !Editable;

            // Datos laborales
            numUpDwComision.Enabled = !Editable;
            deFechaIngreso.Enabled = !Editable;
            txtINE.ReadOnly = Editable;
            btnCapturarFoto.Enabled = !Editable;
            btnEditarFoto.Enabled = !Editable;
        }

        private void LlenarDatosEmpledo()
        {
            // Generales
            txtNombre.Text = Empleado.Persona.Nombre;
            txtApPaterno.Text = Empleado.Persona.ApPaterno;
            txtApMaterno.Text = Empleado.Persona.ApMaterno;
            chkActivo.Checked = Empleado.Activo == "False" ? false : true;
            txtCalle.Text = Empleado.Persona.Calle;
            txtNumExt.Text = Empleado.Persona.NumExt;
            txtNumInt.Text = Empleado.Persona.NumInt;
            meLocalizacion.Text = $"Estado: {Empleado.Persona.Colonia.CodigoPostal.Municipio.EntidadFederativa.EntidadFederativa}" +
                    $"\r\nMnpio: {Empleado.Persona.Colonia.CodigoPostal.Municipio.Municipio}" +
                    $"\r\nCP: {Empleado.Persona.Colonia.CodigoPostal.CodigoPostal}" +
                    $"\r\nColonia: {Empleado.Persona.Colonia.Colonia}";
            meReferencia.Text = Empleado.Persona.Referencia;

            // Datos laborales
            numUpDwComision.Value = Empleado.Comision;
            deFechaIngreso.DateTime = Empleado.FechaIngreso;
            txtINE.Text = Empleado.INE;
            if (String.IsNullOrEmpty(Empleado.Foto.Trim()))
                //MessageBox.Show("El empleado no cuenta con fotografía","Actualiza datos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                pbFoto.Image = null;
            else
            {
                // Revisar si existe la foto                
                if (File.Exists(Empleado.Foto.Trim()))
                {
                    FileStream fs = new FileStream(Empleado.Foto.Trim(), FileMode.Open, FileAccess.Read);
                    pbFoto.Image = Image.FromStream(fs);
                    fs.Close();
                    fs.Dispose();
                }                    
            }
        }
        
        private void tsbGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarDatosPersonales())
            {
                try
                {
                    // Llenar objeto "Persona"
                    Empleado.Persona.Nombre = txtNombre.Text.Trim();
                    Empleado.Persona.ApPaterno = txtApPaterno.Text.Trim();
                    Empleado.Persona.ApMaterno = txtApMaterno.Text.Trim();
                    Empleado.Persona.Calle = txtCalle.Text.Trim();
                    Empleado.Persona.NumExt = txtNumExt.Text.Trim();
                    Empleado.Persona.NumInt = txtNumInt.Text.Trim();
                    Empleado.Persona.Referencia = meReferencia.Text;

                    if (ModoOperacion == ModoOperacion.Alta)
                    {
                        LnEmp.ABCEMPLEADOS('A', Empleado);
                        MessageBox.Show("El empleado ha sido dado de alta", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModoOperacion = ModoOperacion.Modificacion;
                        PrepararFormulario();
                        return;
                    }

                    if (ModoOperacion == ModoOperacion.Modificacion)
                    {
                        // Llenar datos laborales
                        Empleado.Activo = chkActivo.Checked ? "1" : "0";
                        Empleado.Comision = (int)numUpDwComision.Value;
                        Empleado.FechaIngreso = deFechaIngreso.DateTime;
                        Empleado.INE = txtINE.Text.Trim();                                             
                        // La ruta de la foto el empleado se gurda al caputurar o editar una imagen                                             

                        LnEmp.ABCEMPLEADOS('C', Empleado);
                        MessageBox.Show("El empleado ha sido actualizado", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }                
            }
        }

        private bool ValidarDatosPersonales()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Es necesario capturar el nombre", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtApPaterno.Text.Trim()))
            {
                MessageBox.Show("Es necesario capturar el apellido paterno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApPaterno.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCalle.Text.Trim()))
            {
                MessageBox.Show("Es necesario capturar la calle del domicilio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCalle.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNumExt.Text.Trim()))
            {
                MessageBox.Show("Es necesario capturar el número exterior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumExt.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(meLocalizacion.Text))
            {
                MessageBox.Show("Es necesario seleccionar una colonia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscarColonia.Focus();
                return false;
            }

            if (tnpTelefonos.PageVisible && dgvTelefonos.RowCount==0)            
            {
                tabEmpleados.SelectedPageIndex = 1;
                txtTelefono.Focus();
                MessageBox.Show("Es necesario ingresar al menos un télefono", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                return false;
            }

            if (tnpEmpleado.PageVisible && deFechaIngreso.DateTime == new DateTime(1,1,1))
            {
                tabEmpleados.SelectedPageIndex = 2;
                deFechaIngreso.Focus();
                MessageBox.Show("Es necesario ingresar la fecha de entrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnBuscarColonia_Click(object sender, EventArgs e)
        {
            FrmBucadorColonias.ShowDialog();

            if (FrmBucadorColonias.FilaGrid != null)
            {
                meLocalizacion.Text = $"Estado: {FrmBucadorColonias.FilaGrid["EntidadFederativa"]}" +
                    $"\r\nMnpio: {FrmBucadorColonias.FilaGrid["Municipio"]}" +
                    $"\r\nCP: {FrmBucadorColonias.FilaGrid["CodigoPostal"]}" +
                    $"\r\nColonia: {FrmBucadorColonias.FilaGrid["Colonia"]}";

                Empleado.Persona.IdColonia = (int)FrmBucadorColonias.FilaGrid["IdColonia"];
            }
        }
        
        private void tsbModificarEmpleado_Click(object sender, EventArgs e)
        {
            ModoOperacion = ModoOperacion.Modificacion;
            PrepararFormulario();
            //MessageBox.Show("Los datos han sido habilitados para su edición", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                LnEmp.ABCEMPLEADOS('D', Empleado);
                MessageBox.Show("El empleado ha sido eliminado", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LlenaGridTelefonos()
        {
            Func.LlenaGridControl(ref grcTelefonos, $"Emp.prConsultarTelefonos {Empleado.IdPersona}");
            dgvTelefonos.Columns["IdTelefono"].Visible = false;
            dgvTelefonos.Columns["IdTelefono"].OptionsColumn.AllowShowHide = false;
            //dgvTelefonos.Columns["IdTelefono"].Caption = "Id";
            dgvTelefonos.Columns["IdPersona"].Visible = false;
            dgvTelefonos.Columns["IdPersona"].OptionsColumn.AllowShowHide = false;
            dgvTelefonos.Columns["IdTipoTelefono"].Visible = false;
            dgvTelefonos.Columns["IdTipoTelefono"].OptionsColumn.AllowShowHide = false;
            dgvTelefonos.Columns["Activo"].Visible = false;
            dgvTelefonos.Columns["Activo"].OptionsColumn.AllowShowHide = false;
        }

        private void dgvTelefonos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2)
                {
                    if (e.RowHandle >= 0 && ModoOperacion == ModoOperacion.Modificacion)
                    {
                        // Cambiar imagen del botón agregar y mostrar el boton de quitar
                        btnAgregarTelefono.BackgroundImage = Properties.Resources.edit_validated_40458;
                        btnQuitarTelefono.Visible = true;

                        // Obtener datos de la fila selecciona y llenar objeto entidad y controles con dichos datos
                        DataRow FilaSeleccionada = dgvTelefonos.GetDataRow(e.RowHandle);
                        Telefono = new Emp.TELEFONOS
                        {
                            IdTelefono = (int)FilaSeleccionada["IdTelefono"],
                            IdPersona = Empleado.IdPersona,
                            IdTipoTelefono = (int)FilaSeleccionada["IdTipoTelefono"],
                            Telefono = FilaSeleccionada["Telefono"].ToString(),
                            Activo = FilaSeleccionada["Activo"].ToString()
                        };
                        txtTelefono.Text = Telefono.Telefono;
                        cmbTipoTelefono.SelectedValue = Telefono.IdTipoTelefono;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAgregarTelefono.BackgroundImage = Properties.Resources.anadir;
                btnQuitarTelefono.Visible = false;
            }
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTelefono())
                {
                    // Se trata de una alta
                    if (Telefono == null)
                    {
                        Telefono = new Emp.TELEFONOS
                        {
                            IdPersona = Empleado.IdPersona,
                            IdTipoTelefono = (int)cmbTipoTelefono.SelectedValue,
                            Telefono = txtTelefono.Text.Trim(),
                            Activo = "1"
                        };

                        LnEmp.ABCTELEFONOS('A', Telefono);
                    }
                    else // Es una modificación
                    {
                        Telefono.Telefono = txtTelefono.Text.Trim();
                        Telefono.IdTipoTelefono = (int)cmbTipoTelefono.SelectedValue;
                        LnEmp.ABCTELEFONOS('C', Telefono);
                        btnAgregarTelefono.BackgroundImage = Properties.Resources.anadir;
                    }

                    // Limpiar los controles de captura
                    txtTelefono.ResetText();
                    LlenaGridTelefonos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnAgregarTelefono.BackgroundImage = Properties.Resources.anadir;
                btnQuitarTelefono.Visible = false;
                Telefono = null;
            }
        }

        private bool ValidarTelefono()
        {
            if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                MessageBox.Show("Es necesario capturar el telefono","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefono.Focus();
                return false;
            }

            if (cmbTipoTelefono.SelectedIndex<0)
            {
                MessageBox.Show("Es necesario seleccionar el tipo de teléfono", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTipoTelefono.Focus();
                return false;
            }
            return true;
        }

        private void btnQuitarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                LnEmp.ABCTELEFONOS('B', Telefono);
                txtTelefono.ResetText();
                LlenaGridTelefonos();
                Telefono = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnAgregarTelefono.BackgroundImage = Properties.Resources.anadir;
                btnQuitarTelefono.Visible = false;
            }
        }        
        
        private void btnCapturarFoto_Click(object sender, EventArgs e)
        {
            FrmCapturarFoto frmCapturarFoto = new FrmCapturarFoto();
            frmCapturarFoto.ShowDialog();

            if (frmCapturarFoto.DialogResult == DialogResult.OK)
            {
                pbFoto.Image = frmCapturarFoto.pbFoto.Image;
                try
                {
                    GuardarFotoEmpleado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }
            }
        }

        private void btnEditarFoto_Click(object sender, EventArgs e)
        {
            FrmEditorImagenes FrmEditorImagenes = new FrmEditorImagenes();
            FrmEditorImagenes.ShowDialog();

            if (FrmEditorImagenes.DialogResult == DialogResult.OK)
            {
                pbFoto.Image = FrmEditorImagenes.pbFoto.Image;
                try
                {
                    GuardarFotoEmpleado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                
            }                
        }

        private void GuardarFotoEmpleado()
        {
            // Verificar que exista la ruta donde se guarda la fotografía
            if (!Directory.Exists(RutaFoto))
                Directory.CreateDirectory(RutaFoto);

            // Guardar la foto en la ruta especificada
            FileStream fstream = new FileStream(($"{RutaFoto}\\{Empleado.IdEmpleado}.jpg"), FileMode.Create, FileAccess.ReadWrite);
            pbFoto.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
            fstream.Dispose();

            // Guardar la ruta en la BD
            Empleado.Foto = $"{RutaFoto}\\{Empleado.IdEmpleado}.jpg";

            LnEmp.GuardarFoto(Empleado.IdEmpleado, Empleado.Foto);
        }

        private void FrmEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (prueba != null)
            {
                prueba.LlenarGrid();
            }
        }
    }
}
