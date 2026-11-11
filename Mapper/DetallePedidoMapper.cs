using Entidad;
using Microsoft.Data.SqlClient;

namespace Mapper
{
    public class DetallePedidoMapper
    {
        public DetallePedido Map(SqlDataReader reader, Producto producto)
        {
            DetallePedido detalle = new DetallePedido
            {
                Id = Convert.ToInt32(reader["Id_Detalle"]),
                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                Descuento = Convert.ToDecimal(reader["Descuento"]),

                Producto = producto
            };
            return detalle;
        }
    }
}
