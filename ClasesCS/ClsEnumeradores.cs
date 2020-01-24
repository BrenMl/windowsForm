using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCS
{
    public class ClsEnumeradores
    {
        public enum ModoOperacion
        {
            Alta = 1,
            Baja = 2,
            Modificacion = 3,
            Consulta = 4
        }

        public enum Acciones
        {
            Alta = 1,
            Baja = 2,
            Modificacion = 3,
            Consulta = 4,
            ActivarDesactivar = 5
        }

        public enum EstadoEjecucionSP
        {
            Correcto = 0,
            Incorrecto = 1
        }

        public enum FormatosArchivo
        {
            csv = 1,
            Excel = 2,
            rtf = 3,
            text = 4,
            pdf = 5,
            html = 6
        }

        public enum AccionesSesion
        {
            InicioSesion = 1,
            FinSesion = 2,
            IngresoModulo = 3,
            SalidaModulo = 4,
            BloqueoIntentosFallidos = 5,
            BloqueoPorAdministrador = 6,
            DesbloqueoUsuario = 7
        }

        public enum Modulos
        {
            Principal = 1,
            Sistema = 2,
            Catalogos = 3,
            Ventas = 4
        }

        public enum Menus
        {
            Perfiles = 1,
            Usuarios = 2
        }

        public enum AccionesSistema
        {
            AltaPerfil = 1,
            ActualizacionPerfil = 2,
            CambioStatusPerfil = 3,
            AsignacionPermisos = 4,
            ReportesPerfiles = 5,
            AltaUsuario = 6,
            ActualizacionUsuario = 7,
            CambioStatusUsuario = 8,
            ReseteoContraseña = 9,
            ReportesUsuarios = 10,
            MonitorUsuarios = 11
        }

        public enum TeclasAtajos
        {
            Ctrl = 131072,
            Alt = 262144,
            Shift = 65536
        }

        public enum Controles
        {
            Todos,
            TextBox,
            ComboBox,
            DateTimePicker,
            CheckBox,
            Button,
            RadioButton
        }

        public enum Gifs
        {
            BarraAzul = 1,
            BarraVerde = 2,
            Buscando = 3,
            Circular = 4,
            Engrane = 5,
            Engranes = 6
        }

        public enum Activo
        {
            Inactivo = 0,
            Activo = 1
        }

        public enum StatusCorreo
        {
            Pendiente = 1,
            Enviado = 2,
            Fallo = 3,
            Cancelado = 4
        }

        public enum PrioridadCorreo
        {
            Urgente = 1,
            Programado = 2,
            ProgramadoRecurrente = 3
        }

        public enum TipoCorreo
        {
            BecaSolicitada = 1,
            BecaAceptada = 2,
            BecaPendiente = 3,
            BecaRechazada = 4,
            BecaPagada = 5,
            BecaPendienteAceptada = 6,
            FormatoSolicitud = 7
        }

        // CATBECAS
        public enum OperacionesExcepciones
        {
            Alta = 1,
            Inactivacion = 2,
            Modificacion = 3
        }

        public enum EstatusExcepcion
        {
            Activa = 1,
            Inactiva = 2,
            Aplicada = 3
        }

        public enum EstatusSolicitud
        {
            Capturada = 1,
            Aceptada = 2,
            Pendiente = 3,
            Rechazada = 4,
            Pagada = 5,
            Revision = 6,
            ActualizacionDocs = 7
        }

        public enum EjecucionWebService
        {
            Correcto = 0,
            Incorrecto = 1
        }

        public enum TipoBeneficiario
        {
            Hermano = 1,
            Hijo = 2,
            Nieto = 3,
            Socio = 4,
            Sobrino = 5
        }

        public enum EstatusEntrada
        {
            Captura = 1,
            Afectado = 2
        }

        public enum EstatusSalida
        {
            Captura = 1,
            Asignada = 2
        }
    }
}
