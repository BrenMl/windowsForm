using AccesoDatosCS;
using EntidadNegociosCS;
using enUtilerias;

namespace LogicaNegociosCS
{
    public class LnEmpleados
    {
        private readonly adEmpleados _objAdEmpleados;


        public LnEmpleados(enDatosConn objEnDatosConn)
        {
            _objAdEmpleados = new adEmpleados(objEnDatosConn);
        }

        public void ABCEMPLEADOS(char Op, Empleado EMPLEADO)
        {
            _objAdEmpleados.ABCEMPLEADOS(Op, EMPLEADO);
        }

        public void ABCFAMILIARES(char Op, Emp.FAMILIARES FAMILIARES)
        {
            _objAdEmpleados.ABCFAMILIARES(Op, FAMILIARES);
        }

        public void ABCPERSONAS(char Op, Empleado EMPLEADO)
        {
            _objAdEmpleados.ABCEMPLEADOS(Op, EMPLEADO);
        }

        public void ABCTELEFONOS(char Op, Emp.TELEFONOS TELEFONOS)
        {
            _objAdEmpleados.ABCTELEFONOS(Op, TELEFONOS);
        }

        public void GuardarFoto(int IdEmpleado, string RutaFoto)
        {
            _objAdEmpleados.GuardarFoto(IdEmpleado, RutaFoto);
        }
    }
}
