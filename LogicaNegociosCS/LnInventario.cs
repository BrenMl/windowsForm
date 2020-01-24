using AccesoDatosCS;
using EntidadNegociosCS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegociosCS
{
    public class LnInventario
    {
        private readonly adInventario _objAdInventario;

        public LnInventario(enDatosConn objEnDatosConn)
        {
            _objAdInventario = new adInventario(objEnDatosConn);
        }

        public void ABCINVENTARIO(char Op,Inv.INVENTARIO INVENTARIO)
        {
            try
            {
                _objAdInventario.ABCINVENTARIO(Op, INVENTARIO);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AfectarInventarioEntrada(int IdEntrada)
        {

            try
            {
                _objAdInventario.AfectarInventarioEntrada(IdEntrada);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        }
}
