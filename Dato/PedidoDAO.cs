using Microsoft.Data.SqlClient;
using Entidad;
using Mapper;

namespace Dato
{
    public class PedidoDAO
    {
        private readonly DetallePedidoDAO detalleDAO = new DetallePedidoDAO();

        // Trae las cabeceras de los pedidos con su cliente y el usuario que los cargó.
        // El detalle se pide aparte con DetallePedidoDAO.ObtenerPorPedido.
        public List<Pedido> ObtenerTodos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            using (SqlConnection cn = Conexion.CrearConexion())
            {
                cn.Open();

                string sql = @"SELECT p.Id_Pedido, p.Fecha, p.Total, p.Estado,
                                      c.Id_Cliente, c.RazonSocial, c.Cuit, c.Telefono, c.Direccion, c.Activo,
                                      u.Id_Usuario, u.NombreUsuario, u.NombreCompleto, u.Rol
                               FROM Pedido p
                               INNER JOIN Cliente c ON c.Id_Cliente = p.Id_Cliente
                               INNER JOIN Usuario u ON u.Id_Usuario = p.Id_Usuario
                               ORDER BY p.Fecha DESC";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = ClienteMapper.Map(reader);

                        // No se usa UsuarioMapper porque acá no se trae la contraseña
                        Usuario usuario = new Usuario
                        {
                            Id = Convert.ToInt32(reader["Id_Usuario"]),
                            NombreUsuario = reader["NombreUsuario"].ToString()!,
                            NombreCompleto = reader["NombreCompleto"].ToString()!,
                            Rol = reader["Rol"].ToString()!
                        };

                        pedidos.Add(PedidoMapper.Map(reader, cliente, usuario));
                    }
                }
            }

            return pedidos;
        }

        public int ConfirmarEnTransaccion(Pedido pedido)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        // 1. Cabecera
                        string sqlPedido = @"INSERT INTO Pedido (Id_Cliente, Id_Usuario, Fecha, Total, Estado)
                                             OUTPUT INSERTED.Id_Pedido
                                             VALUES (@idCliente, @idUsuario, @fecha, @total, @estado)";

                        int idPedido;
                        using (SqlCommand cmd = new SqlCommand(sqlPedido, cn, tx))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", pedido.Client.Id);
                            cmd.Parameters.AddWithValue("@idUsuario", pedido.Usuario.Id);
                            cmd.Parameters.AddWithValue("@fecha", pedido.Fecha);
                            cmd.Parameters.AddWithValue("@total", pedido.Total);
                            cmd.Parameters.AddWithValue("@estado", pedido.Estado);
                            idPedido = (int)cmd.ExecuteScalar()!;
                        }

                        foreach (DetallePedido detalle in pedido.Detalles)
                        {
                            // 2. Línea de detalle
                            detalleDAO.Insertar(detalle, idPedido, cn, tx);

                            // 3. Descuento de stock
                            if (!detalleDAO.DescontarStock(detalle, cn, tx))
                            {
                                throw new InvalidOperationException(
                                    "No hay stock suficiente de " + detalle.Producto.Nombre + ".");
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
