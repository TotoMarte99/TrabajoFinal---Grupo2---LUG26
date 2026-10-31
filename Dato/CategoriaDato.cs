using Entidad;
using Microsoft.Data.SqlClient;

namespace Dato
{
    public class CategoriaDato
    {
        public List<Categoria> ObtenerTodas()
        {
            var lista = new List<Categoria>();
            using var cn = Conexion.CrearConexion();
            using var cmd = new SqlCommand("SELECT Id_Categoria, Descripcion FROM Categoria ORDER BY Descripcion", cn);
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Categoria { Id = dr.GetInt32(0), Descripcion = dr.GetString(1) });
            }
            return lista;
        }

        public int Agregar(Categoria categoria)
        {
            using var cn = Conexion.CrearConexion();
            using var cmd = new SqlCommand(
                "INSERT INTO Categoria (Descripcion) OUTPUT INSERTED.Id_Categoria VALUES (@desc)", cn);
            cmd.Parameters.AddWithValue("@desc", categoria.Descripcion);
            cn.Open();
            return (int)cmd.ExecuteScalar()!;
        }

        public bool Editar(Categoria categoria)
        {
            using var cn = Conexion.CrearConexion();
            using var cmd = new SqlCommand(
                "UPDATE Categoria SET Descripcion = @desc WHERE Id_Categoria = @id", cn);
            cmd.Parameters.AddWithValue("@desc", categoria.Descripcion);
            cmd.Parameters.AddWithValue("@id", categoria.Id);
            cn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
