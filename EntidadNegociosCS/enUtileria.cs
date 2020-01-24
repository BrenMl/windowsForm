namespace enUtilerias
{
    public class EntidadFederativa : Loc.ENTIDADES_FEDERATIVAS
    {
        public Loc.PAISES Pais;

        public EntidadFederativa()
        {
            Pais = new Loc.PAISES();
        }
    }

    public class Municipio : Loc.MUNICIPIOS
    {
        public EntidadFederativa EntidadFederativa;

        public Municipio()
        {
            EntidadFederativa = new EntidadFederativa();
        }
    }

    public class CodigoPostal : Loc.CODIGOS_POSTALES
    {
        public Municipio Municipio;

        public CodigoPostal()
        {
            Municipio = new Municipio();
        }
    }

    public class Colonia : Loc.COLONIAS
    {
        public CodigoPostal CodigoPostal;

        public Colonia()
        {
            CodigoPostal = new CodigoPostal();
        }
    }

    public class Persona : Emp.PERSONAS
    {
        public Colonia Colonia;

        public Persona()
        {
            Colonia = new Colonia();
        }
    }

    public class Empleado : Emp.EMPLEADOS
    {
        public Persona Persona;

        public Empleado()
        {
            Persona = new Persona();
        }
    }

    public class Familiar : Emp.FAMILIARES
    {
        public Emp.PERSONAS Persona;
        public Emp.EMPLEADOS Empleado;

        public Familiar ()
        {
            Persona = new Emp.PERSONAS();
            Empleado = new Emp.EMPLEADOS();
        }

    }

    public class Producto : Pro.PRODUCTOS
    {
        public Pro.FAMILIAS Familia;
        public Pro.CONFECCIONES Confeccion;

        public Producto()
        {
            Familia = new Pro.FAMILIAS();
            Confeccion = new Pro.CONFECCIONES();
        }
    }

    public class Coordenadas
    {
        public double Latitud;
        public double Longitud;
    }

    public class Salida : Sal.SALIDAS
    {
        public Emp.EMPLEADOS Empleado;
        public Sal.ESTATUS_SALIDA EstatusSalida;

        public Salida()
        {
            Empleado = new Emp.EMPLEADOS();
            EstatusSalida = new Sal.ESTATUS_SALIDA();
        }
    }
}
