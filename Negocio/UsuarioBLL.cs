using System.Security.Cryptography;
using System.Text;
using Dato;
using Entidad;

namespace Negocio
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();

        public Usuario? Login(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrEmpty(contrasena))
                return null;

            Usuario? usuario = usuarioDAO.ObtenerPorNombreUsuario(nombreUsuario.Trim());

            if (usuario == null || !usuario.Activo)
                return null;

            if (usuario.Contrasena != Hash(contrasena))
                return null;

            Sesion.Iniciar(usuario);
            return usuario;
        }

        public List<Usuario> ObtenerTodos()
        {
            Sesion.ExigirAdministrador();
            return usuarioDAO.ObtenerTodos();
        }

        public void Insertar(Usuario usuario, string contrasena)
        {
            Sesion.ExigirAdministrador();
            Validar(usuario);
            ValidarContrasena(contrasena);

            usuario.Contrasena = Hash(contrasena);
            usuario.Id = usuarioDAO.Insertar(usuario);
        }

       
        public void Modificar(Usuario usuario, string contrasena)
        {
            Sesion.ExigirAdministrador();
            Validar(usuario);

            if (usuario.Id == Sesion.UsuarioActual!.Id &&
                (!usuario.Activo || usuario.Rol != Sesion.RolAdministrador))
            {
                throw new Exception("No puede darse de baja ni quitarse el rol de administrador a usted mismo.");
            }

            if (!string.IsNullOrEmpty(contrasena))
                ValidarContrasena(contrasena);

            if (!usuarioDAO.Modificar(usuario))
                throw new Exception("El usuario no existe.");

            if (!string.IsNullOrEmpty(contrasena))
                usuarioDAO.CambiarContrasena(usuario.Id, Hash(contrasena));
        }

        public void BajaLogica(int idUsuario)
        {
            Sesion.ExigirAdministrador();

            if (idUsuario == Sesion.UsuarioActual!.Id)
                throw new Exception("No puede darse de baja a usted mismo.");

            usuarioDAO.BajaLogica(idUsuario);
        }

        private void Validar(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
                throw new Exception("El nombre de usuario es obligatorio.");
            usuario.NombreUsuario = usuario.NombreUsuario.Trim();

            if (usuario.NombreUsuario.Length > 50)
                throw new Exception("El nombre de usuario no puede superar los 50 caracteres.");

            if (string.IsNullOrWhiteSpace(usuario.NombreCompleto))
                throw new Exception("El nombre completo es obligatorio.");
            usuario.NombreCompleto = usuario.NombreCompleto.Trim();

            if (usuario.Rol != Sesion.RolAdministrador && usuario.Rol != Sesion.RolVendedor)
                throw new Exception("El rol tiene que ser administrador o vendedor.");

            if (usuarioDAO.ExisteNombreUsuario(usuario.NombreUsuario, usuario.Id))
                throw new Exception("Ya existe un usuario con ese nombre.");
        }

        private void ValidarContrasena(string contrasena)
        {
            if (string.IsNullOrEmpty(contrasena) || contrasena.Length < 6)
                throw new Exception("La contraseña tiene que tener al menos 6 caracteres.");
        }

        // SHA-256 en hexadecimal
        public static string Hash(string texto)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(texto));
            return Convert.ToHexString(bytes).ToLowerInvariant();
        }
    }
}
