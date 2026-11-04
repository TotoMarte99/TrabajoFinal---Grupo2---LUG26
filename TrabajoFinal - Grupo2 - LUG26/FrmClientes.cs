using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmClientes : Form
    {
        ClienteBLL clienteBusiness;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            clienteBusiness = new ClienteBLL();
            Cargar();
        }

        private void Cargar()
        {
            try
            {
                List<Cliente> lista = clienteBusiness.ObtenerTodos();

                // ---------- Grilla ----------
                dgvClientes.DataSource = lista;

                // Columnas que no se muestran (Nombre y Email vienen de la clase base y no se usan)
                foreach (string nombre in new[] { "Id", "Nombre", "Email" })
                {
                    if (dgvClientes.Columns.Contains(nombre))
                        dgvClientes.Columns[nombre].Visible = false;
                }

                dgvClientes.Columns["RazonSocial"].HeaderText = "Razón social";
                dgvClientes.Columns["Cuit"].HeaderText = "CUIT";
                dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
                dgvClientes.Columns["Direccion"].HeaderText = "Dirección";

                // ---------- Combos (solo clientes activos) ----------
                // Cada combo recibe su propia lista; si comparten la misma lista, cambian juntos.
                cmbCuitBaja.DataSource = lista.Where(c => c.Activo).ToList();
                cmbCuitEditar.DataSource = lista.Where(c => c.Activo).ToList();

                MostrarDatosEditar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ---------- Alta ----------

        private void LimpiarAlta()
        {
            txtRazon.Clear();
            txtCuit.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarAlta();
            txtRazon.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cuit = txtCuit.Text.Replace("-", "").Trim();

                if (cuit.Length != 11 || !cuit.All(char.IsDigit))
                {
                    MessageBox.Show("El CUIT debe tener 11 números.");
                    return;
                }

                Cliente cliente = new Cliente();
                cliente.RazonSocial = txtRazon.Text.Trim();
                cliente.Cuit = cuit;
                cliente.Telefono = txtTelefono.Text.Trim();
                cliente.Direccion = txtDireccion.Text.Trim();
                cliente.Activo = true;

                clienteBusiness.Insertar(cliente);

                MessageBox.Show("Cliente guardado correctamente.");
                LimpiarAlta();
                Cargar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarAlta();
        }

        // ---------- Baja ----------

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (cmbCuitBaja.SelectedValue == null)
            {
                MessageBox.Show("Elegí un CUIT.");
                return;
            }

            try
            {
                clienteBusiness.BajaLogica((int)cmbCuitBaja.SelectedValue);
                MessageBox.Show("Cliente dado de baja.");
                Cargar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ---------- Editar ----------

        private void MostrarDatosEditar()
        {
            Cliente cliente = cmbCuitEditar.SelectedItem as Cliente;

            if (cliente == null)
            {
                txtTelefonoEditar.Clear();
                txtDireccionEditar.Clear();
                return;
            }

            txtTelefonoEditar.Text = cliente.Telefono;
            txtDireccionEditar.Text = cliente.Direccion;
        }

        private void cmbCuitEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDatosEditar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbCuitEditar.SelectedValue == null)
            {
                MessageBox.Show("Elegí un CUIT.");
                return;
            }

            try
            {
                Cliente cliente = clienteBusiness.ObtenerPorId((int)cmbCuitEditar.SelectedValue);
                cliente.Telefono = txtTelefonoEditar.Text.Trim();
                cliente.Direccion = txtDireccionEditar.Text.Trim();

                clienteBusiness.Modificar(cliente);

                MessageBox.Show("Cliente modificado correctamente.");
                Cargar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
