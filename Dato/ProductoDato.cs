using Entidad;
using Microsoft.Data.SqlClient;

namespace Dato
{
    public class ProductoDato
    {
        // La columna Activo es nchar(10) en la BD: se guarda "1" / "0".
        public List<Producto> ObtenerTodos()
        {
            var lista = new List<Producto>();
            using var cn = Conexion.CrearConexion();
            using var cmd = new SqlCommand(
                @"SELECT p.Id_Producto, p.Nombre, p.Id_Categoria, c.Descripcion, p.PrecioCaja,
                         p.StockCajas, p.StockMinimo, p.Activo
                  FROM Producto p
                  INNER JOIN Categoria c ON c.Id_Categoria = p.Id_Categoria
                  ORDER BY p.Nombre", cn);
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Producto
                {
                    Id = dr.GetInt32(0),
                    Nombre = dr.GetString(1),
                    IdCategoria = dr.GetInt32(2),
                    NombreCategoria = dr.GetString(3),
                    PrecioCaja = dr.GetDecimal(4),
                    StockCajas = dr.GetInt32(5),
                    StockMinimo = dr.GetInt32(6),
                    Activo = dr.GetString(7).Trim() == "1"
                });
            }
            return lista;
        }

        public bool ExisteNombre(string nombre, int idExcluido = 0)
        {
            using var cn = Conexion.CrearConexion();
            using var cmd = new SqlCommand(
                "SELECT COUNT(1) FROM Producto WHERE Nombre = @nombre AND Id_Producto <> @id", cn);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@id", idExcluido);
            cn.Open();
            return (int)cmd.ExecuteScalar()! > 0;
        }

        public int Agregar(Producto p)
        {
            using var cn = Conexion.CrearConexion();
            using var cmd = new SqlCommand(
                @"INSERT INTO Producto (Nombre, Id_Categoria, PrecioCaja, StockCajas, StockMinimo, Activo)
                  OUTPUT INSERTED.Id_Producto
                  VALUES (@nombre, @cat, @precio, @stock, @minimo, @activo)", cn);
            CargarParametros(cmd, p);
            cn.Open();
            return (int)cmd.ExecuteScalar()!;
        }

        public bool Editar(Producto p)
        {
            using var cn = Conexion.CrearConexion();
            using var cmd = new SqlCommand(
                @"UPDATE Producto
                  SET Nombre = @nombre, Id_Categoria = @cat, PrecioCaja = @precio,
                      StockCajas = @stock, StockMinimo = @minimo, Activo = @activo
                  WHERE Id_Producto = @id", cn);
            CargarParametros(cmd, p);
            cmd.Parameters.AddWithValue("@id", p.Id);
            cn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        private static void CargarParametros(SqlCommand cmd, Producto p)
        {
            cmd.Parameters.AddWithValue("@nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@cat", p.IdCategoria);
            cmd.Parameters.AddWithValue("@precio", p.PrecioCaja);
            cmd.Parameters.AddWithValue("@stock", p.StockCajas);
            cmd.Parameters.AddWithValue("@minimo", p.StockMinimo);
            cmd.Parameters.AddWithValue("@activo", p.Activo ? "1" : "0");
        }
    }
}
