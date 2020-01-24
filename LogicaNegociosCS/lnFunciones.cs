using AccesoDatosCS;
using EntidadNegociosCS;
using System.Data;

namespace LogicaNegociosCS
{
    public class LnFunciones
    {
        protected Persistencia db;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="objEnDatosConn"></param>
        /// <remarks></remarks>
        public LnFunciones(enDatosConn objEnDatosConn)
        {
            db = new Persistencia(objEnDatosConn);
        }

        /// <summary>
        /// Regresa un objeto "DataTable" con los datos obtenidos según la ejecución de una sentencia SQL
        /// </summary>
        /// <param name="query">Sentencia SQL</param>
        /// <returns>Objeto DataTable con los datos obtenidos desde la base de datos</returns>
        /// <remarks></remarks>
        public DataTable GetInfoQueryDt(string query)
        {
            // Try
            return db.GetDataTable(query);
        }
    }
}
