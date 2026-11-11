using Microsoft.Data.SqlClient;
using System.Configuration;
using Entidad;
using Mapper;

namespace Dato
{
    public class PedidoDAO
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        DetallePedidoMapper detalleMapper = new DetallePedidoMapper();
        // Trae los pedidos con su cliente y sus detalles
        public List<Pedido> ObtenerTodos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                cn.Open();

                string sql = @"SELECT p.IdPedido, p.Fecha, p.Total,
                                      c.IdCliente, c.CUIT, c.RazonSocial
                               FROM Pedido p
                               JOIN Cliente c ON c.IdCliente = p.IdCliente
                               ORDER BY p.Fecha DESC";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = ClienteMapper.Map(reader);
                        pedidos.Add(PedidoMapper.Map(reader, cliente));
                    }
                }

                // Los detalles se cargan aparte, con el reader anterior ya cerrado
                foreach (Pedido pedido in pedidos)
                    pedido.Detalles = ObtenerDetalles(cn, pedido.Id);
            }

            return pedidos;
        }

        private List<DetallePedido> ObtenerDetalles(SqlConnection cn, int idPedido)
        {
            List<DetallePedido> detalles = new List<DetallePedido>();

            string sql = @"SELECT dp.IdDetalle, dp.IdPedido, dp.Cantidad, dp.PrecioUnitario,
                                  p.IdProducto, p.Nombre AS NombreProducto, p.PrecioCaja,
                                  p.StockCajas, p.StockMinimo, p.Activo,
                                  p.IdCategoria, c.Nombre AS NombreCategoria
                           FROM DetallePedido dp
                           JOIN Producto p  ON p.IdProducto  = dp.IdProducto
                           JOIN Categoria c ON c.IdCategoria = p.IdCategoria
                           WHERE dp.IdPedido = @IdPedido";

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@IdPedido", idPedido);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto producto = ProductoMapper.DesdeReader(reader);
                        detalles.Add(detalleMapper.Map(reader, producto));
                    }
                }
            }

            return detalles;
        }

        // Guarda el pedido, sus detalles y descuenta el stock en una sola transacción
        public int Insertar(Pedido pedido)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        string sqlPedido = @"INSERT INTO Pedido (IdCliente, Fecha, Total)
                                             OUTPUT INSERTED.IdPedido
                                             VALUES (@IdCliente, @Fecha, @Total)";

                        int idPedido;
                        using (SqlCommand cmd = new SqlCommand(sqlPedido, cn, tx))
                        {
                            // Si tu entidad Pedido no tiene IdCliente, usá pedido.Cliente.Id
                            cmd.Parameters.AddWithValue("@IdCliente", pedido.Client.Id);
                            cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                            cmd.Parameters.AddWithValue("@Total", pedido.Total);
                            idPedido = (int)cmd.ExecuteScalar();
                        }

                        foreach (DetallePedido d in pedido.Detalles)
                        {
                            string sqlDetalle = @"INSERT INTO DetallePedido (IdPedido, IdProducto, Cantidad, PrecioUnitario)
                                                  VALUES (@IdPedido, @IdProducto, @Cantidad, @Precio)";

                            using (SqlCommand cmd = new SqlCommand(sqlDetalle, cn, tx))
                            {
                                cmd.Parameters.AddWithValue("@IdPedido", idPedido);
                                cmd.Parameters.AddWithValue("@IdProducto", d.Producto.Id);
                                cmd.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                                cmd.Parameters.AddWithValue("@Precio", d.PrecioUnitario);
                                cmd.ExecuteNonQuery();
                            }

                            string sqlStock = @"UPDATE Producto
                                                SET StockCajas = StockCajas - @Cantidad
                                                WHERE IdProducto = @IdProducto";

                            using (SqlCommand cmd = new SqlCommand(sqlStock, cn, tx))
                            {
                                cmd.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                                cmd.Parameters.AddWithValue("@IdProducto", d.Producto.Id);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tx.Commit();
                        return idPedido;
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}

