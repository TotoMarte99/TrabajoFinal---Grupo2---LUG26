using System;
using System.Collections.Generic;
using Dato;
using Entidad;

namespace Negocio
{
    public class DetallePedidoBLL
    {


        private DetallePedidoDAO detallePedidoDAO = new DetallePedidoDAO();

        public List<DetallePedido> ObtenerPorPedido(int idPedido)
        {
            try
            {
                if (idPedido <= 0)
                {
                    throw new Exception("Debe seleccionar un pedido válido.");
                }

                return detallePedidoDAO.ObtenerPorPedido(idPedido);
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
