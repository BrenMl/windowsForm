using EntidadNegociosCS;
using enUtilerias;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosCS
{
    public class adEmpleados
    {
        private Persistencia _objPersistencia;

        public adEmpleados(enDatosConn objEnDatosConn)
        {
            _objPersistencia = new Persistencia(objEnDatosConn);
        }

        public void ABCEMPLEADOS(char Op, Emp.EMPLEADOS EMPLEADOS)
        {
            const string querySql = "Emp.prEMPLEADOS";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdEmpleado", EMPLEADOS.IdEmpleado);
                        sqlCmnd.Parameters.AddWithValue("@IdPersona", EMPLEADOS.IdPersona);
                        sqlCmnd.Parameters.AddWithValue("@Comision", EMPLEADOS.Comision);
                        sqlCmnd.Parameters.AddWithValue("@Foto", EMPLEADOS.Foto);
                        sqlCmnd.Parameters.AddWithValue("@FechaIngreso", EMPLEADOS.FechaIngreso);
                        sqlCmnd.Parameters.AddWithValue("@INE", EMPLEADOS.INE);
                        sqlCmnd.Parameters.AddWithValue("@Activo", EMPLEADOS.Activo);

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

        public void ABCFAMILIARES(char Op, Emp.FAMILIARES FAMILIARES)
        {
            const string querySql = "Emp.prFAMILIARES";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdFamiliar", FAMILIARES.IdFamiliar);
                        sqlCmnd.Parameters.AddWithValue("@IdPersona", FAMILIARES.IdPersona);
                        sqlCmnd.Parameters.AddWithValue("@IdEmpleado", FAMILIARES.IdEmpleado);

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

        public void ABCEMPLEADOS(char Op, Empleado EMPLEADO)
        {
            const string querySql = "Emp.prEMPLEADOS";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        // Datos Persona                                          
                        sqlCmnd.Parameters.AddWithValue("@IdColonia", EMPLEADO.Persona.IdColonia);
                        sqlCmnd.Parameters.AddWithValue("@Nombre", EMPLEADO.Persona.Nombre);
                        sqlCmnd.Parameters.AddWithValue("@ApPaterno", EMPLEADO.Persona.ApPaterno);
                        sqlCmnd.Parameters.AddWithValue("@ApMaterno", EMPLEADO.Persona.ApMaterno);
                        sqlCmnd.Parameters.AddWithValue("@Calle", EMPLEADO.Persona.Calle);
                        sqlCmnd.Parameters.AddWithValue("@NumExt", EMPLEADO.Persona.NumExt);
                        sqlCmnd.Parameters.AddWithValue("@NumInt", EMPLEADO.Persona.NumInt);
                        sqlCmnd.Parameters.AddWithValue("@Referencia", EMPLEADO.Persona.Referencia);
                        // Datos Empleado
                        sqlCmnd.Parameters.AddWithValue("@IdEmpleado", EMPLEADO.IdEmpleado);  
                         sqlCmnd.Parameters.AddWithValue("@Comision", EMPLEADO.Comision);

                        if (EMPLEADO.FechaIngreso == new DateTime(1, 1, 1))
                            sqlCmnd.Parameters.AddWithValue("@FechaIngreso", DBNull.Value);
                        else
                            sqlCmnd.Parameters.AddWithValue("@FechaIngreso", EMPLEADO.FechaIngreso);

                        if (EMPLEADO.Foto==null)
                            sqlCmnd.Parameters.AddWithValue("@Foto", DBNull.Value);
                        else
                            sqlCmnd.Parameters.AddWithValue("@Foto", EMPLEADO.Foto);

                        if ( EMPLEADO.INE==null)
                            sqlCmnd.Parameters.AddWithValue("@INE", DBNull.Value);
                        else
                            sqlCmnd.Parameters.AddWithValue("@INE", EMPLEADO.INE);

                        if (EMPLEADO.Activo==null)
                            sqlCmnd.Parameters.AddWithValue("@Activo", DBNull.Value);
                        else
                            sqlCmnd.Parameters.AddWithValue("@Activo", EMPLEADO.Activo);

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn == 1)
                                throw new Exception(reader["MensajeError"].ToString());

                            EMPLEADO.IdEmpleado = (int)reader["IdEmpleado"];
                            EMPLEADO.IdPersona = (int)reader["IdPersona"];
                            EMPLEADO.Persona.IdPersona = EMPLEADO.IdPersona;

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

        public void ABCTELEFONOS(char Op, Emp.TELEFONOS TELEFONOS)
        {
            const string querySql = "Emp.prTELEFONOS";
            int IntReturn;

            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@Op", Op);
                        sqlCmnd.Parameters.AddWithValue("@IdTelefono", TELEFONOS.IdTelefono);
                        sqlCmnd.Parameters.AddWithValue("@IdPersona", TELEFONOS.IdPersona);
                        sqlCmnd.Parameters.AddWithValue("@IdTipoTelefono", TELEFONOS.IdTipoTelefono);
                        sqlCmnd.Parameters.AddWithValue("@Telefono", TELEFONOS.Telefono);
                        sqlCmnd.Parameters.AddWithValue("@Activo", TELEFONOS.Activo);

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

        public void GuardarFoto(int IdEmpleado, string RutaFoto)
        {
            const string querySql = "Emp.GuardarFoto";
            int IntReturn;
            try
            {
                using (SqlConnection connection = _objPersistencia.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand sqlCmnd = _objPersistencia.GetSqlCommand(connection, querySql, CommandType.StoredProcedure))
                    {
                        sqlCmnd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                        sqlCmnd.Parameters.AddWithValue("@Foto", RutaFoto);                        

                        // Ejecucion del sqlCommand
                        using (SqlDataReader reader = sqlCmnd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("La ejecución del Store Procedure no arrojó ningun dato");

                            // Verificamos el resultado de la ejecucion de sp 0 = correcto y 1 existe algun error
                            IntReturn = (int)reader["Result"];

                            if (IntReturn >= 1)
                                throw new Exception(reader["MensajeError"].ToString());
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message} \n\n SP:  {querySql}");                
            }
        }
    }
}
