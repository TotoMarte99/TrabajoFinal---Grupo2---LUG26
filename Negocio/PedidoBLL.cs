using Dato;
using Entidad;

namespace Negocio
{
    public class PedidoBLL
    {
        private readonly PedidoDAO dao = new PedidoDAO();

        // Listado completo (la DAO solo trae los datos)
        public List<Pedido> Listar()
        {
            return dao.ObtenerTodos();
        }

        // Para FrmConsultaPedidos: filtra por rango de fechas
        public List<Pedido> ListarPorFechas(DateTime desde, DateTime hasta)
        {
            return dao.ObtenerTodos()
                      .Where(p => p.Fecha.Date >= desde.Date && p.Fecha.Date <= hasta.Date)
                      .ToList();
        }

        // Para FrmPedido: valida, calcula el total y guarda
        public int Confirmar(Pedido pedido)
        {
            if (pedido.Client.Id <= 0)
                throw new Exception("Seleccioná un cliente.");

            if (pedido.Detalles == null || pedido.Detalles.Count == 0)
                throw new Exception("El pedido no tiene productos.");

            foreach (DetallePedido d in pedido.Detalles)
            {
                if (d.Cantidad <= 0)
                    throw new Exception("La cantidad de " + d.Producto.Nombre + " debe ser mayor a 0.");

                if (d.Cantidad > d.Producto.StockCajas)
                    throw new Exception("No hay stock suficiente de " + d.Producto.Nombre +
                                        " (disponible: " + d.Producto.StockCajas + " cajas).");
            }

            pedido.Fecha = DateTime.Now;
            pedido.Total = pedido.Detalles.Sum(d => d.Cantidad * d.PrecioUnitario);

            return dao.Insertar(pedido);
        }
    }
}