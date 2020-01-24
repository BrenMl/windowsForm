using EntidadNegociosCS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatosCS
{
    public class adCatalogos
    {
        private Persistencia _objPersistencia;

        public adCatalogos(enDatosConn objEnDatosConn)
        {
            _objPersistencia = new Persistencia(objEnDatosConn);
        }

        public void ABCDIAS_FESTIVOS(char Op, Cat.DIAS_FESTIVOS DIAS_FESTIVOS) {
            const string querySql = "Cat.prDIAS_FESTIVOS";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdDiasFestivos", DIAS_FESTIVOS.IdDiasFestivos);
                        sqlCmnd.Parameters.AddWithValue("@DiaFestivo", DIAS_FESTIVOS.DiaFestivo);
                        sqlCmnd.Parameters.AddWithValue("@Fecha", DIAS_FESTIVOS.Fecha);
                        sqlCmnd.Parameters.AddWithValue("@Notas", DIAS_FESTIVOS.Notas);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn == 1)
                                throw new Exception(reader["MensajeError"].ToString());
                            DIAS_FESTIVOS.IdDiasFestivos = (int)reader["Ident"];
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
