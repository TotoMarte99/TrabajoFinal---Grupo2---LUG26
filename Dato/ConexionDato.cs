
using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Dato
{
    public class ConexionDato
    {
        private static string Conexion = "TrabajoFinalDB";
        public SqlConnection ObtenerConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings[Conexion].ConnectionString;

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
