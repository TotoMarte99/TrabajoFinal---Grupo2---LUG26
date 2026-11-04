using Dato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Negocio
{
    public class PedidoNegocio
    {
        private PedidoDato pedidoDato = new PedidoDato();

        public DataTable ObtenerPedidos()
        {
            try
            {
                return pedidoDato.ObtenerPedidos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los pedidos: " + ex.Message, ex);
            }
        }

        public DataTable ObtenerPedidosPorCliente(int idCliente, string estado, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                if (idCliente <= 0)
                {
                    throw new Exception("El ID del cliente debe ser mayor que cero.");
                }
                if (fechaDesde > fechaHasta)
                {
                    throw new Exception("La fecha inicial no puede ser posterior que la fecha final.");
                }


                return pedidoDato.ObtenerPedidosPorCliente(idCliente, estado, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consuiltar los pedidos del cliente: " + ex.Message, ex);
            }
        }

        public DataTable ObtenerDetallePedido(int idPedido)
        {
            try
            {
                if (idPedido <= 0)
                {
                    throw new Exception("Debe seleccionar un pedido válido.");
                }

                return pedidoDato.ObtenerDetallePedido(idPedido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el detalle del pedido: " + ex.Message, ex);
            }
        }

    }
}
