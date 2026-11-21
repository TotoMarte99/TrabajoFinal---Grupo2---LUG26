using Entidad;
using Microsoft.Data.SqlClient;

namespace Mapper
{
    public static class UsuarioMapper
    {
        public static Usuario Map(SqlDataReader reader)
        {
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(reader["Id_Usuario"]);
            usuario.NombreUsuario = reader["NombreUsuario"].ToString()!;
            usuario.Contrasena = reader["Contrasena"].ToString()!;
            usuario.NombreCompleto = reader["NombreCompleto"].ToString()!;
            usuario.Rol = reader["Rol"].ToString()!;
            usuario.Activo = Convert.ToBoolean(reader["Activo"]);

            return usuario;
        }
    }
}
