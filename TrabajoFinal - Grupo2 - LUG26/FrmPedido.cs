using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmPedido : Form
    {
        private ClienteBLL clienteBLL = new ClienteBLL();
        private ProductoNegocio productoBLL = new ProductoNegocio();
        private PedidoBLL pedidoBLL = new PedidoBLL();

        // El detalle se arma en memoria y recién se guarda al confirmar
        private List<DetallePedido> detalles = new List<DetallePedido>();

        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            try
            {
                CargarClientes();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nuevo pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarDetalle();
        }

        private void CargarClientes()
        {
            // Solo clientes activos
            cmbCliente.DisplayMember = "RazonSocial";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = clienteBLL.ObtenerTodos()
                                              .Where(c => c.Activo)
                                              .OrderBy(c => c.RazonSocial)
                                              .ToList();
        }

        private void CargarProductos()
        {
            // Solo productos activos. Los que no tienen stock se muestran igual:
            // el control de stock lo hace la capa Negocio al confirmar (RN-06).
            List<Producto> productos = productoBLL.ObtenerProductos()
                                                  .Where(p => p.Activo)
                                                  .ToList();

            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
            cmbProducto.DataSource = productos;
        }

        // Muestra precio y stock del producto elegido
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto? producto = cmbProducto.SelectedItem as Producto;
            if (producto == null)
            {
                lblInfo.Text = "";
                return;
            }

            lblInfo.Text = "Categoría: " + producto.NombreCategoria +
                           " | Precio por caja: " + producto.PrecioCaja.ToString("C") +
                           " | Stock: " + producto.StockCajas + " cajas" +
                           " | Descuento: 5 % desde 20 cajas, 10 % desde 50";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto? producto = cmbProducto.SelectedItem as Producto;
            if (producto == null)
            {
                MessageBox.Show("Seleccioná un producto.");
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            // Si el producto ya está en el detalle, se suma la cantidad
            DetallePedido? detalle = detalles.FirstOrDefault(d => d.Producto.Id == producto.Id);

            if (detalle != null)
            {
                detalle.Cantidad += cantidad;
            }
            else
            {
                detalle = new DetallePedido();
                detalle.Producto = producto;
                detalle.Cantidad = cantidad;
                detalle.PrecioUnitario = producto.PrecioCaja;
                detalles.Add(detalle);
            }

            // El porcentaje lo decide la capa Negocio; acá solo se muestra
            detalle.Descuento = pedidoBLL.CalcularDescuento(detalle.Cantidad);

            nudCantidad.Value = 1;
            MostrarDetalle();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una fila del detalle.");
                return;
            }

            detalles.RemoveAt(dgvDetalle.CurrentRow.Index);
            MostrarDetalle();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            detalles.Clear();
            MostrarDetalle();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente? cliente = cmbCliente.SelectedItem as Cliente;
                if (cliente == null)
                {
                    MessageBox.Show("Seleccioná un cliente.");
                    return;
                }

                Pedido pedido = new Pedido();
                pedido.Client = cliente;
                pedido.Detalles = new List<DetallePedido>(detalles);

                int id = pedidoBLL.ConfirmarPedido(pedido);

                MessageBox.Show("Pedido N° " + id + " guardado correctamente." + Environment.NewLine +
                                "Total: " + pedido.Total.ToString("C"),
                    "Nuevo pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AvisarReposicion(pedido);

                detalles.Clear();
                MostrarDetalle();
                CargarProductos(); // para que se vea el stock actualizado
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nuevo pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // RN-12: avisa si algún producto del pedido quedó en el mínimo o por debajo
        private void AvisarReposicion(Pedido pedido)
        {
            try
            {
                List<Producto> aReponer = pedidoBLL.ObtenerAlertasStock(pedido);
                if (aReponer.Count == 0) return;

                string lineas = string.Join(Environment.NewLine,
                    aReponer.Select(p => "- " + p.Nombre + ": quedan " + p.StockCajas +
                                         " cajas (mínimo " + p.StockMinimo + ")"));

                MessageBox.Show("Estos productos quedaron en el stock mínimo o por debajo y hay que reponerlos:" +
                                Environment.NewLine + lineas,
                    "Reposición", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                // El pedido ya quedó grabado; si falla el aviso no se interrumpe al usuario
            }
        }

        // Refresca la grilla y el total
        private void MostrarDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = detalles.Select(d => new
            {
                Producto = d.Producto.Nombre,
                Categoria = d.Producto.NombreCategoria,
                Cajas = d.Cantidad,
                PrecioCaja = d.PrecioUnitario,
                Descuento = d.Descuento.ToString("0.##") + " %",
                Subtotal = d.Subtotal
            }).ToList();

            if (dgvDetalle.Columns.Contains("PrecioCaja"))
            {
                dgvDetalle.Columns["PrecioCaja"].HeaderText = "Precio por caja";
                dgvDetalle.Columns["PrecioCaja"].DefaultCellStyle.Format = "C2";
            }
            if (dgvDetalle.Columns.Contains("Subtotal"))
                dgvDetalle.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            if (dgvDetalle.Columns.Contains("Categoria"))
                dgvDetalle.Columns["Categoria"].HeaderText = "Categoría";

            decimal total = detalles.Sum(d => d.Subtotal);
            lblTotal.Text = "Total: " + total.ToString("C");
        }
    }
}
