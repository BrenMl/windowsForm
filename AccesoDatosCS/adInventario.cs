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
   public class adInventario
    {
        private Persistencia _objPersistencia;

        public adInventario(enDatosConn objEnDatosConn)
        {
            _objPersistencia = new Persistencia(objEnDatosConn);
        }

        public void ABCINVENTARIO(char Op, Inv.INVENTARIO INVENTARIO)
        {
            const string querySql = "Inv.prINVENTARIO";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdInventario", INVENTARIO.IdInventario);
                        sqlCmnd.Parameters.AddWithValue("@IdProducto", INVENTARIO.IdProducto);
                        sqlCmnd.Parameters.AddWithValue("@Existencia", INVENTARIO.Existencia);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn > 0)
                                throw new Exception(reader["MensajeError"].ToString());
                            INVENTARIO.IdInventario = (int)reader["Ident"];
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


        public void AfectarInventarioEntrada(int IdEntrada)
        {
            const string querySql = "Inv.AfectarInventarioEntradas";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@IdEntrada", IdEntrada);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn > 0)
                                throw new Exception(reader["MensajeError"].ToString());
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
