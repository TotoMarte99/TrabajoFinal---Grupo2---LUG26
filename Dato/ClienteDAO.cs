using Entidad;
using Mapper;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Dato
{
    public class ClienteDAO
    {
        private static string Conexion = "TrabajoFinalDB";


        public void agregarCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                { 
                    sqlConnection.Open();
                    string sql = "INSERT INTO Cliente( RazonSocial, Cuit, Telefono, Direccion, Activo)" +
                        "VALUES ( @razonSocial , @cuit , @telefono ,@direccion ,@activo)";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                       
                        sqlCommand.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                        sqlCommand.Parameters.AddWithValue("@cuit", cliente.Cuit);
                        sqlCommand.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        sqlCommand.Parameters.AddWithValue("@direccion", cliente.Direccion);
                        sqlCommand.Parameters.AddWithValue("@activo", cliente.Activo);

                        sqlCommand.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void Modificar(Cliente cliente)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "UPDATE Cliente SET RazonSocial = @razonSocial, Cuit = @cuit, Telefono = @telefono, " +
                        "Direccion = @direccion WHERE Id_Cliente = @id";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id", cliente.Id);
                        sqlCommand.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                        sqlCommand.Parameters.AddWithValue("@cuit", cliente.Cuit);
                        sqlCommand.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        sqlCommand.Parameters.AddWithValue("@direccion", cliente.Direccion);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaLogica(int idCliente)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "UPDATE Cliente SET Activo = 0 WHERE Id_Cliente = @idCliente";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idCliente", idCliente);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public Cliente ObtenerPorId(int idCliente)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT * FROM Cliente WHERE Id_Cliente = @idCliente";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idCliente", idCliente);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                return ClienteMapper.Map(sqlDataReader);
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

        public List<Cliente> ObtenerTodos()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();

                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT * FROM Cliente";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                clientes.Add(ClienteMapper.Map(sqlDataReader));
                            }
                        }
                    }
                }
                return clientes;
            }
            catch (Exception)
            {
                throw;
            }
        }




        public bool ExisteCuit(string cuit, int idCliente)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT COUNT(*) FROM Cliente WHERE Cuit = @cuit AND Id_Cliente <> @idCliente";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@cuit", cuit);
                        sqlCommand.Parameters.AddWithValue("@idCliente", idCliente);

                        return (int)sqlCommand.ExecuteScalar() > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
