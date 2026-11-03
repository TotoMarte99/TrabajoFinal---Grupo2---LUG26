using Entidad;
using Microsoft.Data.SqlClient;

namespace Mapper
{
    public static class ProductoMapper
    {
        
        public static Producto DesdeReader(SqlDataReader dr)
        {
            return new Producto
            {
                Id = dr.GetInt32(dr.GetOrdinal("Id_Producto")),
                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                IdCategoria = dr.GetInt32(dr.GetOrdinal("Id_Categoria")),
                NombreCategoria = dr.GetString(dr.GetOrdinal("NombreCategoria")),
                PrecioCaja = dr.GetDecimal(dr.GetOrdinal("PrecioCaja")),
                StockCajas = dr.GetInt32(dr.GetOrdinal("StockCajas")),
                StockMinimo = dr.GetInt32(dr.GetOrdinal("StockMinimo")),
                Activo = dr.GetString(dr.GetOrdinal("Activo")).Trim() == "1"
            };
        }

        
        public static void CargarParametros(SqlCommand cmd, Producto p)
        {
            cmd.Parameters.AddWithValue("@nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@cat", p.IdCategoria);
            cmd.Parameters.AddWithValue("@precio", p.PrecioCaja);
            cmd.Parameters.AddWithValue("@stock", p.StockCajas);
            cmd.Parameters.AddWithValue("@minimo", p.StockMinimo);
            cmd.Parameters.AddWithValue("@activo", p.Activo ? "1" : "0");
        }
    }
}
