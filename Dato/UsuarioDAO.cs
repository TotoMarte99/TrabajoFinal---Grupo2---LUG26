using Entidad;
using Mapper;
using Microsoft.Data.SqlClient;

namespace Dato
{
    public class UsuarioDAO
    {
        private const string Columnas = "Id_Usuario, NombreUsuario, Contrasena, NombreCompleto, Rol, Activo";

        // Se usa en el login. Devuelve null si no existe.
        public Usuario? ObtenerPorNombreUsuario(string nombreUsuario)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT " + Columnas + " FROM Usuario WHERE NombreUsuario = @nombreUsuario", cn))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return UsuarioMapper.Map(reader);
                }
            }
            return null;
        }

        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection cn = Conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT " + Columnas + " FROM Usuario ORDER BY NombreUsuario", cn))
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        usuarios.Add(UsuarioMapper.Map(reader));
                }
            }
            return usuarios;
        }

        public bool ExisteNombreUsuario(string nombreUsuario, int idExcluido)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @nombreUsuario AND Id_Usuario <> @id", cn))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@id", idExcluido);
                cn.Open();
                return (int)cmd.ExecuteScalar()! > 0;
            }
        }

        // Devuelve el Id generado
        public int Insertar(Usuario usuario)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Usuario (NombreUsuario, Contrasena, NombreCompleto, Rol, Activo)
                  OUTPUT INSERTED.Id_Usuario
                  VALUES (@nombreUsuario, @contrasena, @nombreCompleto, @rol, @activo)", cn))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@nombreCompleto", usuario.NombreCompleto);
                cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                cmd.Parameters.AddWithValue("@activo", usuario.Activo);
                cn.Open();
                return (int)cmd.ExecuteScalar()!;
            }
        }

        // No toca la contraseña: para eso está CambiarContrasena
        public bool Modificar(Usuario usuario)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(
                @"UPDATE Usuario
                  SET NombreUsuario = @nombreUsuario, NombreCompleto = @nombreCompleto,
                      Rol = @rol, Activo = @activo
                  WHERE Id_Usuario = @id", cn))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@nombreCompleto", usuario.NombreCompleto);
                cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                cmd.Parameters.AddWithValue("@activo", usuario.Activo);
                cmd.Parameters.AddWithValue("@id", usuario.Id);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public void CambiarContrasena(int idUsuario, string hash)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Usuario SET Contrasena = @contrasena WHERE Id_Usuario = @id", cn))
            {
                cmd.Parameters.AddWithValue("@contrasena", hash);
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void BajaLogica(int idUsuario)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Usuario SET Activo = 0 WHERE Id_Usuario = @id", cn))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
