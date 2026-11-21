using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public Producto Producto { get; set; } = new Producto();
        public int Cantidad { get; set; }

        // Precio del momento del pedido (se copia del producto al confirmar)
        public decimal PrecioUnitario { get; set; }

        // Porcentaje de descuento aplicado a la línea (0, 5 o 10)
        public decimal Descuento { get; set; }

        // Cantidad por precio, menos el descuento
        public decimal Subtotal
        {
            get { return Math.Round(Cantidad * PrecioUnitario * (1 - Descuento / 100m), 2); }
        }
    }
}
