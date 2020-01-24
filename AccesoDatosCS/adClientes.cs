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
    public class adClientes
    {

        private Persistencia _objPersistencia;

        public adClientes(enDatosConn objEnDatosConn)
        {
            _objPersistencia = new Persistencia(objEnDatosConn);
        }


        public void ABCCLIENTES(char Op, Cte.CLIENTES CLIENTES)
        {
            const string querySql = "Cte.prCLIENTES";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdCliente", CLIENTES.IdCliente);
                        sqlCmnd.Parameters.AddWithValue("@IdGiro", CLIENTES.IdGiro);
                        sqlCmnd.Parameters.AddWithValue("@Cliente", CLIENTES.Cliente);
                        sqlCmnd.Parameters.AddWithValue("@DiasCredito", CLIENTES.DiasCredito);
                        sqlCmnd.Parameters.AddWithValue("@Activo", CLIENTES.Activo);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn == 1)
                                throw new Exception(reader["MensajeError"].ToString());
                            CLIENTES.IdCliente = (int)reader["Ident"];
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
        public void ABCDOMICILIO(char Op, Cte.DOMICILIOS DOMICILIOS)
        {
            const string querySql = "Cte.prDOMICILIOS";
            int IntReturn = 1;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdDomicilio", DOMICILIOS.IdDomicilio);
                        sqlCmnd.Parameters.AddWithValue("@IdCliente", DOMICILIOS.IdCliente);
                        sqlCmnd.Parameters.AddWithValue("@IdTipoDomicilio", DOMICILIOS.IdTipoDomicilio);
                        sqlCmnd.Parameters.AddWithValue("@IdColonia", DOMICILIOS.IdColonia);
                        sqlCmnd.Parameters.AddWithValue("@Calle", DOMICILIOS.Calle);
                        sqlCmnd.Parameters.AddWithValue("@NumExt", DOMICILIOS.NumExt);
                        sqlCmnd.Parameters.AddWithValue("@NumInt", DOMICILIOS.NumInt);
                        sqlCmnd.Parameters.AddWithValue("@Latitud", DOMICILIOS.Latitud);
                        sqlCmnd.Parameters.AddWithValue("@Longitud", DOMICILIOS.Longitud);
                        sqlCmnd.Parameters.AddWithValue("@Referencia", DOMICILIOS.Referencia);
                        sqlCmnd.Parameters.AddWithValue("@CorreoElectronico", DOMICILIOS.CorreoElectronico);
                        sqlCmnd.Parameters.AddWithValue("@Activo", DOMICILIOS.Activo);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn > 0)
                                throw new Exception(reader["MensajeError"].ToString());
                            DOMICILIOS.IdDomicilio = (int)reader["Ident"];
                            reader.Close();
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if(IntReturn == 2)
                {
                    throw new Exception($"{ex.Message}");
                }
                else
                {
                    throw new Exception($"{ex.Message} \n\nSP:  {querySql}");
                }
               
            }
        }
        public void ABCTELEFONO(char Op, Cte.TELEFONOS TELEFONO)
        {
            const string querySql = "Cte.prTELEFONOS";
            int IntReturn = 1;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdTelefono", TELEFONO.IdTelefono);
                        sqlCmnd.Parameters.AddWithValue("@IdTipoTelefono", TELEFONO.IdTipoTelefono);
                        sqlCmnd.Parameters.AddWithValue("@IdDomicilio", TELEFONO.IdDomicilio);
                        sqlCmnd.Parameters.AddWithValue("@Telefono", TELEFONO.Telefono);
                        sqlCmnd.Parameters.AddWithValue("@Activo", TELEFONO.Activo);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn > 0)
                                throw new Exception(reader["MensajeError"].ToString());
                            TELEFONO.IdTelefono = (int)reader["Ident"];
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

    }
}
