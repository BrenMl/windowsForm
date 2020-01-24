using AccesoDatosCS;
using EntidadNegociosCS;

namespace LogicaNegociosCS
{
    public class LnCatalogos
    {
        private adCatalogos _objAdCatalogo;

        public LnCatalogos(enDatosConn objEnDatosConn)
        {
            _objAdCatalogo = new adCatalogos(objEnDatosConn);
        }

        public void ABCDIAS_FESTIVOS(char Op, Cat.DIAS_FESTIVOS DIAS_FESTIVOS)
        {
            _objAdCatalogo.ABCDIAS_FESTIVOS(Op, DIAS_FESTIVOS);
        }
    }
}
