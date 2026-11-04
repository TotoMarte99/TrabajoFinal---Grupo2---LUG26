using Entidad;
using Microsoft.Data.SqlClient;

namespace Mapper
{
   
    public static class PedidoMapper
    {
        public static Pedido Map(SqlDataReader reader, Cliente cliente)
        {
            Pedido Ped = new Pedido();

            Ped.Id = Convert.ToInt32(reader["Id_Pedido"]);
            
            Ped.Fecha = Convert.ToDateTime(reader["Fecha"]);
            Ped.Total = Convert.ToDecimal(reader["Total"]);
            Ped.Estado = reader["Estado"].ToString()!;

            Ped.Client = cliente;

            return Ped;
        }
    }


}
