using AccesoDatosCS;
using EntidadNegociosCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegociosCS
{
    public class lnRutas
    {
        

        private readonly adRutas _objAdRutas;

        public lnRutas(enDatosConn objEnDatosConn)
        {
            _objAdRutas = new adRutas(objEnDatosConn);
        }

        public void ABCRUTAS(char Op, Rut.RUTAS RUTAS) {
            _objAdRutas.ABCRUTAS(Op, RUTAS);
        }

        public void ABCDETALLES_RUTA(char Op, Rut.DETALLES_RUTA DETALLES_RUTA)
        {
            _objAdRutas.ABCDETALLES_RUTA(Op, DETALLES_RUTA);
        }

        public void ABCDIAS(char Op, Rut.DIAS DIAS) {
            _objAdRutas.ABCDIAS(Op, DIAS);
        }


    }

   

}
