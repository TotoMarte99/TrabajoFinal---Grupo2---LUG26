using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dato;

namespace Negocio
{
    public class ClienteNegocio
    {
        private ClienteDato clienteDato = new ClienteDato();
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
