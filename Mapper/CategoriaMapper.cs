using Entidad;
using Microsoft.Data.SqlClient;

namespace Mapper
{
    public static class CategoriaMapper
    {
        
        public static Categoria DesdeReader(SqlDataReader dr)
        {
            return new Categoria
            {
                Id = dr.GetInt32(dr.GetOrdinal("Id_Categoria")),
                Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"))
            };
        }

        
        public static void CargarParametros(SqlCommand cmd, Categoria categoria)
        {
            cmd.Parameters.AddWithValue("@desc", categoria.Descripcion);
        }
    }
}
