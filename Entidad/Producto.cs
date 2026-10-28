using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal PrecioCaja { get; set; }
        public int StockCajas { get; set; }
        public int StockMinimo { get; set; }

        public int IdCategoria { get; set; }
        public bool Activo { get; set; }

    }
}
