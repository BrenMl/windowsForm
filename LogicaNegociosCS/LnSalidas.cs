using EntidadNegociosCS;
using AccesoDatosCS;
using System;

namespace LogicaNegociosCS
{
    public class LnSalidas
    {

        private readonly adSalidas _objAdSalidas;

        public LnSalidas(enDatosConn objEnDatosConn)
        {
            _objAdSalidas = new adSalidas(objEnDatosConn);
        }

        public void ABCSALIDAS(char Op, Sal.SALIDAS SALIDA)
        {
            try
            {
                _objAdSalidas.ABCSALIDAS(Op, SALIDA);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void ABCDETALLES_SALIDA(char Op, Sal.DETALLES_SALIDA DETALLES_SALIDA)
        {
            try
            {
                _objAdSalidas.ABCDETALLE_SALIDA(Op, DETALLES_SALIDA);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public void ABCTELEFONOS(char Op, Cte.TELEFONOS TELEFONOS)
        //{
        //    try
        //    {
        //        _objAdClientes.ABCTELEFONO(Op, TELEFONOS);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}
