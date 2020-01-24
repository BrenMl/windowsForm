
// 
// Este código fuente fue generado automáticamente por xsd, Versión=4.6.1055.0.
// 
namespace Ent
{

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class PARAMETROS_CORREO
    {
        private int idParametroCorreoField;

        private string servidorSMTPField;

        private string correoField;

        private string contraseñaField;

        private int puertoField;

        private int minimoEnviosField;

        private int maximoEnviosField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdParametroCorreo
        {
            get
            {
                return this.idParametroCorreoField;
            }
            set
            {
                this.idParametroCorreoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ServidorSMTP
        {
            get
            {
                return this.servidorSMTPField;
            }
            set
            {
                this.servidorSMTPField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Correo
        {
            get
            {
                return this.correoField;
            }
            set
            {
                this.correoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Contraseña
        {
            get
            {
                return this.contraseñaField;
            }
            set
            {
                this.contraseñaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Puerto
        {
            get
            {
                return this.puertoField;
            }
            set
            {
                this.puertoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int MinimoEnvios
        {
            get
            {
                return this.minimoEnviosField;
            }
            set
            {
                this.minimoEnviosField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int MaximoEnvios
        {
            get
            {
                return this.maximoEnviosField;
            }
            set
            {
                this.maximoEnviosField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class PARAMETROS_AD
    {
        private string nombreServidorField;

        private int puertoField;

        private string dominioField;

        private string sufijoField;

        private string usuarioRodField;

        private string contraseñaField;

        private string dnField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NombreServidor
        {
            get
            {
                return this.nombreServidorField;
            }
            set
            {
                this.nombreServidorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Puerto
        {
            get
            {
                return this.puertoField;
            }
            set
            {
                this.puertoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Dominio
        {
            get
            {
                return this.dominioField;
            }
            set
            {
                this.dominioField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Sufijo
        {
            get
            {
                return this.sufijoField;
            }
            set
            {
                this.sufijoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UsuarioRod
        {
            get
            {
                return this.usuarioRodField;
            }
            set
            {
                this.usuarioRodField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Contraseña
        {
            get
            {
                return this.contraseñaField;
            }
            set
            {
                this.contraseñaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DN
        {
            get
            {
                return this.dnField;
            }
            set
            {
                this.dnField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class PARAMETROS_GRALES
    {
        private string nombreEmpresaField;

        private string calleField;

        private string noExtField;

        private string noIntField;

        private int idColoniaField;

        private string rFCField;

        private string representanteLegalField;

        private string serverNameField;

        private string rutaLogoReportesField;

        public string RutaFotos { get; set; }

        private string smtpField;

        private string ctaCorreoField;

        private string pswCorreoField;

        private string puertoField;

        private string pswDefaultField;

        private string usuarioAdmSegField;

        private string pswAdmSegField;

        private string serverBDField;

        private string nameBDField;

        private int pswVigenciaField;

        private string rutaExpElectronicoField;

        private string uriWebServiceField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NombreEmpresa
        {
            get
            {
                return this.nombreEmpresaField;
            }
            set
            {
                this.nombreEmpresaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Calle
        {
            get
            {
                return this.calleField;
            }
            set
            {
                this.calleField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NoExt
        {
            get
            {
                return this.noExtField;
            }
            set
            {
                this.noExtField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NoInt
        {
            get
            {
                return this.noIntField;
            }
            set
            {
                this.noIntField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdColonia
        {
            get
            {
                return this.idColoniaField;
            }
            set
            {
                this.idColoniaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RFC
        {
            get
            {
                return this.rFCField;
            }
            set
            {
                this.rFCField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RepresentanteLegal
        {
            get
            {
                return this.representanteLegalField;
            }
            set
            {
                this.representanteLegalField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ServerName
        {
            get
            {
                return this.serverNameField;
            }
            set
            {
                this.serverNameField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RutaLogoReportes
        {
            get
            {
                return this.rutaLogoReportesField;
            }
            set
            {
                this.rutaLogoReportesField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Smtp
        {
            get
            {
                return this.smtpField;
            }
            set
            {
                this.smtpField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CtaCorreo
        {
            get
            {
                return this.ctaCorreoField;
            }
            set
            {
                this.ctaCorreoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PswCorreo
        {
            get
            {
                return this.pswCorreoField;
            }
            set
            {
                this.pswCorreoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Puerto
        {
            get
            {
                return this.puertoField;
            }
            set
            {
                this.puertoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PswDefault
        {
            get
            {
                return this.pswDefaultField;
            }
            set
            {
                this.pswDefaultField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UsuarioAdmSeg
        {
            get
            {
                return this.usuarioAdmSegField;
            }
            set
            {
                this.usuarioAdmSegField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PswAdmSeg
        {
            get
            {
                return this.pswAdmSegField;
            }
            set
            {
                this.pswAdmSegField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ServerBD
        {
            get
            {
                return this.serverBDField;
            }
            set
            {
                this.serverBDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NameBD
        {
            get
            {
                return this.nameBDField;
            }
            set
            {
                this.nameBDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int PswVigencia
        {
            get
            {
                return this.pswVigenciaField;
            }
            set
            {
                this.pswVigenciaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RutaExpElectronico
        {
            get
            {
                return this.rutaExpElectronicoField;
            }
            set
            {
                this.rutaExpElectronicoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UriWebService
        {
            get
            {
                return this.uriWebServiceField;
            }
            set
            {
                this.uriWebServiceField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class PARAMETROS_ISIS_MAIL
    {
        private int segundosField;

        private string rutaLogField;

        private string horaEjecucionField;

        private int segundosReintentoField;

        private int reintentosField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Segundos
        {
            get
            {
                return this.segundosField;
            }
            set
            {
                this.segundosField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RutaLog
        {
            get
            {
                return this.rutaLogField;
            }
            set
            {
                this.rutaLogField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HoraEjecucion
        {
            get
            {
                return this.horaEjecucionField;
            }
            set
            {
                this.horaEjecucionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int SegundosReintento
        {
            get
            {
                return this.segundosReintentoField;
            }
            set
            {
                this.segundosReintentoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Reintentos
        {
            get
            {
                return this.reintentosField;
            }
            set
            {
                this.reintentosField = value;
            }
        }
    }
}
