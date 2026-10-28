using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } = string.Empty;

    }
}
