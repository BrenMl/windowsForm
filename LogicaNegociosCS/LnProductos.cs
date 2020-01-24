using AccesoDatosCS;
using EntidadNegociosCS;

namespace LogicaNegociosCS
{
    public class LnProductos
    {
        private readonly adProductos _objAdProductos;

        public LnProductos(enDatosConn objEnDatosConn)
        {
            _objAdProductos = new adProductos(objEnDatosConn);
        }

        public void ABCPRODUCTOS(char Op, Pro.PRODUCTOS PRODUCTOS)
        {
            _objAdProductos.ABCPRODUCTOS(Op, PRODUCTOS);
        }

        public void ABCALIAS(char Op, Pro.ALIAS ALIAS)
        {
            _objAdProductos.ABCALIAS(Op, ALIAS);
        }
    }
}
