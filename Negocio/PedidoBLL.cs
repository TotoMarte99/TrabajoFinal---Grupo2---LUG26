using Dato;
using Entidad;

namespace Negocio
{
    public class PedidoBLL
    {
        public const string EstadoConfirmado = "confirmado";
        public const string EstadoAnulado = "anulado";

        private readonly PedidoDAO dao = new PedidoDAO();
        private readonly ProductoDato productoDato = new ProductoDato();
        private readonly ClienteDAO clienteDAO = new ClienteDAO();

        
        public List<Pedido> Listar()
        {
            Sesion.ExigirSesion();
            return dao.ObtenerTodos();
        }

        
        public List<Pedido> ListarPorFechas(DateTime desde, DateTime hasta)
        {
            return Consultar(0, "", desde, hasta);
        }

        public List<Pedido> Consultar(int idCliente, string estado, DateTime desde, DateTime hasta)
        {
            Sesion.ExigirSesion();

            if (desde.Date > hasta.Date)
                throw new Exception("La fecha desde no puede ser posterior a la fecha hasta.");

            return dao.ObtenerTodos()
                      .Where(p => idCliente <= 0 || p.Client.Id == idCliente)
                      .Where(p => string.IsNullOrEmpty(estado) || p.Estado == estado)
                      .Where(p => p.Fecha.Date >= desde.Date && p.Fecha.Date <= hasta.Date)
                      .ToList();
        }

        // RN-07: 5 % desde 20 cajas del mismo producto, 10 % desde 50
        public decimal CalcularDescuento(int cantidad)
        {
            if (cantidad >= 50) return 10m;
            if (cantidad >= 20) return 5m;
            return 0m;
        }

        
        public int ConfirmarPedido(Pedido pedido)
        {
            Sesion.ExigirSesion();

            if (pedido.Client == null || pedido.Client.Id <= 0)
                throw new Exception("Seleccioná un cliente.");

            Cliente cliente = clienteDAO.ObtenerPorId(pedido.Client.Id);
            if (cliente == null || !cliente.Activo)
                throw new Exception("El cliente no existe o está dado de baja.");

            // RN-08: no se graba un pedido sin al menos una línea
            if (pedido.Detalles == null || pedido.Detalles.Count == 0)
                throw new Exception("El pedido no tiene productos.");

            
            Dictionary<int, Producto> productos = productoDato.ObtenerTodos().ToDictionary(p => p.Id);

            List<string> faltantes = new List<string>();

            foreach (DetallePedido d in pedido.Detalles)
            {
                // RN-05: cantidad válida
                if (d.Cantidad <= 0)
                    throw new Exception("La cantidad de " + d.Producto.Nombre + " debe ser mayor a 0.");

                if (pedido.Detalles.Count(x => x.Producto.Id == d.Producto.Id) > 1)
                    throw new Exception("El producto " + d.Producto.Nombre + " está repetido en el pedido.");

                if (!productos.TryGetValue(d.Producto.Id, out Producto? actual) || !actual.Activo)
                    throw new Exception("El producto " + d.Producto.Nombre + " no existe o está dado de baja.");

                d.Producto = actual;
                d.PrecioUnitario = actual.PrecioCaja;           // precio del momento del pedido
                d.Descuento = CalcularDescuento(d.Cantidad);    // RN-07

                // RN-06: stock suficiente. Se juntan todos los faltantes para avisarlos de una vez.
                if (d.Cantidad > actual.StockCajas)
                {
                    faltantes.Add("- " + actual.Nombre + ": pidió " + d.Cantidad +
                                  ", quedan " + actual.StockCajas + " cajas");
                }
            }

            if (faltantes.Count > 0)
            {
                throw new Exception("No hay stock suficiente. El pedido no se grabó." + Environment.NewLine +
                                    string.Join(Environment.NewLine, faltantes));
            }

            pedido.Fecha = DateTime.Now;
            pedido.Estado = EstadoConfirmado;
            pedido.Usuario = Sesion.UsuarioActual!;
            pedido.Total = pedido.Detalles.Sum(d => d.Subtotal);

            // RN-09: el total de la cabecera tiene que coincidir con la suma de los subtotales
            if (pedido.Total != pedido.Detalles.Sum(d => d.Subtotal) || pedido.Total <= 0)
                throw new Exception("El total del pedido no coincide con la suma de los subtotales.");

            try
            {
                
                return dao.ConfirmarEnTransaccion(pedido);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo confirmar el pedido. No se grabó ningún dato." +
                                    Environment.NewLine + "Detalle: " + ex.Message, ex);
            }
        }

        // RN-12: productos del pedido que después de confirmar quedaron en el mínimo o por debajo.
        
        public List<Producto> ObtenerAlertasStock(Pedido pedido)
        {
            List<int> ids = pedido.Detalles.Select(d => d.Producto.Id).ToList();

            return productoDato.ObtenerTodos()
                               .Where(p => ids.Contains(p.Id) && p.StockCajas <= p.StockMinimo)
                               .ToList();
        }
    }
}
