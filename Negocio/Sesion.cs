using Entidad;

namespace Negocio
{
    // Usuario que ingresó al sistema.
    // RN-11: el control de permisos se hace acá, en la capa Negocio,
    // y no solamente escondiendo opciones del menú.
    public static class Sesion
    {
        public const string RolAdministrador = "administrador";
        public const string RolVendedor = "vendedor";

        public static Usuario? UsuarioActual { get; private set; }

        public static bool EsAdministrador
        {
            get { return UsuarioActual != null && UsuarioActual.Rol == RolAdministrador; }
        }

        internal static void Iniciar(Usuario usuario)
        {
            UsuarioActual = usuario;
        }

        public static void Cerrar()
        {
            UsuarioActual = null;
        }

        public static void ExigirSesion()
        {
            if (UsuarioActual == null)
                throw new Exception("Tiene que ingresar al sistema para hacer esta operación.");
        }

        public static void ExigirAdministrador()
        {
            ExigirSesion();
            if (!EsAdministrador)
                throw new Exception("Solo un administrador puede hacer esta operación.");
        }
    }
}
