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
            CargarClientes();
            CargarProductos();
            MostrarDetalle();

           
        }

        private void CargarClientes()
        {
            cmbCliente.DisplayMember = "RazonSocial";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = clienteBLL.ObtenerTodos();
        }

        private void CargarProductos()
        {
            // Solo productos activos y con stock
            List<Producto> productos = productoBLL.ObtenerProductos()
                                                  .Where(p => p.Activo && p.StockCajas > 0)
                                                  .ToList();

            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
            cmbProducto.DataSource = productos;
        }

        // Muestra precio y stock del producto elegido
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto producto = cmbProducto.SelectedItem as Producto;
            if (producto == null) return;

            lblInfo.Text = "Categoría: " + producto.NombreCategoria +
                           " | Precio por caja: " + producto.PrecioCaja.ToString("C") +
                           " | Stock: " + producto.StockCajas + " cajas";

            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = producto.StockCajas;
            nudCantidad.Value = 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = cmbProducto.SelectedItem as Producto;
            if (producto == null)
            {
                MessageBox.Show("Seleccioná un producto.");
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            // Si el producto ya está en el detalle, se suma la cantidad
            DetallePedido existente = detalles.FirstOrDefault(d => d.Producto.Id == producto.Id);

            if (existente != null)
            {
                if (existente.Cantidad + cantidad > producto.StockCajas)
                {
                    MessageBox.Show("No hay stock suficiente. Disponible: " + producto.StockCajas + " cajas.");
                    return;
                }
                existente.Cantidad += cantidad;
            }
            else
            {
                DetallePedido detalle = new DetallePedido();
                detalle.Producto = producto;
                detalle.Cantidad = cantidad;
                detalle.PrecioUnitario = producto.PrecioCaja;
                detalles.Add(detalle);
            }

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
                Pedido pedido = new Pedido();
                pedido.Client.Id = (int)cmbCliente.SelectedValue;
                pedido.Detalles = detalles;

                int id = pedidoBLL.Confirmar(pedido);

                MessageBox.Show("Pedido N° " + id + " guardado correctamente.");

                detalles.Clear();
                MostrarDetalle();
                CargarProductos(); // para que se vea el stock actualizado
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                Subtotal = d.Cantidad * d.PrecioUnitario
            }).ToList();

            decimal total = detalles.Sum(d => d.Cantidad * d.PrecioUnitario);
            lblTotal.Text = "Total: " + total.ToString("C");
        }
    }
}

