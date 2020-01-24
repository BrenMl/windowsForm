using EntidadNegociosCS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatosCS
{
    public class adProductos
    {
        private Persistencia _objPersistencia;

        public adProductos(enDatosConn objEnDatosConn)
        {
            _objPersistencia = new Persistencia(objEnDatosConn);
        }

        public void ABCPRODUCTOS (char Op, Pro.PRODUCTOS PRODUCTOS)
        {
            const string querySql = "Pro.prPRODUCTOS";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdProducto", PRODUCTOS.IdProducto);
                        sqlCmnd.Parameters.AddWithValue("@IdFamilia", PRODUCTOS.IdFamilia);
                        sqlCmnd.Parameters.AddWithValue("@IdConfeccion", PRODUCTOS.IdConfeccion);
                        sqlCmnd.Parameters.AddWithValue("@Producto", PRODUCTOS.Producto);
                        sqlCmnd.Parameters.AddWithValue("@Codigo", PRODUCTOS.Codigo);
                        sqlCmnd.Parameters.AddWithValue("@Activo", PRODUCTOS.Activo);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn >= 1)
                                throw new Exception(reader["MensajeError"].ToString());
                            if (IntReturn == 1)
                                throw new Exception($"{reader["MensajeError"]}\n\nSP: {querySql}");

                            // Asignar el Id del Producto
                            PRODUCTOS.IdProducto = (int)reader["Ident"];

                            reader.Close();
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ABCALIAS(char Op, Pro.ALIAS ALIAS)
        {
            const string querySql = "Pro.prALIAS";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdAlias", ALIAS.IdAlias);
                        sqlCmnd.Parameters.AddWithValue("@IdProducto", ALIAS.IdProducto);
                        sqlCmnd.Parameters.AddWithValue("@Alias", ALIAS.Alias);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn >= 1)
                                throw new Exception(reader["MensajeError"].ToString());
                            if (IntReturn == 1)
                                throw new Exception($"{reader["MensajeError"]}\n\nSP: {querySql}");

                            reader.Close();
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
