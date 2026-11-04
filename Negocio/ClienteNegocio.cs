using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dato;
using Entidad;

namespace Negocio
{
    public class ClienteNegocio
    {
        private ClienteDato clienteDato = new ClienteDato();

        public void ValidarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.RazonSocial))
            {
                throw new Exception("La razón social es obligatoria.");
            }
        }

        public DataTable ObtenerClientes()
        {
            try
            {
                return clienteDato.ObtenerClientes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes: " + ex.Message, ex);
            }
        }
    }
}
