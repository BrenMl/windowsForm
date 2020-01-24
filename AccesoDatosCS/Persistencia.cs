using EntidadNegociosCS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosCS
{
    public class Persistencia
    {
        protected string StrConnection;
        protected SqlConnection SqlConnection;

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <param name="user">Usuario de conexión a la base de datos</param>
        ///     ''' <param name="password">Contraseña asociada al usuario</param>
        ///     ''' <remarks></remarks>
        public Persistencia(string user, string password)
        {
            string serverBd, nameBd;

            // Obtener datos desde el AppConfig
            serverBd = ConfigurationManager.AppSettings["ServerBD"];
            nameBd = ConfigurationManager.AppSettings["NameBD"];

            // Armar cadena de conexión
            StrConnection = "Server=" + serverBd + ";Database=" + nameBd + ";user Id=" + user + ";Password=" + password + ";Connect Timeout=15;";
        }

        /// <summary>
        ///     ''' Constructor
        ///     ''' </summary>
        ///     ''' <param name="objEnDatosConn">Objeto entidad de los datos de conexión</param>
        ///     ''' <remarks></remarks>
        public Persistencia(enDatosConn objEnDatosConn)
        {
            {
                var withBlock = objEnDatosConn;
                StrConnection = "Server=" + withBlock.ServerBD + ";Database=" + withBlock.NameBD + ";user Id=" + withBlock.Usuario + ";Password=" + withBlock.Password + ";Connect Timeout=180;";
            }
        }

        /// <summary>
        ///     ''' Obtiene la cadena de conexion a un motor de base de datos
        ///     ''' </summary>
        ///     ''' <returns>Cadena de conexion</returns>
        ///     ''' <remarks></remarks>
        public string GetstrCon()
        {
            return StrConnection;
        }

        /// <summary>
        ///     ''' Obtiene un objeto "DataTable" con los datos obtenidos según la ejecución de una sentencia SQL
        ///     ''' </summary>
        ///     ''' <param name="query">Sentencia SQL</param>
        ///     ''' <returns>Objeto DataTable con los datos obtenidos desde la base de datos</returns>
        ///     ''' <remarks></remarks>
        public DataTable GetDataTable(string query)
        {
            // Declarar el objeto de retorno, su valor inical es "Nothing"
            DataTable dtSalida = new DataTable();

            try
            {
                // Definir la conexion a la base de datos mediante un "SqlConnection" 
                using (SqlConnection sqlCon = GetSqlConnection())
                {
                    // Abrir la conexion
                    sqlCon.Open();

                    // Definir un "SqlDataAdapter" para llenar el DataTable
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlCon))
                    {
                        // Llenar el "DataTable"
                        sqlDataAdapter.SelectCommand.CommandTimeout = 180;
                        sqlDataAdapter.Fill(dtSalida);
                    }
                    // Cerrar la conexion
                    sqlCon.Close();
                }

                return dtSalida;
            }
            catch (Exception ex)
            {
                throw new Exception(query.Substring(0, 17) == "Sis.prValidaLogin" ? ex.Message : ex.Message + "\n\n" + "Sentencia query: " + query);
            }
        }

        /// <summary>
        ///     ''' Obtiene una un objeto de conexión a la base de datos, de acuerdo con la cadena de conexion definida en la capa de persistencia
        ///     ''' </summary>
        ///     ''' <returns>conexión abierta a la base de datos</returns>
        ///     ''' <remarks></remarks>
        public SqlConnection GetSqlConnection(int timeOut = 10)
        {
            return new SqlConnection(GetstrCon());
        }

        /// <summary>
        ///     ''' Obtiene un objeto para ejecutar instrucciones en la base de datos
        ///     ''' </summary>
        ///     ''' <param name="connection">Objeto de conexion establecida a la base de datos</param>
        ///     ''' <param name="cmndText">Comando a ejecutar en la base de datos</param>
        ///     ''' <param name="cmndType">Tipo de comando a ejecutar en la base de datos</param>
        ///     ''' <returns>Objeto para realizar la ejecucion en la base de datos</returns>
        ///     ''' <remarks></remarks>
        public SqlCommand GetSqlCommand(SqlConnection connection, string cmndText, CommandType cmndType)
        {
            SqlCommand cmnd = new SqlCommand(cmndText, connection);
            cmnd.CommandType = cmndType;
            cmnd.CommandTimeout = 180;

            return cmnd;
        }
    }
}
