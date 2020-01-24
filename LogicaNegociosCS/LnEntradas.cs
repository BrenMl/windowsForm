using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadNegociosCS;
using AccesoDatosCS;

namespace LogicaNegociosCS
{
   public class LnEntradas
    {
        private readonly adEntradas _objAdEntradas;

        public LnEntradas(enDatosConn objEnDatosConn)
        {
            _objAdEntradas = new adEntradas(objEnDatosConn);
        }

        public void ABCENTRADAS(char Op, Entr.ENTRADAS ENTRADAS)
        {
            try
            {
                _objAdEntradas.ABCENTRADAS(Op, ENTRADAS);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ABCDETALLES_ENTRADA(char Op, Entr.DETALLES_ENTRADA DETALLES_ENTRADA)
        {
            try
            {
                _objAdEntradas.ABCDETALLES_ENTRADA(Op, DETALLES_ENTRADA);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
