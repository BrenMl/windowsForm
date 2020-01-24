using System;

namespace Sis
{
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class ACCIONES_SESION
    {
        private int idAccionSesionField;

        private string accionSesionField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdAccionSesion
        {
            get
            {
                return this.idAccionSesionField;
            }
            set
            {
                this.idAccionSesionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AccionSesion
        {
            get
            {
                return this.accionSesionField;
            }
            set
            {
                this.accionSesionField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class ACCIONES_SISTEMA
    {
        private int idAccionField;

        private int idMenuField;

        private string accionField;

        private string imagenField;

        private string ayudaField;

        private string separadorField;

        private string caracterField;

        private string ctrlField;

        private string altField;

        private string shiftField;

        private string botonField;

        private int ordenField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdAccion
        {
            get
            {
                return this.idAccionField;
            }
            set
            {
                this.idAccionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdMenu
        {
            get
            {
                return this.idMenuField;
            }
            set
            {
                this.idMenuField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Accion
        {
            get
            {
                return this.accionField;
            }
            set
            {
                this.accionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Imagen
        {
            get
            {
                return this.imagenField;
            }
            set
            {
                this.imagenField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ayuda
        {
            get
            {
                return this.ayudaField;
            }
            set
            {
                this.ayudaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Separador
        {
            get
            {
                return this.separadorField;
            }
            set
            {
                this.separadorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Caracter
        {
            get
            {
                return this.caracterField;
            }
            set
            {
                this.caracterField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ctrl
        {
            get
            {
                return this.ctrlField;
            }
            set
            {
                this.ctrlField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Alt
        {
            get
            {
                return this.altField;
            }
            set
            {
                this.altField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Shift
        {
            get
            {
                return this.shiftField;
            }
            set
            {
                this.shiftField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Boton
        {
            get
            {
                return this.botonField;
            }
            set
            {
                this.botonField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Orden
        {
            get
            {
                return this.ordenField;
            }
            set
            {
                this.ordenField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class HISTORIAL_PSW
    {
        private int idHistorialPswField;

        private int idUsuarioField;

        private string passwordField;

        private DateTime fechaField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdHistorialPsw
        {
            get
            {
                return this.idHistorialPswField;
            }
            set
            {
                this.idHistorialPswField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdUsuario
        {
            get
            {
                return this.idUsuarioField;
            }
            set
            {
                this.idUsuarioField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DateTime Fecha
        {
            get
            {
                return this.fechaField;
            }
            set
            {
                this.fechaField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class LOG_SESIONES
    {
        private int idLogSesionesField;

        private int idModuloField;

        private int idAccionSesionField;

        private int idUsuarioField;

        private DateTime fechaField;

        private string hostNameField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdLogSesiones
        {
            get
            {
                return this.idLogSesionesField;
            }
            set
            {
                this.idLogSesionesField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdModulo
        {
            get
            {
                return this.idModuloField;
            }
            set
            {
                this.idModuloField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdAccionSesion
        {
            get
            {
                return this.idAccionSesionField;
            }
            set
            {
                this.idAccionSesionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdUsuario
        {
            get
            {
                return this.idUsuarioField;
            }
            set
            {
                this.idUsuarioField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DateTime Fecha
        {
            get
            {
                return this.fechaField;
            }
            set
            {
                this.fechaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HostName
        {
            get
            {
                return this.hostNameField;
            }
            set
            {
                this.hostNameField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class LOG_SISTEMA
    {
        private string idLogSistemaField;

        private int idAccionField;

        private int idUsuarioField;

        private DateTime fechaField;

        private string hostNameField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IdLogSistema
        {
            get
            {
                return this.idLogSistemaField;
            }
            set
            {
                this.idLogSistemaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdAccion
        {
            get
            {
                return this.idAccionField;
            }
            set
            {
                this.idAccionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdUsuario
        {
            get
            {
                return this.idUsuarioField;
            }
            set
            {
                this.idUsuarioField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DateTime Fecha
        {
            get
            {
                return this.fechaField;
            }
            set
            {
                this.fechaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HostName
        {
            get
            {
                return this.hostNameField;
            }
            set
            {
                this.hostNameField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class MENUS
    {
        private int idMenuField;

        private int idModuloField;

        private string menuField;

        private string imagenField;

        private string ayudaField;

        private int ordenField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdMenu
        {
            get
            {
                return this.idMenuField;
            }
            set
            {
                this.idMenuField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdModulo
        {
            get
            {
                return this.idModuloField;
            }
            set
            {
                this.idModuloField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Menu
        {
            get
            {
                return this.menuField;
            }
            set
            {
                this.menuField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Imagen
        {
            get
            {
                return this.imagenField;
            }
            set
            {
                this.imagenField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ayuda
        {
            get
            {
                return this.ayudaField;
            }
            set
            {
                this.ayudaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Orden
        {
            get
            {
                return this.ordenField;
            }
            set
            {
                this.ordenField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class MODULOS
    {
        private int idModuloField;

        private string moduloField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdModulo
        {
            get
            {
                return this.idModuloField;
            }
            set
            {
                this.idModuloField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Modulo
        {
            get
            {
                return this.moduloField;
            }
            set
            {
                this.moduloField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class PERFILES
    {
        private int idPerfilField;

        private string perfilField;

        private string habilitadoField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdPerfil
        {
            get
            {
                return this.idPerfilField;
            }
            set
            {
                this.idPerfilField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Perfil
        {
            get
            {
                return this.perfilField;
            }
            set
            {
                this.perfilField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Habilitado
        {
            get
            {
                return this.habilitadoField;
            }
            set
            {
                this.habilitadoField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class PERMISOS_PERFIL
    {
        private int idPerfilField;

        private int idAccionField;

        private string habilitadoField;

        private ACCIONES_SISTEMA pK_ACCIONES_SISTEMAField;

        private PERFILES pK_PerfilesField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdPerfil
        {
            get
            {
                return this.idPerfilField;
            }
            set
            {
                this.idPerfilField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdAccion
        {
            get
            {
                return this.idAccionField;
            }
            set
            {
                this.idAccionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Habilitado
        {
            get
            {
                return this.habilitadoField;
            }
            set
            {
                this.habilitadoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ACCIONES_SISTEMA PK_ACCIONES_SISTEMA
        {
            get
            {
                return this.pK_ACCIONES_SISTEMAField;
            }
            set
            {
                this.pK_ACCIONES_SISTEMAField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PERFILES PK_Perfiles
        {
            get
            {
                return this.pK_PerfilesField;
            }
            set
            {
                this.pK_PerfilesField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class SEMAFORO
    {
        private int idSemaforoField;

        private int idTipoSemaforoField;

        private int inicioField;

        private int finField;

        private string colorField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdSemaforo
        {
            get
            {
                return this.idSemaforoField;
            }
            set
            {
                this.idSemaforoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdTipoSemaforo
        {
            get
            {
                return this.idTipoSemaforoField;
            }
            set
            {
                this.idTipoSemaforoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Inicio
        {
            get
            {
                return this.inicioField;
            }
            set
            {
                this.inicioField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Fin
        {
            get
            {
                return this.finField;
            }
            set
            {
                this.finField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class TIPO_SEMAFORO
    {
        private int idTipoSemaforoField;

        private string tipoSemaforoField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdTipoSemaforo
        {
            get
            {
                return this.idTipoSemaforoField;
            }
            set
            {
                this.idTipoSemaforoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TipoSemaforo
        {
            get
            {
                return this.tipoSemaforoField;
            }
            set
            {
                this.tipoSemaforoField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class PREGUNTAS
    {
        private int idPreguntaField;

        private string preguntaField;

        private string respuestaField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdPregunta
        {
            get
            {
                return this.idPreguntaField;
            }
            set
            {
                this.idPreguntaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Pregunta
        {
            get
            {
                return this.preguntaField;
            }
            set
            {
                this.preguntaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Respuesta
        {
            get
            {
                return this.respuestaField;
            }
            set
            {
                this.respuestaField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class USUARIOS
    {
        private int idUsuarioField;

        private int idPerfilField;

        private string nombreField;

        private string apPaternoField;

        private string apMaternoField;

        private string nombreUsuarioField;

        private string passwordField;

        private string cambioContrasenaField;

        private DateTime fechaCambioContrasenaField;

        private string habilitadoField;

        private bool usuarioADField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdUsuario
        {
            get
            {
                return this.idUsuarioField;
            }
            set
            {
                this.idUsuarioField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int IdPerfil
        {
            get
            {
                return this.idPerfilField;
            }
            set
            {
                this.idPerfilField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ApPaterno
        {
            get
            {
                return this.apPaternoField;
            }
            set
            {
                this.apPaternoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ApMaterno
        {
            get
            {
                return this.apMaternoField;
            }
            set
            {
                this.apMaternoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NombreUsuario
        {
            get
            {
                return this.nombreUsuarioField;
            }
            set
            {
                this.nombreUsuarioField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CambioContrasena
        {
            get
            {
                return this.cambioContrasenaField;
            }
            set
            {
                this.cambioContrasenaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DateTime FechaCambioContrasena
        {
            get
            {
                return this.fechaCambioContrasenaField;
            }
            set
            {
                this.fechaCambioContrasenaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Habilitado
        {
            get
            {
                return this.habilitadoField;
            }
            set
            {
                this.habilitadoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool UsuarioAD
        {
            get
            {
                return this.usuarioADField;
            }
            set
            {
                this.usuarioADField = value;
            }
        }
    }
}
