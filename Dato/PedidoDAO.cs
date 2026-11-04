using Entidad;
using Mapper;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Dato
{

    public class PedidoDAO
    {
        private static string Conexion = "TrabajoFinalDB";

        private ClienteDAO clienteDAO = new ClienteDAO();

        public void Cargar(Pedido pedido)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                {
                    sqlConnection.Open();

                    using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                    {


                        string sqlPedido = "INSERT INTO Pedido (Id_Cliente, Fecha, Total, Estado) " +
                            "VALUES (@idCliente,  @fecha, @total, @estado) ";

                        //int idPedido;
                        using (SqlCommand sqlCommand = new SqlCommand(sqlPedido, sqlConnection, sqlTransaction))
                        {
                            sqlCommand.Parameters.AddWithValue("@idCliente", pedido.Client.Id);

                            sqlCommand.Parameters.AddWithValue("@fecha", pedido.Fecha);
                            sqlCommand.Parameters.AddWithValue("@total", pedido.Total);
                            sqlCommand.Parameters.AddWithValue("@estado", pedido.Estado);
                            //idPedido = (int)sqlCommand.ExecuteScalar(); // Sala el Id_Pedido de la base de datos


                            sqlCommand.ExecuteNonQuery();
                        }


                    }
                }
            }
            catch (Exception)
            {
               throw;
            }
                    
                
            
        }

        
        public Pedido ObtenerPorId(int idPedido)
        {
            try
            {
                Pedido pedido = null;

                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT * FROM Pedido WHERE Id_Pedido = @idPedido";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idPedido", idPedido);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                Cliente cliente = clienteDAO.ObtenerPorId(Convert.ToInt32(sqlDataReader["Id_Cliente"]));
                                pedido = PedidoMapper.Map(sqlDataReader, cliente);

                                return pedido;
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Pedido> ObtenerTodos()
        {
            try
            {
                List<Pedido> pedidos = new List<Pedido>();

                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT * FROM Pedido";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                Cliente cliente = clienteDAO.ObtenerPorId(Convert.ToInt32(sqlDataReader["Id_Cliente"]));
                                pedidos.Add(PedidoMapper.Map(sqlDataReader, cliente));
                                
                            }
                        }
                    }
                }
                return pedidos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        

    }
}
