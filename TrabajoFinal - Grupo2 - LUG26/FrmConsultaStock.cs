using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    // Muestra el stock de cada producto y marca los que hay que reponer
    public partial class FrmConsultaStock : Form
    {
        private readonly ProductoNegocio productoNegocio = new ProductoNegocio();
        private readonly CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        List<Categoria> categorias;

        public FrmConsultaStock()
        {
            InitializeComponent();
            Cargar();
        }

        private void FrmConsultaStock_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            var categorias = categoriaNegocio.ObtenerCategorias();

            var productos = productoNegocio.ObtenerProductos();

            CargarDgvStock();


            cmbCategoria.DataSource = null;
            cmbCategoria.DisplayMember = nameof(Categoria.Descripcion);
            cmbCategoria.ValueMember = nameof(Categoria.Id);
            cmbCategoria.DataSource = categorias.ToList();

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Todos");
            cmbEstado.Items.Add("Bajo el mínimo");
            cmbEstado.Items.Add("Sin stock");
            cmbEstado.SelectedIndex = 0;
        }

        public void CargarDgvStock()
        {
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue ?? 0);
            string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";

            List<Producto> productos = productoNegocio.ConsultarStock(idCategoria, estado);

            dgvStock.DataSource = null;
            dgvStock.DataSource = productos;

            if (dgvStock.Columns["IdProducto"] != null) dgvStock.Columns["IdProducto"].Visible = false;
            if (dgvStock.Columns["IdCategoria"] != null) dgvStock.Columns["IdCategoria"].Visible = false;
            if (dgvStock.Columns["PrecioCaja"] != null) dgvStock.Columns["PrecioCaja"].Visible = false;
            if (dgvStock.Columns["Activo"] != null) dgvStock.Columns["Activo"].Visible = false;


        }
        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDgvStock();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDgvStock();
        }
    }
}

