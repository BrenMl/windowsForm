using ClasesCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreroCS.SISTEMA
{
    public partial class FrmUsuario : Form
    {

        public Sis.USUARIOS GetUsuario { get; set; }
        // Bandera que indica si sera una alta a actualizacion
        public bool blAlta { get; set; }
        // Bandera de Guardado o cancelado
        public bool Salida { get; set; }

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <remarks></remarks>
        public FrmUsuario()
        {
            // Llamada necesaria para el diseñador.
            InitializeComponent();
            // Agregue cualquier inicialización después de la llamada a InitializeComponent().

            GetUsuario = new Sis.USUARIOS();
            Salida = false;
        }

        /// <summary>
        ///     ''' Evento al cargar el formulario
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void FrmUsuario_Load(System.Object sender, EventArgs e)
        {
            ClsFunciones funciones = new ClsFunciones();
            try
            {
                funciones.LlenaCombo(ref cbPerfiles, "[Sis].prConsultaPerfiles", "null, 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al llenar los combos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (blAlta == false)
            {
                // Cargar datos del usuario a modificar
                {
                    var withBlock = GetUsuario;
                    txtNombre.Text = withBlock.Nombre;
                    txtApPaterno.Text = withBlock.ApPaterno;
                    txtApMaterno.Text = withBlock.ApMaterno;
                    txtUsuario.Text = withBlock.NombreUsuario;
                    cbPerfiles.SelectedValue = withBlock.IdPerfil;
                }
            }
        }

        /// <summary>
        ///     ''' Funcion que valida que esten llenos los datos necesarios para crear el usuario
        ///     ''' </summary>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        private bool Valida()
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Falta capturar el nombre personal del usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            if (txtApPaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Falta capturar el apellido paterno del usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApPaterno.Focus();
                return false;
            }

            if (txtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Falta capturar el nombre del usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
                return false;
            }

            if ((int)cbPerfiles.SelectedValue < 0)
            {
                MessageBox.Show("Defina el perfil del usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbPerfiles.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        ///     ''' Evento clic del boton guardar
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void TsbGuardar_Click(System.Object sender, EventArgs e)
        {
            try
            {
                if (Valida())
                {
                    Salida = true;

                    // Validamos si hay algun cambio en el nombre de usuario, que no sea del usuario que esta actualmente logueado en el sistema
                    if (GetUsuario.NombreUsuario == ModUsuario.SessionNombreUsuario & GetUsuario.NombreUsuario != txtUsuario.Text.Trim().ToString())
                        throw new Exception("No es posible cambiar tu propio nombre de usuario, intenta con una cuenta diferente.");

                    {
                        var withBlock = GetUsuario;
                        withBlock.IdPerfil = (int)cbPerfiles.SelectedValue;
                        withBlock.Nombre = txtNombre.Text.Trim();
                        withBlock.ApPaterno = txtApPaterno.Text.Trim();
                        withBlock.ApMaterno = txtApMaterno.Text.Trim();
                        withBlock.NombreUsuario = txtUsuario.Text.Trim();
                    }

                    if (blAlta)
                    {
                        {
                            var withBlock = GetUsuario;
                            withBlock.Password = ModUsuario.SessionObjEnParametrosGrales.PswDefault;
                            withBlock.CambioContrasena = "1";
                            withBlock.FechaCambioContrasena = DateTime.MinValue;
                            withBlock.Habilitado = "1";
                        }
                    }
                    else
                    {
                        var withBlock = GetUsuario;
                        withBlock.Password = null;
                        withBlock.CambioContrasena = null;
                        withBlock.FechaCambioContrasena = DateTime.MinValue;
                        withBlock.Habilitado = null;
                    }
                    Dispose();
                }
            }
            catch (Exception ex)
            {
                Salida = false;
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void HabilitaControlesUsuarioActiveDirectory(bool UsuarioAD)
        {
            // txtNombre.Enabled = Not UsuarioAD
            // txtApPaterno.Enabled = Not UsuarioAD
            // txtApMaterno.Enabled = Not UsuarioAD
            txtUsuario.Enabled = !UsuarioAD;
        }
    }
}
