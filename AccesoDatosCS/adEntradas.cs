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

    public  class adEntradas
    {
        private Persistencia _objPersistencia;

        public adEntradas(enDatosConn objEnDatosConn)
        {
            _objPersistencia = new Persistencia(objEnDatosConn);
        }
        public void ABCENTRADAS(char Op, Entr.ENTRADAS ENTRADAS)
        {
            const string querySql = "Entr.prENTRADAS";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdEntrada", ENTRADAS.IdEntrada);
                        sqlCmnd.Parameters.AddWithValue("@IdProveedor", ENTRADAS.IdProveedor);
                        sqlCmnd.Parameters.AddWithValue("@IdEstatusEntrada", ENTRADAS.IdEstatusEntrada);
                        sqlCmnd.Parameters.AddWithValue("@FechaEntrada", ENTRADAS.FechaEntrada);
                        sqlCmnd.Parameters.AddWithValue("@FechaEntrega", ENTRADAS.FechaEntrega);
                        sqlCmnd.Parameters.AddWithValue("@FolioFactura", ENTRADAS.FolioFactura);

                        //sqlCmnd.Parameters.AddWithValue("@Activo", CLIENTES.Activo);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn == 1)
                                throw new Exception(reader["MensajeError"].ToString());
                            ENTRADAS.IdEntrada = (int)reader["Ident"];
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
        public void ABCDETALLES_ENTRADA(char Op, Entr.DETALLES_ENTRADA DETALLES_ENTRADA)
        {
            const string querySql = "Entr.prDETALLES_ENTRADA";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdDetalleEntrada", DETALLES_ENTRADA.IdDetalleEntrada);
                        sqlCmnd.Parameters.AddWithValue("@IdEntrada", DETALLES_ENTRADA.IdEntrada);
                        sqlCmnd.Parameters.AddWithValue("@IdProducto", DETALLES_ENTRADA.IdProducto);
                        sqlCmnd.Parameters.AddWithValue("@Costo", DETALLES_ENTRADA.Costo);
                        sqlCmnd.Parameters.AddWithValue("@Cantidad", DETALLES_ENTRADA.Cantidad);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn == 1)
                                throw new Exception(reader["MensajeError"].ToString());
                            DETALLES_ENTRADA.IdDetalleEntrada = (int)reader["Ident"];
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
