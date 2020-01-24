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
    public class adSalidas
    {
        private Persistencia _objPersistencia;
 
        public adSalidas(enDatosConn objEnDatosConn)
        {
            _objPersistencia = new Persistencia(objEnDatosConn);
        }

        public void ABCSALIDAS (char Op, Sal.SALIDAS SALIDA)
        {
            const string querySql = "Sal.prSALIDAS";            
            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdSalida", SALIDA.IdSalida);
                        sqlCmnd.Parameters.AddWithValue("@IdEmpleado", SALIDA.IdEmpleado);
                        sqlCmnd.Parameters.AddWithValue("@IdEstatusSalida", SALIDA.IdEstatusSalida);
                        sqlCmnd.Parameters.AddWithValue("@FechaSalida", SALIDA.FechaSalida);                                                                    
                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            if ((int)reader["Result"] == 1)
                                throw new Exception(reader["MensajeError"].ToString());

                            SALIDA.IdSalida = (int)reader["Ident"];
                            reader.Close();
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message} \n\nSP:  {querySql}");
            }
        }

        public void ABCDETALLE_SALIDA(char Op, Sal.DETALLES_SALIDA DETALLES_SALIDA)
        {
            const string querySql = "Sal.prDETALLES_SALIDA";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdDetalleSalida",  DETALLES_SALIDA.IdDetalleSalida);
                        sqlCmnd.Parameters.AddWithValue("@IdSalida", DETALLES_SALIDA.IdSalida);
                        sqlCmnd.Parameters.AddWithValue("@IdProducto", DETALLES_SALIDA.IdProducto);
                        sqlCmnd.Parameters.AddWithValue("@Cantidad", DETALLES_SALIDA.Cantidad);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn == 1)
                                throw new Exception(reader["MensajeError"].ToString());
                            DETALLES_SALIDA.IdDetalleSalida = (int)reader["Ident"];
                            reader.Close();
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message} \n\nSP:  {querySql}");
            }
        }
    }
}
