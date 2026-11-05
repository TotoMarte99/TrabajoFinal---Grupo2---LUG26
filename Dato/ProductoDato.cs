using Entidad;
using Mapper;
using Microsoft.Data.SqlClient;

namespace Dato
{
    public class ProductoDato
    {
        public List<Producto> ObtenerTodos()
        {
            var lista = new List<Producto>();
            using var cn = Conexion.CrearConexion();
            using var cmd = new SqlCommand(
                @"SELECT p.Id_Producto, p.Nombre, p.Id_Categoria, c.Descripcion AS NombreCategoria, p.PrecioCaja,
                         p.StockCajas, p.StockMinimo, p.Activo
                  FROM Producto p
                  INNER JOIN Categoria c ON c.Id_Categoria = p.Id_Categoria
                  ORDER BY p.Nombre", cn);
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(ProductoMapper.DesdeReader(dr));
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
            ProductoMapper.CargarParametros(cmd, p);
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
            ProductoMapper.CargarParametros(cmd, p);
            cmd.Parameters.AddWithValue("@id", p.Id);
            cn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
