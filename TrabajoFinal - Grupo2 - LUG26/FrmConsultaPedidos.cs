using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmConsultaPedidos : Form
    {
        

        public FrmConsultaPedidos()
        {
            InitializeComponent();
        }

        private void FrmConsultaPedidos_Load(object sender, EventArgs e)
        {
            try
            {

            
                 
                ClienteBLL clienteNegocio2 = new ClienteBLL();

                //cmbCliente.DataSource = clienteNegocio.ObtenerClientes;
                cmbCliente.DataSource = clienteNegocio2.ObtenerTodos();
                cmbCliente.DisplayMember = "RazonSocial";
                //cmbCliente.ValueMember = "Id_Cliente";

                cmbCliente.ValueMember = "Id";

                dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPedidos.MultiSelect = false;
                dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPedidos.ReadOnly = true;

            
                PedidoBLL pedidoNegocio = new PedidoBLL();

                dgvPedidos.DataSource = pedidoNegocio.ObtenerPedidos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pedidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                string estado = cmbEstado.Text;
                DateTime fechaDesde = dtpDesde.Value.Date;
                DateTime fechaHasta = dtpHasta.Value.Date;

                PedidoBLL pedidoNegocio = new PedidoBLL();

                dgvPedidos.DataSource = pedidoNegocio.ObtenerPedidosPorCliente(idCliente, estado, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pedidos: " + ex.Message);
            }
        }





        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                int idPedido = Convert.ToInt32(
                    dgvPedidos.Rows[e.RowIndex].Cells["Id_Pedido"].Value);

                PedidoBLL pedidoNegocio = new PedidoBLL();

                DataTable detalle = pedidoNegocio.ObtenerDetallePedido(idPedido);

                if (detalle.Rows.Count == 0)
                {
                    MessageBox.Show("Este pedido no tiene productos registrados.");
                    return;
                }

                // Muestro los productos en una ventana temporal.
                Form ventanaDetalle = new Form();
                ventanaDetalle.Text = "Detalle del pedido N.º " + idPedido;
                ventanaDetalle.Size = new System.Drawing.Size(750, 400);
                ventanaDetalle.StartPosition = FormStartPosition.CenterParent;

                DataGridView dgvDetalle = new DataGridView();
                dgvDetalle.Dock = DockStyle.Fill;
                dgvDetalle.DataSource = detalle;
                dgvDetalle.ReadOnly = true;
                dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                ventanaDetalle.Controls.Add(dgvDetalle);
                ventanaDetalle.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el detalle: " + ex.Message);
            }
        }

        
    }
}

