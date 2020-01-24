using EntidadNegociosCS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosCS
{
    public class adSistema
    {
        private Persistencia _objPersistencia;
        private readonly int idUsuarioAplica;

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <param name="objEnDatosConn"></param>
        ///     ''' <remarks></remarks>
        public adSistema(enDatosConn objEnDatosConn)
        {
            // Se declara un objeto PERSISTENCIA, para poder hacer uso de comandos SQL
            _objPersistencia = new Persistencia(objEnDatosConn);
        }

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <param name="Usuario"></param>
        ///     ''' <param name="psw"></param>
        ///     ''' <param name="usuarioAplica"></param>
        ///     ''' <remarks></remarks>
        public adSistema(string Usuario, string psw, int usuarioAplica)
        {
            _objPersistencia = new Persistencia(Usuario, psw);
            idUsuarioAplica = usuarioAplica;
        }

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <param name="Usuario"></param>
        ///     ''' <param name="psw"></param>
        ///     ''' <remarks></remarks>
        public adSistema(string Usuario, string psw)
        {
            _objPersistencia = new Persistencia(Usuario, psw);
        }

        /// <summary>
        ///     ''' Verifica si los datos de inicio de un usuario son validos
        ///     ''' </summary>
        ///     ''' <param name="usuario">Usuario</param>
        ///     ''' <param name="password">Contraseña</param>
        ///     ''' <returns>Objeto "Datatable" con los datos generales de sesion</returns>
        ///     ''' <remarks></remarks>
        public DataTable ValidaLogin(string usuario, string password)
        {
            try
            {
                return _objPersistencia.GetDataTable(string.Format("Sis.prValidaLogin '{0}','{1}'", usuario, password));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ABCPerfiles(char op, Sis.PERFILES perfil)
        {
            const string querySql = "Sis.prPERFILES";
            int IntReturn;
            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        // Asignar los parametros del SP                
                        sqlCmnd.Parameters.Add("@Op", SqlDbType.Char);
                        sqlCmnd.Parameters["@Op"].Value = op;

                        sqlCmnd.Parameters.Add("@IdPerfil", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdPerfil"].Value = perfil.IdPerfil;

                        sqlCmnd.Parameters.Add("@perfil", SqlDbType.VarChar);
                        sqlCmnd.Parameters["@perfil"].Value = perfil.Perfil;

                        sqlCmnd.Parameters.Add("@habilitado", SqlDbType.Bit);
                        //sqlCmnd.Parameters["@habilitado"].Value = IIf(IsNothing(perfil.Habilitado), DBNull.Value, IIf(perfil.Habilitado == 1, "True", "False"));

                        switch (perfil.Habilitado)
                        {
                            case null:
                                sqlCmnd.Parameters["@habilitado"].Value = DBNull.Value;
                                break;
                            case "1":
                                sqlCmnd.Parameters["@habilitado"].Value = true;
                                break;
                            default:
                                sqlCmnd.Parameters["@habilitado"].Value = false;
                                break;
                        }






                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Asignar los valores obtenidos de la ejecución del comando
                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int) reader["Result"];

                            // Revisar si el SP generó un resultado de error
                            if (IntReturn == 1)
                                throw new Exception((string) reader["MensajeError"]);

                            // Cerrar el Reader
                            reader.Close();
                        }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return IntReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public int ABCPermisosPerfil(char op, Sis.PERMISOS_PERFIL permisoPerfil)
        {
            const string querySql = "Sis.prPERMISOS_PERFIL";
            int IntReturn;
            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        // Asignar los parametros del SP                
                        sqlCmnd.Parameters.Add("@Op", SqlDbType.Char);
                        sqlCmnd.Parameters["@Op"].Value = op;

                        sqlCmnd.Parameters.Add("@IdPerfil", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdPerfil"].Value = permisoPerfil.IdPerfil;

                        sqlCmnd.Parameters.Add("@idAccion", SqlDbType.Int);
                        sqlCmnd.Parameters["@idAccion"].Value = permisoPerfil.IdAccion;

                        sqlCmnd.Parameters.Add("@habilitado", SqlDbType.Bit);
                        //sqlCmnd.Parameters["@habilitado"].Value = IIf(IsNothing(permisoPerfil.Habilitado), DBNull.Value, IIf(permisoPerfil.Habilitado == 1, "True", "False"));

                        switch (permisoPerfil.Habilitado)
                        {
                            case null:
                                sqlCmnd.Parameters["@habilitado"].Value = DBNull.Value;
                                break;
                            case "1":
                                sqlCmnd.Parameters["@habilitado"].Value = true;
                                break;
                            default:
                                sqlCmnd.Parameters["@habilitado"].Value = false;
                                break;
                        }

                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Asignar los valores obtenidos de la ejecución del comando
                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int) reader["Result"];

                            // Revisar si el SP generó un resultado de error
                            if (IntReturn == 1)
                                throw new Exception((string) reader["MensajeError"]);

                            // Cerrar el Reader
                            reader.Close();
                        }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return IntReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public DataTable getPermisosPMM(int IdUsuario, ref string mensaje, int idModulo = 0, int idMenu = 0 )
        {
            const string querySql = "Sis.prConsultaPermisosPerfil";
            DataTable dt = new DataTable();
            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        // Asignar los parametros del SP                
                        sqlCmnd.Parameters.Add("@IdUsuario", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdUsuario"].Value = IdUsuario == 0 ? DBNull.Value : (object) IdUsuario;

                        sqlCmnd.Parameters.Add("@IdModulo", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdModulo"].Value = idModulo == 0 ? DBNull.Value :(object) idModulo;

                        sqlCmnd.Parameters.Add("@IdMenu", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdMenu"].Value = idMenu == 0 ? DBNull.Value : (object) idMenu;

                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            dt.Load(reader);

                            // Cerrar el Reader
                            reader.Close();
                        }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public int ABCUsuarios(char op, Sis.USUARIOS usuario)
        {
            const string querySql = "Sis.prUsuarios";
            int IntReturn;
            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        // Asignar los parametros del SP      
                        {
                            
                            sqlCmnd.Parameters.AddWithValue("@Op", op);
                            sqlCmnd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario == 0 ? DBNull.Value : (object) usuario.IdUsuario);
                            sqlCmnd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                            sqlCmnd.Parameters.AddWithValue("@ApPaterno", usuario.ApPaterno);
                            sqlCmnd.Parameters.AddWithValue("@ApMaterno", usuario.ApMaterno);
                            sqlCmnd.Parameters.AddWithValue("@IdPerfil", usuario.IdPerfil == 0 ? DBNull.Value : (object) usuario.IdPerfil);
                            sqlCmnd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario == null ? DBNull.Value : (object) usuario.NombreUsuario);
                            sqlCmnd.Parameters.AddWithValue("@password", usuario.Password == null ? DBNull.Value :(object) usuario.Password);
                            //sqlCmnd.Parameters.AddWithValue("@CambioContrasena", IIf(IsNothing(usuario.CambioContrasena), DBNull.Value, IIf(usuario.CambioContrasena == 1, "True", "False")));
                           //sqlCmnd.Parameters.AddWithValue()

                            switch (usuario.CambioContrasena)
                            {
                                case null:
                                    sqlCmnd.Parameters.AddWithValue("@CambioContrasena", DBNull.Value);
                                    break;
                                case "1":
                                    sqlCmnd.Parameters.AddWithValue("@CambioContrasena", true);
                                    break;
                                default:
                                    sqlCmnd.Parameters.AddWithValue("@CambioContrasena", false);
                                    break;
                            }


                            sqlCmnd.Parameters.AddWithValue("@FechaCambioContrasena", usuario.FechaCambioContrasena == DateTime.MinValue ? DBNull.Value : (object) usuario.FechaCambioContrasena);
                            //sqlCmnd.Parameters.AddWithValue("@Habilitado", IIf(IsNothing(usuario.Habilitado), DBNull.Value, IIf(usuario.Habilitado == 1, "True", "False")));
                            switch (usuario.Habilitado)
                            {
                                case null:
                                    sqlCmnd.Parameters.AddWithValue("@habilitado",DBNull.Value);
                                    break;
                                case "1":
                                    sqlCmnd.Parameters.AddWithValue("@habilitado", true);
                                    break;
                                default:
                                    sqlCmnd.Parameters.AddWithValue("@habilitado", false);
                                    break;
                            }


                            sqlCmnd.Parameters.AddWithValue("@IdUsuarioAplica", idUsuarioAplica);
                        }

                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Asignar los valores obtenidos de la ejecución del comando
                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int) reader["Result"];

                            // Revisar si el SP generó un resultado de error
                            if (IntReturn == 1)
                                throw new Exception((string) reader["MensajeError"]);

                            // Cerrar el Reader
                            reader.Close();
                        }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return IntReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public int BloqueoUsuario(Sis.USUARIOS usuario)
        {
            const string querySql = "Sis.prBloqueoUsuarios";
            int IntReturn;

            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        // Asignar los parametros del SP                
                        sqlCmnd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar);
                        sqlCmnd.Parameters["@NombreUsuario"].Value = usuario.NombreUsuario == null ? DBNull.Value : (object)usuario.NombreUsuario;

                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                            {
                                if (!reader.Read())
                                    throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                                // Asignar los valores obtenidos de la ejecución del comando
                                // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                                IntReturn = (int)reader["Result"];

                                // Revisar si el SP generó un resultado de error
                                if (IntReturn == 1)
                                    throw new Exception((string)reader["MensajeError"]);

                                // Cerrar el Reader
                                reader.Close();
                            }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return IntReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public int ValidaHistorialPsw(int idUsuario, string password)
        {
            const string querySql = "Sis.prValidaHistorialPsw";
            int IntReturn;

            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        // Asignar los parametros del SP                
                        sqlCmnd.Parameters.Add("@idUsuario", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdUsuario"].Value = idUsuario;

                        sqlCmnd.Parameters.Add("@Password", SqlDbType.VarChar);
                        sqlCmnd.Parameters["@Password"].Value = password;

                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Asignar los valores obtenidos de la ejecución del comando
                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int) reader["Result"];

                            // Cerrar el Reader
                            reader.Close();
                        }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return IntReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public int ABCLogSesiones(char op, Sis.LOG_SESIONES logSesion)
        {
            const string querySql = "Sis.prLOG_SESIONES";
            int IntReturn;

            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        // Asignar los parametros del SP                
                        sqlCmnd.Parameters.Add("@Op", SqlDbType.Char);
                        sqlCmnd.Parameters["@Op"].Value = op;

                        sqlCmnd.Parameters.Add("@IdLogSesiones", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdLogSesiones"].Value = logSesion.IdLogSesiones;

                        sqlCmnd.Parameters.Add("@IdModulo", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdModulo"].Value = logSesion.IdModulo;

                        sqlCmnd.Parameters.Add("@IdAccionSesion", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdAccionSesion"].Value = logSesion.IdAccionSesion;

                        sqlCmnd.Parameters.Add("@IdUsuario", SqlDbType.Int);
                        sqlCmnd.Parameters["@IdUsuario"].Value = logSesion.IdUsuario;

                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Asignar los valores obtenidos de la ejecución del comando
                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int) reader["Result"];

                            // Revisar si el SP generó un resultado de error
                            if (IntReturn == 1)
                                throw new Exception((string) reader["MensajeError"]);

                            // Cerrar el Reader
                            reader.Close();
                        }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return IntReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public Ent.PARAMETROS_GRALES ConsultaDatosAdmorSeg()
        {
            const string querySql = "Dumb.prConsultaParamGrales";
            Ent.PARAMETROS_GRALES ParamGrales = new Ent.PARAMETROS_GRALES();

            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");
                            // Asignar valores obtenidos de la base de datos
                            ParamGrales.UsuarioAdmSeg = (string) reader["UsuarioAdmSeg"];
                            ParamGrales.PswAdmSeg = (string) reader["PswAdmSeg"];

                            // Cerrar el Reader
                            reader.Close();
                        }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return ParamGrales;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public Ent.PARAMETROS_AD ConsultaParametrosAD()
        {
            const string querySql = "Dumb.prConsultaParamAD";
            Ent.PARAMETROS_AD ParamAD = new Ent.PARAMETROS_AD();

            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");
                            // Asignar valores obtenidos de la base de datos
                            ParamAD.NombreServidor = (string) reader["NombreServidor"];
                            ParamAD.Puerto = (int) reader["Puerto"];
                            ParamAD.Dominio = (string) reader["Dominio"];
                            ParamAD.Sufijo = (string) reader["Sufijo"];
                            ParamAD.UsuarioRod = (string) reader["UsuarioRod"];
                            ParamAD.Contraseña = (string) reader["Contraseña"];
                            ParamAD.DN = (string) reader["DN"];

                            // Cerrar el Reader
                            reader.Close();
                        }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return ParamAD;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public Sis.USUARIOS ConsultaUsuarioLogin(string NombreUsuario)
        {
            const string querySql = "Dumb.prUsuarioLogin";
            Sis.USUARIOS Usuario = new Sis.USUARIOS();

            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    // Abrir la conexion
                    connection.Open();

                    // Definir un "SqlCommand" con funcionalidad de "Stored Procedure"
                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Usuario", NombreUsuario);
                        // Ejecutar el comando
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception(string.Format("El usuario '{0}' no existe, favor de revisar", NombreUsuario));
                            // Asignar valores obtenidos de la base de datos
                            Usuario.IdUsuario = (int) reader["IdUsuario"];
                            Usuario.NombreUsuario = (string) reader["NombreUsuario"];
                            Usuario.UsuarioAD = (bool)reader["UsuarioAD"];

                            // Cerrar el Reader
                            reader.Close();
                        }

                        // Cerrar la conexion
                        connection.Close();
                    }
                }

                return Usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        /// <summary>
        ///     ''' Funcion de borrado de la configuracion del semaforo para requisiciónes
        ///     ''' </summary>
        ///     ''' <remarks></remarks>
        public void EliminarConfSemaforo(int IdTipoSemaforo)
        {
            const string querySql = "Sis.prEliminarConfSemaforo";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@IdTipoSemaforo", IdTipoSemaforo);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int) reader["Result"];

                            if (IntReturn == 1)
                                throw new Exception((string) reader["MensajeError"]);

                            reader.Close();
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        /// <summary>
        ///     ''' Funcion de guardado de la configuracion del semaforo para requisiciónes
        ///     ''' </summary>
        ///     ''' <param name="op">Operacion a realizar</param>
        ///     ''' <param name="Semaforo">Detalle de la banda, intervalo y color</param>
        ///     ''' <remarks></remarks>
        public void ABCSemaforo(char op, Sis.SEMAFORO Semaforo)
        {
            const string querySql = "Sis.prSemaforo";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", op);
                        sqlCmnd.Parameters.AddWithValue("@IdSemaforo", Semaforo.IdSemaforo);
                        sqlCmnd.Parameters.AddWithValue("@IdTipoSemaforo", Semaforo.IdTipoSemaforo);
                        sqlCmnd.Parameters.AddWithValue("@Inicio", Semaforo.Inicio);
                        sqlCmnd.Parameters.AddWithValue("@Fin", Semaforo.Fin);
                        sqlCmnd.Parameters.AddWithValue("@Color", Semaforo.Color);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int) reader["Result"];

                            if (IntReturn == 1)
                                throw new Exception((string) reader["MensajeError"]);

                            reader.Close();
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n" + "SP: " + querySql);
            }
        }

        public DataTable ConsultarInfoGeneral(string usuario, string correo)
        {
            try
            {
                return _objPersistencia.GetDataTable(string.Format("Sis.prObtenerInfoGeneral '{0}','{1}'", usuario, correo));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///     ''' Consultar la información de un empleado, dado su 
        ///     ''' </summary>
        ///     ''' <param name="correo"></param>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public DataTable ConsultarEmpleado(string correo)
        {
            try
            {
                return _objPersistencia.GetDataTable(string.Format("Emp.WebprConsultarEmpleado '{0}'", correo));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
