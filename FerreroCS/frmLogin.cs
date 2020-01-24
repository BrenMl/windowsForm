using ClasesCS;
using EntidadNegociosCS;
using LogicaNegociosCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreroCS
{
    public partial class frmLogin : Form
    {
        private LnSistema _lnSistema;
        private int _intento = 0;
        private readonly int _maxIntentos;

        protected LnSistema ObjLnSistemaAdmin;

        public bool BlCambio { get; set; }
        public bool BlCambioPsw { get; set; }

        public frmLogin()
        {
            InitializeComponent();

            
            _maxIntentos = int.Parse(ConfigurationManager.AppSettings["intentosLogin"].ToString());
            _lnSistema = new LnSistema(ModUsuario.SessionObjEnDatosConn);
            //USUARIO
            //Almacenamos en el Tag el texto por defecto
            txtUsuario.Tag = "Usuario";
            //Ponemos el texto por defecto
            txtUsuario.Text = txtUsuario.Tag.ToString();

            //Ponemos el froecolor en gris
            txtUsuario.ForeColor = Color.Gray;


            //Suscribimos el textbox a los eventos (Se puede hacer en el diseñador)
   

            //CONTRASEÑA
            //Almacenamos en el Tag el texto por defecto
            txtPassword.Tag = "***************";
            //Ponemos el texto por defecto
            txtPassword.Text = txtPassword.Tag.ToString();

            //Ponemos el froecolor en gris
            txtPassword.ForeColor = Color.Gray;


        }
        /// <summary>

        ///     ''' Evento al mostrarse el formulario

        ///     ''' </summary>

        ///     ''' <param name="sender"></param>

        ///     ''' <param name="e"></param>

        ///     ''' <remarks></remarks>


    

        private void btnEntrar_Click(System.Object sender, EventArgs e)
        {
           
            string strMensaje = "";
            try
            {
                if (ValidaDatos())
                {
                    // Analizar el login del usuario para ver si es correcto o no
                    ClsFunciones fn = new ClsFunciones();
                    string mensaje = "";

                    // Encriptamos la contraseña a MD5
                    string passwEncr = fn.GetMD5Hash(txtPassword.Text.Trim());

                    // Consultamos información del usuario para saber si existe y que tipo de usuario es (Sistema o Active Directory)
                    Sis.USUARIOS ObjUsuario = new LnSistema(ConfigurationManager.AppSettings["UserLogin"], 
                        ConfigurationManager.AppSettings["PswLogin"]).ConsultaUsuarioLogin(txtUsuario.Text.Trim());

                    if (strMensaje != "")
                        throw new Exception(strMensaje);

                    var ParametrosGrales = new LnSistema(ConfigurationManager.AppSettings["UserLogin"], 
                        ConfigurationManager.AppSettings["PswLogin"]).ConsultaDatosAdmorseg();

                    ObjLnSistemaAdmin = new LnSistema(ParametrosGrales.UsuarioAdmSeg, ParametrosGrales.PswAdmSeg);

                    // Enviamos los datos a una funcion que valida si la contrasela y usuario son correctos
                    if (ValidaLogin(txtUsuario.Text.Trim(), passwEncr, ref mensaje))
                    {
                        BlCambio = false;

                        if (ModUsuario.SessionCambioContrasena)
                        {
                            MessageBox.Show("Su contraseña ha sido restablecida con anterioridad, por favor cambie su contraseña a una mas segura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            BlCambio = true;
                        }
                        TimeSpan ts = DateTime.Now - ModUsuario.SessionFechaCambioContrasena;

                        if (ts.TotalDays >  ModUsuario.SessionObjEnParametrosGrales.PswVigencia & BlCambio == false)
                        {
                            MessageBox.Show("La Contraseña ha caducado, por favor cambie su contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            BlCambio = true;
                        }
                      
                   

                        if (BlCambio == true)
                        {
                            frmCambioPsw frmCambiopassword = new frmCambioPsw();
                            frmCambiopassword.ShowDialog();
                            BlCambioPsw = frmCambiopassword.CambioPassword;
                        }

                        Close();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Revisamos el numero de intentos
                        _intento += 1;
                        if (_intento == _maxIntentos)
                        {
                            // Bloqueo de usuario por intentos fallidos
                            Ent.PARAMETROS_GRALES objParamGrales;
                            Sis.USUARIOS objenusuario = new Sis.USUARIOS();

                            try
                            {
                                // Se consultan datos de usuario con permisos de bloqueo (usuario administrador de seguridad
                                objParamGrales = new LnSistema(ConfigurationManager.AppSettings["UserLogin"], 
                                    ConfigurationManager.AppSettings["PswLogin"]).ConsultaDatosAdmorseg();

                                // Bloquear usuario
                                LnSistema objlnUsuario = new LnSistema(objParamGrales.UsuarioAdmSeg, objParamGrales.PswAdmSeg);
                                objenusuario.NombreUsuario = txtUsuario.Text;

                                objlnUsuario.BloqueoUsuario(objenusuario);

                                // Notificar acción
                                MessageBox.Show("Usuario bloqueado por intentos fallidos, contacte a su Administrador de sistemas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private bool ValidaDatos()
        {
            // Usuario
            if (txtUsuario.Text.Trim() == txtUsuario.Tag.ToString())
            {
                MessageBox.Show("Falta capturar su usuario.", "Información incompleta.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return false;
            }

            // Contraseña
            if (txtPassword.Text.Trim() == txtPassword.Tag.ToString())
            {
                MessageBox.Show("Falta capturar su password.", "Información incompleta.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void frmLogin_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            // Si el usuario no ha iniciado session, terminamos la aplicación.
            if (ModUsuario.SessionIdUsuario == 0)
                Close();
        }

        private bool ValidaLogin(string usuario, string password, ref string mensaje)
        {
            try
            {
                
                // Se consultan datos de usuario con permisos de bloqueo (usuario administrador de seguridad
                DataTable dtDatosGenerales = ObjLnSistemaAdmin.ValidaLogin(usuario, password);

                // Revisar el login fue correcto
                if ((int)dtDatosGenerales.Rows[0]["status"] == 0)
                {
                    // Cargar el modulo con la informacion del usuario
                    ModUsuario.SessionIdUsuario = (int)dtDatosGenerales.Rows[0]["IdUsuario"];
                    ModUsuario.SessionNombreUsuario = dtDatosGenerales.Rows[0]["NombreUsuario"].ToString();
                    ModUsuario.SessionPassword = dtDatosGenerales.Rows[0]["password"].ToString();
                    ModUsuario.SessionUsuarioAD = (bool)dtDatosGenerales.Rows[0]["UsuarioAD"];
                    ModUsuario.SessionEmpresa = dtDatosGenerales.Rows[0]["NombreEmpresa"].ToString();
                    ModUsuario.SessionCambioContrasena = (bool)dtDatosGenerales.Rows[0]["CambioContrasena"];
                    ModUsuario.SessionFechaCambioContrasena = dtDatosGenerales.Rows[0]["FechaCambioContrasena"] == DBNull.Value ? 
                        DateTime.MinValue: DateTime.Parse(dtDatosGenerales.Rows[0]["FechaCambioContrasena"].ToString());
                    
                    // Cargar informacion de "ParametrosGenerales"
                    Ent.PARAMETROS_GRALES objEnParametrosGrales = new Ent.PARAMETROS_GRALES();

                    {
                        var withBlock = objEnParametrosGrales;
                        withBlock.NombreEmpresa = dtDatosGenerales.Rows[0]["NombreEmpresa"].ToString();
                        withBlock.Calle = dtDatosGenerales.Rows[0]["Calle"].ToString();
                        withBlock.NoExt = dtDatosGenerales.Rows[0]["NoExt"].ToString();
                        withBlock.NoInt = dtDatosGenerales.Rows[0]["NoInt"].ToString();
                        withBlock.IdColonia = (int)dtDatosGenerales.Rows[0]["IdColonia"];
                        withBlock.RFC = dtDatosGenerales.Rows[0]["RFC"].ToString();
                        withBlock.RepresentanteLegal = dtDatosGenerales.Rows[0]["RepresentanteLegal"].ToString();
                        withBlock.ServerName = dtDatosGenerales.Rows[0]["ServerName"].ToString();

                        // .RutaExpElectronico = dtDatosGenerales.Rows[0]["RutaExpElectronico")

                        withBlock.RutaFotos = dtDatosGenerales.Rows[0]["RutaFotos"].ToString();
                        withBlock.RutaLogoReportes = dtDatosGenerales.Rows[0]["RutaLogoReportes"].ToString();
                        withBlock.Smtp = dtDatosGenerales.Rows[0]["Smtp"].ToString();
                        withBlock.CtaCorreo = dtDatosGenerales.Rows[0]["CtaCorreo"].ToString();
                        withBlock.PswCorreo = dtDatosGenerales.Rows[0]["PswCorreo"].ToString();
                        withBlock.Puerto = dtDatosGenerales.Rows[0]["Puerto"].ToString();
                        withBlock.PswDefault = dtDatosGenerales.Rows[0]["PswDefault"].ToString();
                        withBlock.UsuarioAdmSeg = dtDatosGenerales.Rows[0]["UsuarioAdmSeg"].ToString();
                        withBlock.PswAdmSeg = dtDatosGenerales.Rows[0]["PswAdmSeg"].ToString();
                        withBlock.ServerBD = dtDatosGenerales.Rows[0]["ServerBD"].ToString();
                        withBlock.NameBD = dtDatosGenerales.Rows[0]["NameBD"].ToString();
                        withBlock.PswVigencia = (int)dtDatosGenerales.Rows[0]["PswVigencia"];
                    }

                    ModUsuario.SessionObjEnParametrosGrales = objEnParametrosGrales;

                    // Cargar informacion para los datos de conexión
                    enDatosConn objEnDatosConn = new enDatosConn()
                    {
                        NameBD = dtDatosGenerales.Rows[0]["NameBD"].ToString(),
                        Password = dtDatosGenerales.Rows[0]["password"].ToString(),
                        ServerBD = dtDatosGenerales.Rows[0]["ServerBD"].ToString(),
                        Usuario = dtDatosGenerales.Rows[0]["NombreUsuario"].ToString()
                    };
                    ModUsuario.SessionObjEnDatosConn = objEnDatosConn;

                    return true;
                }
                else
                {
                    mensaje = dtDatosGenerales.Rows[0]["DescripcionStatus"].ToString();
                    return false;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }



        public void OnGetFocus2(object sender, EventArgs e)
        {
            //Comprobamos si el texto es el default, y si lo es lo borramos
            if (txtPassword.Text.Contains(txtPassword.Tag.ToString()))
                txtPassword.Text = "";
            //Ponemos el color en negro
            txtPassword.ForeColor = Color.Black;

        }

        public void OnLostFocus2(object sender, EventArgs e)
        {
            //En caso de que no haya texto, añadimos el texto por defecto y ponemos el color en gris
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = txtPassword.Tag.ToString();
                txtPassword.ForeColor = Color.Gray;

            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {

            txtPassword.Text = txtPassword.Tag.ToString();
            txtPassword.ForeColor = Color.Gray;
            txtUsuario.Text = txtUsuario.Tag.ToString();
            txtUsuario.ForeColor = Color.Gray;
            btnIniciar.Focus();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            //Comprobamos si el texto es el default, y si lo es lo borramos
            if (txtUsuario.Text.Contains(txtUsuario.Tag.ToString()))
                txtUsuario.Text = "";
            //Ponemos el color en negro
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                txtUsuario.Text = txtUsuario.Tag.ToString();
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
