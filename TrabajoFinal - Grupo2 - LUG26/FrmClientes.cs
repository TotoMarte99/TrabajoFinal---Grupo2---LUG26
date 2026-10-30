using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnValidarCliente_Click(object sender, EventArgs e)

        {
            try
            {

                Cliente cliente = new Cliente();

                cliente.RazonSocial = txtRazonSocial.Text;

                ClienteNegocio clienteNegocio = new ClienteNegocio();

                clienteNegocio.ValidarCliente(cliente);

                MessageBox.Show("Cliente validado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
