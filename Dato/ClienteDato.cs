using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Dato
{
    public class ClienteDato
    {
        public DataTable ObtenerClientes()
        {
            using (SqlConnection conexion = new ConexionDato().ObtenerConexion())
            {
                string query = "SELECT Id_Cliente, RazonSocial FROM Cliente";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    DataTable tabla = new DataTable();
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                    return tabla;
                }
            }
        }
    }
}
