using ClasesCS;
using System;
using System.Data;
using System.Windows.Forms;
using LogicaNegociosCS;
using FerreroCS.SISTEMA;
using FerreroCS.CATALOGOS;
using FerreroCS.VENTAS;

namespace FerreroCS
{
    public partial class frmInicio : Form
    {
        private ClsFunciones _fn;

        private frmLogin login;
        public frmInicio()
        {
            InitializeComponent();
            _fn = new ClsFunciones();

            login = new frmLogin();
        }
        private void frmInicio_Load(System.Object sender, EventArgs e)
        {
            // Mostrar el formulario de login el cual llenara las variables de session
            login.ShowDialog();

        }

        /// <summary>
        ///     ''' Evento al mostrarse el formulario
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void frmInicio_Shown(System.Object sender, EventArgs e)
        {
            // Revisamos si se logueo correctamente
            if (ModUsuario.SessionIdUsuario == 0)
            {
                Close();
                return;
            }

            // Registro de inicio de sesion
            try
            {
                _fn.RegistraSesion((int)ClsEnumeradores.Modulos.Principal,(int)ClsEnumeradores.AccionesSesion.InicioSesion);

                // Si se requiere de cambio de contraseña y no se hizo
                if (login.BlCambio  & login.BlCambioPsw == false)
                {
                    MessageBox.Show("Que pedooo!!");
                    Close();
                }

                HabilitaModulos();
                LlenaInfoUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        ///     ''' Permite habilitrar los modulos a los que el usuario tiene acceo en base a sus permisos en la base de datos
        ///     ''' </summary>
        ///     ''' <remarks></remarks>
        public void HabilitaModulos()
        {
            // Permiso de acceso a modulos.
            try
            {
                DataTable dt;
                LnSistema objLnSistema = new LnSistema(ModUsuario.SessionObjEnDatosConn);
                string strError = null;
                dt = objLnSistema.ConsultaPermisosPMM(ModUsuario.SessionIdUsuario,ref strError);

                if (dt != null)
                {
                    BindingSource bind = new BindingSource
                    {
                        DataSource = dt
                    };

                    // Se habilitan los botones de acceso a los modulos
                    btnSistema.Enabled = bind.Find("IdModulo", ClsEnumeradores.Modulos.Sistema) >= 0;
                    btnCatálogos.Enabled = bind.Find("IdModulo", ClsEnumeradores.Modulos.Catalogos) >= 0;
                    btnVentas.Enabled = bind.Find("IdModulo", ClsEnumeradores.Modulos.Ventas) >= 0;
                }
            }
            catch (Exception )
            {
                throw;
            }
        }

        /// <summary>
        ///     ''' Cargar la informacion del usuario que está logueado.
        ///     ''' </summary>
        ///     ''' <remarks></remarks>
        public void LlenaInfoUsuario()
        {
            lblInfoUsuario.Text = ModUsuario.SessionNombreUsuario;
            lblPServidor.Text = ModUsuario.SessionObjEnParametrosGrales.ServerName;
            lblPBD.Text = ModUsuario.SessionObjEnParametrosGrales.ServerBD;
        }

        /// <summary>
        ///     ''' Evento click del boton que inicia el cambio de contraseña 
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void lklCambiarPsw_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (ModUsuario.SessionUsuarioAD)
            {
                MessageBox.Show("En cuentas de Active Directory no es posible realizar el cambio de contraseña desde el sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            frmCambioPsw frmCambiopassword = new frmCambioPsw();
            frmCambiopassword.ShowDialog();
        }

        /// <summary>
        ///     ''' Evento que se ejecuta al cerrar la ventana, registra la actividad del usuario en el log 
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void frmInicio_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if (ModUsuario.SessionIdUsuario != 0)
            {
               // string strErrorAcceso = null;
                try
                {
                    _fn.RegistraSesion((int)ClsEnumeradores.Modulos.Principal, (int)ClsEnumeradores.AccionesSesion.FinSesion);
                    
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al registrar acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        ///     ''' Para que cuando se regresa de un módulo se vuelvan a consultar los permisos sobre los mismos, por si han sufrido cambios
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void frmInicio_Activated(System.Object sender, EventArgs e)
        {
            try
            {
                if ( ModUsuario.SessionIdUsuario != 0)
                    HabilitaModulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al habilitar los módulos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        /// <summary>
        ///     ''' Evento click del link para el cambio del usuario
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void lklCamiarUsuario_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        ///     ''' Evento click del boton que inicia el modulo de Sistema 
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void btnSistema_Click(System.Object sender, EventArgs e)
        {
            FrmSistema frmSistema = new FrmSistema();
            frmSistema.Show();
        }

        /// <summary>
        ///     ''' Evento click del boton que inicia el modulo de catalogos 
        ///     ''' </summary>
        ///     ''' <param name="sender"></param>
        ///     ''' <param name="e"></param>
        ///     ''' <remarks></remarks>
        private void btnCatálogos_Click(System.Object sender, EventArgs e)
        {
            MDICatalogos mdiCatalogos = new MDICatalogos();
            mdiCatalogos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MDIVentas MdiVentas = new MDIVentas();
            MdiVentas.Show();
        }
    }
}
