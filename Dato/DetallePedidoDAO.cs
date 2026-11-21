using System.Collections.Generic;
using Entidad;
using Mapper;
using Microsoft.Data.SqlClient;

namespace Dato
{
    public class DetallePedidoDAO
    {
        DetallePedidoMapper DetallepedidoMap = new DetallePedidoMapper();

        // Trae las líneas de un pedido, cada una con su producto
        public List<DetallePedido> ObtenerPorPedido(int idPedido)
        {
            List<DetallePedido> detalles = new List<DetallePedido>();

            using (SqlConnection sqlConnection = Conexion.CrearConexion())
            {
                sqlConnection.Open();
                string sql = @"SELECT dp.Id_DetallePedido, dp.Cantidad, dp.PrecioUnitario, dp.Descuento,
                                      p.Id_Producto, p.Nombre, p.Id_Categoria, c.Descripcion AS NombreCategoria,
                                      p.PrecioCaja, p.StockCajas, p.StockMinimo, p.Activo
                               FROM DetallePedido dp
                               INNER JOIN Producto p  ON p.Id_Producto  = dp.Id_Producto
                               INNER JOIN Categoria c ON c.Id_Categoria = p.Id_Categoria
                               WHERE dp.Id_Pedido = @idPedido
                               ORDER BY dp.Id_DetallePedido";
                using (SqlCommand comando = new SqlCommand(sql, sqlConnection))
                {
                    comando.Parameters.AddWithValue("@idPedido", idPedido);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = ProductoMapper.DesdeReader(reader);
                            detalles.Add(DetallepedidoMap.Map(reader, producto));
                        }
                    }
                }
            }
            return detalles;
        }

        
        public void Insertar(DetallePedido detalle, int idPedido, SqlConnection conexion, SqlTransaction transaccion)
        {
            string sql = "INSERT INTO DetallePedido (Id_Pedido, Id_Producto, Cantidad, PrecioUnitario, Descuento, Subtotal) " +
                         "VALUES (@idPedido, @idProducto, @cantidad, @precio, @descuento, @subtotal)";
            using (SqlCommand comando = new SqlCommand(sql, conexion, transaccion))
            {
                comando.Parameters.AddWithValue("@idPedido", idPedido);
                comando.Parameters.AddWithValue("@idProducto", detalle.Producto.Id);
                comando.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                comando.Parameters.AddWithValue("@precio", detalle.PrecioUnitario);
                comando.Parameters.AddWithValue("@descuento", detalle.Descuento);
                comando.Parameters.AddWithValue("@subtotal", detalle.Subtotal);
                comando.ExecuteNonQuery();
            }
        }

        // Devuelve false si no había stock suficiente
        public bool DescontarStock(DetallePedido detalle, SqlConnection conexion, SqlTransaction transaccion)
        {
            string sql = "UPDATE Producto SET StockCajas = StockCajas - @cantidad " +
                         "WHERE Id_Producto = @idProducto AND StockCajas >= @cantidad";
            using (SqlCommand comando = new SqlCommand(sql, conexion, transaccion))
            {
                comando.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                comando.Parameters.AddWithValue("@idProducto", detalle.Producto.Id);
                return comando.ExecuteNonQuery() > 0;
            }
        }
    }
}
