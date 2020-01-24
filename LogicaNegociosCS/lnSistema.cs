using AccesoDatosCS;
using EntidadNegociosCS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegociosCS
{
    public class LnSistema
    {
        // Variables privadas
        private readonly adSistema _objAdSistema;

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <param name="objEnDatosConn"></param>
        ///     ''' <remarks></remarks>
        public LnSistema(enDatosConn objEnDatosConn)
        {
            
            _objAdSistema = new adSistema(objEnDatosConn);
        }

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <param name="Usuario"></param>
        ///     ''' <param name="psw"></param>
        ///     ''' <param name="usuarioAplica"></param>
        ///     ''' <remarks></remarks>
        public LnSistema(string Usuario, string psw, int usuarioAplica)
        {
            _objAdSistema = new adSistema(Usuario, psw, usuarioAplica);
        }

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <param name="user"></param>
        ///     ''' <param name="password"></param>
        ///     ''' <remarks></remarks>
        public LnSistema(string user, string password)
        {
            _objAdSistema = new adSistema(user, password);
        }

        public DataTable ValidaLogin(string usuario, string password)
        {
            try
            {
                return _objAdSistema.ValidaLogin(usuario, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ABCPerfil(char op, Sis.PERFILES Perfil)
        {
            return (_objAdSistema.ABCPerfiles(op, Perfil));
        }

        public int ABCPermisosPerfil(char op, Sis.PERMISOS_PERFIL PermisoPerfil)
        {
            return _objAdSistema.ABCPermisosPerfil(op, PermisoPerfil);
        }

        public DataTable ConsultaPermisosPMM(int idUsuario, ref string Mensaje, int idModulo= 0, int idMenu=0)
        {
            return _objAdSistema.getPermisosPMM(idUsuario, ref Mensaje, idModulo, idMenu);
        }

        public int ABCUsuarios(char op, Sis.USUARIOS Usuario)
        {
            return _objAdSistema.ABCUsuarios(op, Usuario);
        }

        public int BloqueoUsuario(Sis.USUARIOS Usuario)
        {
            return _objAdSistema.BloqueoUsuario(Usuario);
        }

        public int ValidaHistorialPsw(int idUsuario, string password)
        {
            try
            {
                return _objAdSistema.ValidaHistorialPsw(idUsuario, password);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ABClogSesiones(char op, Sis.LOG_SESIONES logSesiones)
        {
            try
            {
                return _objAdSistema.ABCLogSesiones(op, logSesiones);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Ent.PARAMETROS_GRALES ConsultaDatosAdmorseg()
        {
            try
            {
                return _objAdSistema.ConsultaDatosAdmorSeg();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Ent.PARAMETROS_AD ConsultaParametrosAD()
        {
            try
            {
                return _objAdSistema.ConsultaParametrosAD();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Sis.USUARIOS ConsultaUsuarioLogin(string NombreUsuario)
        {
            try
            {
                return _objAdSistema.ConsultaUsuarioLogin(NombreUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     ''' Funcion de logica de negocios para la eliminacion de la configuracion del semaforo
        ///     ''' </summary>
        ///     ''' <remarks></remarks>
        public void EliminarConfSemaforo(int IdTipoSemaforo)
        {
            try
            {
                _objAdSistema.EliminarConfSemaforo(IdTipoSemaforo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///     ''' Funcion de logica de negocios para la guardar datos de la configuracion del semaforo
        ///     ''' </summary>
        ///     ''' <remarks></remarks>
        public void ABCSEMAFORO(char op, Sis.SEMAFORO semaforo)
        {
            try
            {
                _objAdSistema.ABCSemaforo(op, semaforo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ConsultarInfoGeneral(string usuario, string correo)
        {
            try
            {
                return _objAdSistema.ConsultarInfoGeneral(usuario, correo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///     ''' Funcion para consultar la información de un empleado dado su correo electronico
        ///     ''' </summary>
        ///     ''' <param name="correo"></param>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public DataTable ConsultarEmpleado(string correo)
        {
            try
            {
                return _objAdSistema.ConsultarEmpleado(correo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
