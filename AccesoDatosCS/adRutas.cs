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
    public class adRutas
    {
        private Persistencia _objPersistencia;

        public adRutas(enDatosConn objEnDatosConn)
        {
            _objPersistencia = new Persistencia(objEnDatosConn);
        }

        public void ABCRUTAS(char Op, Rut.RUTAS RUTAS)
        {
            const string querySql = "Rut.prRUTAS";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdRuta", RUTAS.IdRuta);
                        sqlCmnd.Parameters.AddWithValue("@Ruta", RUTAS.Ruta);
                        sqlCmnd.Parameters.AddWithValue("@Activo", RUTAS.Activo);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn == 1)
                                throw new Exception(reader["MensajeError"].ToString());
                            RUTAS.IdRuta = (int)reader["Ident"];
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

        public void ABCDETALLES_RUTA(char Op, Rut.DETALLES_RUTA DETALLES_RUTA)
        {
            const string querySql = "Rut.prDETALLES_RUTA";
            int IntReturn = 1;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdDetalleRuta", DETALLES_RUTA.IdDetalleRuta);
                        sqlCmnd.Parameters.AddWithValue("@IdRuta", DETALLES_RUTA.IdRuta);
                        sqlCmnd.Parameters.AddWithValue("@IdDomicilio", DETALLES_RUTA.IdDomicilio);
                        sqlCmnd.Parameters.AddWithValue("@IdDia", DETALLES_RUTA.IdDia);
                        sqlCmnd.Parameters.AddWithValue("@Secuencia", DETALLES_RUTA.Secuencia);
                        sqlCmnd.Parameters.AddWithValue("@Nota", DETALLES_RUTA.Nota);
                        sqlCmnd.Parameters.AddWithValue("@Activo", DETALLES_RUTA.Activo);

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
                if (IntReturn == 2)
                {
                    throw new Exception($"{ex.Message}");
                }
                else
                {
                    throw new Exception($"{ex.Message} \n\nSP:  {querySql}");
                }
            }
        }

        public void ABCDIAS(char Op, Rut.DIAS DIAS)
        {
            const string querySql = "Rut.prDIAS";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdDia", DIAS.IdDia);
                        sqlCmnd.Parameters.AddWithValue("@Dia", DIAS.Dia);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn == 1)
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
