using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Dato
{

    public static class Conexion
    {
        private const string NombreConnectionString = "TrabajoFinalDB";

        public static string ObtenerConnectionString()
        {
            var settings = ConfigurationManager.ConnectionStrings[NombreConnectionString];
            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                throw new ConfigurationErrorsException(
                    $"No se encontró el connection string '{NombreConnectionString}' en el App.config.");
            }
            return settings.ConnectionString;
        }

        public static SqlConnection CrearConexion()
        {
            return new SqlConnection(ObtenerConnectionString());
        }
    }
}
