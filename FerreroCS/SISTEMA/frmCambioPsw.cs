using ClasesCS;
using LogicaNegociosCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreroCS
{
    public partial class frmCambioPsw : Form
    {
        public frmCambioPsw()
        {
            InitializeComponent();
        }
        private bool CambioPsw;

        public bool CambioPassword
        {
            get
            {
                return this.CambioPsw;
            }
            set
            {
                this.CambioPsw = value;
            }
        }

        private bool valida()
        {
            if (txtPswActual.Text == "")
            {
                MessageBox.Show("Escriba su contraseña actual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtPwsNueva.Text == "")
            {
                MessageBox.Show("Escriba la nueva contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtPswConfirmacion.Text == "")
            {
                MessageBox.Show("Escriba la confirmacion de la contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtPwsNueva.Text != txtPswConfirmacion.Text)
            {
                MessageBox.Show("La nueva contraseña y su confirmacion deben ser iguales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!Regex.IsMatch(txtPwsNueva.Text, @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$"))
            {
                MessageBox.Show("La contraseña debe : \n\t Contener al menos una letra mayúscula.  \n\t Contener al menos una letra minúscula.  \n\t Contener al menos un número o caracter especial.  \n\t Tener una longitud mínima de 8 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            int intResult;
            LnSistema objLnSistema = new LnSistema(ModUsuario.SessionObjEnDatosConn);
            intResult = objLnSistema.ValidaHistorialPsw(ModUsuario.SessionIdUsuario, new ClsFunciones().GetMD5Hash(txtPwsNueva.Text));

            if (intResult == 1)
            {
                MessageBox.Show("La contraseña ha sido establecida anteriormente, por favor defina una nueva contraseña", "Contraseña en histórico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(System.Object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(System.Object sender, System.EventArgs e)
        {
            if (valida())
            {
                ClsFunciones fn = new ClsFunciones();
                string strNvaPsw = fn.GetMD5Hash(txtPwsNueva.Text);

                
                LnSistema objlnUsuario = new LnSistema(ModUsuario.SessionObjEnParametrosGrales.UsuarioAdmSeg, ModUsuario.SessionObjEnParametrosGrales.PswAdmSeg, ModUsuario.SessionIdUsuario);
                Sis.USUARIOS objenUsuario = new Sis.USUARIOS
                {
                    IdUsuario = ModUsuario.SessionIdUsuario,
                    CambioContrasena = "0",
                    Password = strNvaPsw,
                    UsuarioAD = false
                };              

                try
                {
                    objlnUsuario.ABCUsuarios('D', objenUsuario);

                    MessageBox.Show("La contraseña ha sido cambiada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModUsuario.SessionPassword = strNvaPsw;
                    ModUsuario.SessionObjEnDatosConn.Password = strNvaPsw;
                    CambioPassword = true;

                    Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtPwsNueva.Text = "";
                txtPswConfirmacion.Text = "";
            }
        }

        private void frmCambioPsw_Load(System.Object sender, System.EventArgs e)
        {
            CambioPassword = false;
        }
    }
}
