using Dato;
using Entidad;


namespace Negocio
{
    public class ClienteBLL
    {
        private ClienteDAO clienteDAO = new ClienteDAO();

        public void Insertar(Cliente cliente)
        {
            Validar(cliente);
            clienteDAO.agregarCliente(cliente);
        }

        public void Modificar(Cliente cliente)
        {
            Validar(cliente);
            clienteDAO.Modificar(cliente);
        }

        
        public void BajaLogica(int idCliente)
        {
            clienteDAO.BajaLogica(idCliente);
        }

        public Cliente ObtenerPorId(int idCliente)
        {
            return clienteDAO.ObtenerPorId(idCliente);
        }

        public List<Cliente> ObtenerTodos() 
        {
            try
            {
                return clienteDAO.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw;
            }



        }



        private void Validar(Cliente cliente)
        {
            
            if (string.IsNullOrWhiteSpace(cliente.RazonSocial))
                throw new Exception("La razón social es obligatoria.");
            cliente.RazonSocial = cliente.RazonSocial.Trim();

            
            string digitos = new string((cliente.Cuit ?? "").Where(char.IsDigit).ToArray());
            if (!CuitValido(digitos))
                throw new Exception("El CUIT no es válido. Tiene que tener 11 dígitos y un dígito verificador correcto.");
            cliente.Cuit = digitos;

            
            if (clienteDAO.ExisteCuit(cliente.Cuit, cliente.Id))
                throw new Exception("Ya existe un cliente con ese CUIT.");
        }

        // Verifica los 11 dígitos y el dígito verificador (módulo 11)
        private bool CuitValido(string cuit)
        {
            if (cuit.Length != 11) return false;

            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                suma += (cuit[i] - '0') * multiplicadores[i];
            }

            int verificador = 11 - (suma % 11);
            if (verificador == 11) verificador = 0;

            return verificador != 10 && verificador == (cuit[10] - '0');
        }
    }
}

