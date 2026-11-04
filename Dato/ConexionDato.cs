
using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Dato
{
    public class ConexionDato
    {
        public SqlConnection ObtenerConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["TP_LUG_G2_Connection"].ConnectionString;

            return new SqlConnection(cadena);
        }

        public bool ProbarConexion()
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                return conexion.State == System.Data.ConnectionState.Open;
            }
        }
    }
}
