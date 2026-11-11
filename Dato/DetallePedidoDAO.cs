using System.Collections.Generic;
using System.Configuration;
using Entidad;
using Mapper;
using Microsoft.Data.SqlClient;

namespace Dato
{
    public class DetallePedidoDAO
    {

        private static string Conexion = "TrabajoFinalDB";
        
        DetallePedidoMapper DetallepedidoMap = new DetallePedidoMapper();


        public List<DetallePedido> ObtenerPorPedido(int idPedido)
        {
            try
            {
                List<DetallePedido> detalles = new List<DetallePedido>();

                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT Id_Detalle, Id_Producto, Cantidad, PrecioUnitario, Descuento, Subtotal " +
                                 "FROM DetallePedido WHERE Id_Pedido = @idPedido";
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
            catch (Exception)
            {
                throw;
            }
        }

        // Guarda una linea del pedido
        // Los dos métodos siguientes usan la conexión y la transacción de PedidoDAO.ConfirmarEnTransaccion
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

        // Devuelve false si no había stock suficiente (nadie le ganó de mano en el medio)
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
