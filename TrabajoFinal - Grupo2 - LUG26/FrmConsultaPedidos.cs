using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmConsultaPedidos : Form
    {
        private const string Todos = "(Todos)";

        private readonly PedidoBLL pedidoNegocio = new PedidoBLL();
        private readonly DetallePedidoBLL detalleNegocio = new DetallePedidoBLL();
        private readonly ClienteBLL clienteNegocio = new ClienteBLL();

        public FrmConsultaPedidos()
        {
            InitializeComponent();
        }

        private void FrmConsultaPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                // Clientes, con una primera opción para no filtrar
                List<Cliente> clientes = clienteNegocio.ObtenerTodos()
                                                       .OrderBy(c => c.RazonSocial)
                                                       .ToList();
                clientes.Insert(0, new Cliente { Id = 0, RazonSocial = Todos });

                cmbCliente.DisplayMember = "RazonSocial";
                cmbCliente.ValueMember = "Id";
                cmbCliente.DataSource = clientes;

                cmbEstado.Items.Clear();
                cmbEstado.Items.Add(Todos);
                cmbEstado.Items.Add(PedidoBLL.EstadoConfirmado);
                cmbEstado.Items.Add(PedidoBLL.EstadoAnulado);
                cmbEstado.SelectedIndex = 0;

                dtpDesde.Value = DateTime.Today.AddMonths(-1);
                dtpHasta.Value = DateTime.Today;

                Buscar();
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
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pedidos: " + ex.Message);
            }
        }

        private void Buscar()
        {
            int idCliente = cmbCliente.SelectedValue is int id ? id : 0;
            string estado = cmbEstado.Text == Todos ? "" : cmbEstado.Text;

            List<Pedido> pedidos = pedidoNegocio.Consultar(idCliente, estado, dtpDesde.Value.Date, dtpHasta.Value.Date);

            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidos.Select(p => new
            {
                Numero = p.Id,
                Fecha = p.Fecha,
                Cliente = p.Client.RazonSocial,
                CUIT = p.Client.Cuit,
                Vendedor = p.Usuario.NombreCompleto,
                Estado = p.Estado,
                Total = p.Total
            }).ToList();

            if (dgvPedidos.Columns.Contains("Numero"))
                dgvPedidos.Columns["Numero"].HeaderText = "N°";
            if (dgvPedidos.Columns.Contains("Fecha"))
                dgvPedidos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            if (dgvPedidos.Columns.Contains("Total"))
                dgvPedidos.Columns["Total"].DefaultCellStyle.Format = "C2";
        }

        // Doble clic en un pedido: muestra su detalle completo
        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                DataGridViewRow fila = dgvPedidos.Rows[e.RowIndex];
                int idPedido = Convert.ToInt32(fila.Cells["Numero"].Value);

                List<DetallePedido> detalle = detalleNegocio.ObtenerPorPedido(idPedido);

                if (detalle.Count == 0)
                {
                    MessageBox.Show("Este pedido no tiene productos registrados.");
                    return;
                }

                // Muestro los productos en una ventana temporal.
                using (Form ventanaDetalle = new Form())
                {
                    ventanaDetalle.Text = "Detalle del pedido N.º " + idPedido + "  ·  " +
                                          fila.Cells["Cliente"].Value + "  ·  Total: " +
                                          Convert.ToDecimal(fila.Cells["Total"].Value).ToString("C");
                    ventanaDetalle.Size = new System.Drawing.Size(800, 400);
                    ventanaDetalle.StartPosition = FormStartPosition.CenterParent;

                    DataGridView dgvDetalle = new DataGridView();
                    dgvDetalle.Dock = DockStyle.Fill;
                    dgvDetalle.ReadOnly = true;
                    dgvDetalle.AllowUserToAddRows = false;
                    dgvDetalle.AllowUserToDeleteRows = false;
                    dgvDetalle.RowHeadersVisible = false;
                    dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    ventanaDetalle.Controls.Add(dgvDetalle);

                    dgvDetalle.DataSource = detalle.Select(d => new
                    {
                        Producto = d.Producto.Nombre,
                        Categoria = d.Producto.NombreCategoria,
                        Cajas = d.Cantidad,
                        PrecioUnitario = d.PrecioUnitario.ToString("C"),
                        Descuento = d.Descuento.ToString("0.##") + " %",
                        Subtotal = d.Subtotal.ToString("C")
                    }).ToList();

                    ventanaDetalle.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el detalle: " + ex.Message);
            }
        }
    }
}
