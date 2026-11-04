using Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace Dato
{
    public class PedidoDato
    {
        public DataTable ObtenerPedidos()
        {
            using (SqlConnection conexion = new ConexionDato().ObtenerConexion())
            {
                string query = "SELECT Id_Pedido, Id_Cliente, Fecha, Total, [varchar(20)] AS Estado FROM Pedido";

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

        public DataTable ObtenerPedidosPorCliente(int idCliente, string estado, DateTime fechaDesde, DateTime fechaHasta)
        {
            using (SqlConnection conexion = new ConexionDato().ObtenerConexion())
            {
                string query = @"SELECT Id_Pedido, Id_Cliente, Fecha, Total, [varchar(20)] AS Estado 
                               FROM Pedido WHERE Id_Cliente = @IdCliente 
                               AND (@Estado = '(Todos)' OR [varchar(20)] = @Estado) 
                               AND Fecha >= @FechaDesde 
                               AND Fecha < DATEADD(DAY, 1, @FechaHasta)";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;
                    comando.Parameters.Add("@Estado", SqlDbType.VarChar, 20).Value = estado;
                    comando.Parameters.Add("@FechaDesde", SqlDbType.DateTime).Value = fechaDesde.Date;
                    comando.Parameters.Add("@FechaHasta", SqlDbType.DateTime).Value = fechaHasta.Date;
                    DataTable tabla = new DataTable();
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                    return tabla;
                }
            }
        }

        public DataTable ObtenerDetallePedido(int idPedido)
        {
            using (SqlConnection conexion = new ConexionDato().ObtenerConexion())
            {
                string query = @"
            SELECT
                DP.Id_Producto,
                P.Nombre,
                DP.Cantidad,
                DP.PrecioUnitario,
                DP.Descuento,
                DP.Subtotal
            FROM DetallePedido DP
            INNER JOIN Producto P
                ON DP.Id_Producto = P.Id_Producto
            WHERE DP.Id_Pedido = @IdPedido";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add("@IdPedido", SqlDbType.Int).Value = idPedido;

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
