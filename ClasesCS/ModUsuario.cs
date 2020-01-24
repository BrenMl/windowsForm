using EntidadNegociosCS;
using System;

namespace ClasesCS
{
    public class ModUsuario
    {
        public static int SessionIdUsuario { get; set; }
        public static string SessionNombreUsuario { get; set; }
        public static string SessionPassword { get; set; }
        public static bool SessionUsuarioAD { get; set; }
        public static string SessionEmpresa { get; set; }
        public static bool SessionCambioContrasena { get; set; }
        public static DateTime SessionFechaCambioContrasena { get; set; }


        public static Ent.PARAMETROS_GRALES SessionObjEnParametrosGrales { get; set; } = new Ent.PARAMETROS_GRALES();
        public static Ent.PARAMETROS_AD SessionObjEnParametrosAD { get; set; } = new Ent.PARAMETROS_AD();
        public static enDatosConn SessionObjEnDatosConn { get; set; } = new enDatosConn();


    }
}
