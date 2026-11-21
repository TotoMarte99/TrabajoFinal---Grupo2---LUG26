using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        // "confirmado" o "anulado"
        public string Estado { get; set; } = string.Empty;

        public Cliente Client { get; set; } = new Cliente();

        
        public Usuario Usuario { get; set; } = new Usuario();

       
        public List<DetallePedido> Detalles { get; set; } = new List<DetallePedido>();
    }
}
