using EntidadNegociosCS;
using AccesoDatosCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegociosCS
{
     public class LnClientes
    {

        private readonly adClientes _objAdClientes;

        public LnClientes(enDatosConn objEnDatosConn)
        {
            _objAdClientes = new adClientes(objEnDatosConn);
        }

        public void ABCCLIENTES(char Op, Cte.CLIENTES CLIENTES)
        {
            try
            {
                _objAdClientes.ABCCLIENTES(Op, CLIENTES);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ABCDOMICILIOS(char Op, Cte.DOMICILIOS DOMICILIOS)
        {
            try
            {
                _objAdClientes.ABCDOMICILIO(Op, DOMICILIOS);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ABCTELEFONOS(char Op, Cte.TELEFONOS TELEFONOS)
        {
            try
            {
                _objAdClientes.ABCTELEFONO(Op, TELEFONOS);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
