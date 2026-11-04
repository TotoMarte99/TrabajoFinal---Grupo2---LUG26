using Entidad;
using Microsoft.Data.SqlClient;

namespace Mapper
{
    public static class ClienteMapper
    {
        public static Cliente Map(SqlDataReader reader)
        {
            Cliente Client = new Cliente();

            Client.Id = Convert.ToInt32(reader["Id_Cliente"]);
            Client.RazonSocial = reader["RazonSocial"].ToString()!;
            Client.Cuit = reader["Cuit"].ToString()!;
            Client.Telefono = reader["Telefono"].ToString()!;
            Client.Direccion = reader["Direccion"].ToString()!;
            Client.Activo = Convert.ToBoolean(reader["Activo"]);

            return Client;
            
        }
    }
}
