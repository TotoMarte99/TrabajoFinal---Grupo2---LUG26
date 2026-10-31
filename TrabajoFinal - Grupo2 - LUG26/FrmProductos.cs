using System;
using System.Linq;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmProductos : Form
    {
        private readonly ProductoNegocio productoNegocio = new ProductoNegocio();
        private readonly CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        private Producto? productoEnEdicion = null;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCategoria.DisplayMember = nameof(Categoria.Descripcion);
                cmbCategoria.ValueMember = nameof(Categoria.Id);
                cmbCategoria.DataSource = categoriaNegocio.ObtenerCategorias();

                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar()
        {
            var productos = productoNegocio.ObtenerProductos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
            if (dgvProductos.Columns.Contains(nameof(Producto.IdCategoria)))
                dgvProductos.Columns[nameof(Producto.IdCategoria)].Visible = false;

            cmbProducto.DataSource = null;
            cmbProducto.DisplayMember = nameof(Producto.Nombre);
            cmbProducto.ValueMember = nameof(Producto.Id);
            cmbProducto.DataSource = productos.ToList();
        }

        private void Limpiar()
        {
            productoEnEdicion = null;
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            nudPrecio.Value = 0;
            nudStock.Value = 0;
            nudMinimo.Value = 0;
            grpDatos.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            grpDatos.Enabled = true;
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is not Producto seleccionado)
            {
                MessageBox.Show("Debe seleccionar un producto para editar.", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            productoEnEdicion = seleccionado;
            txtNombre.Text = seleccionado.Nombre;
            cmbCategoria.SelectedValue = seleccionado.IdCategoria;
            nudPrecio.Value = seleccionado.PrecioCaja;
            nudStock.Value = seleccionado.StockCajas;
            nudMinimo.Value = seleccionado.StockMinimo;
            grpDatos.Enabled = true;
            txtNombre.Focus();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.SelectedItem is not Producto seleccionado)
                {
                    MessageBox.Show("Debe seleccionar un producto para dar de baja.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!seleccionado.Activo)
                {
                    MessageBox.Show("El producto ya está dado de baja.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirmar = MessageBox.Show($"¿Dar de baja el producto '{seleccionado.Nombre}'?",
                    "Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar != DialogResult.Yes) return;

                seleccionado.Activo = false;
                productoNegocio.EditarProducto(seleccionado);

                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Producto
                {
                    Id = productoEnEdicion?.Id ?? 0,
                    Nombre = txtNombre.Text,
                    IdCategoria = cmbCategoria.SelectedValue is int id ? id : 0,
                    PrecioCaja = nudPrecio.Value,
                    StockCajas = (int)nudStock.Value,
                    StockMinimo = (int)nudMinimo.Value,
                    Activo = productoEnEdicion?.Activo ?? true
                };

                if (productoEnEdicion == null)
                {
                    productoNegocio.AgregarProducto(producto);
                    MessageBox.Show("Producto agregado correctamente.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    productoNegocio.EditarProducto(producto);
                    MessageBox.Show("Producto editado correctamente.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
