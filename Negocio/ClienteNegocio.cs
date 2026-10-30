using System;
using System.Collections.Generic;
using System.Text;
using Entidad;

namespace Negocio
{
    public class ClienteNegocio
    {
        public void ValidarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.RazonSocial))
            {
                throw new Exception("La razón social es obligatoria.");
            }
        }
    }
}
