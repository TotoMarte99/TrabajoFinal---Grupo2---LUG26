using System;
using System.Linq;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmCategorias : Form
    {
        private readonly CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        private Categoria? categoriaEnEdicion = null;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            Cargar();
            Limpiar();
        }

        private void Cargar()
        {
            var categorias = categoriaNegocio.ObtenerCategorias();

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = categorias;

            cmbCategoria.DataSource = null;
            cmbCategoria.DisplayMember = nameof(Categoria.Descripcion);
            cmbCategoria.ValueMember = nameof(Categoria.Id);
            cmbCategoria.DataSource = categorias.ToList();
        }

        private void Limpiar()
        {
            categoriaEnEdicion = null;
            txtDescripcion.Clear();
            grpDatos.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            categoriaEnEdicion = null;
            txtDescripcion.Clear();
            grpDatos.Enabled = true;
            txtDescripcion.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem is not Categoria seleccionada)
            {
                MessageBox.Show("Debe seleccionar una categoría para editar.", "Categoría",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            categoriaEnEdicion = seleccionada;
            txtDescripcion.Text = seleccionada.Descripcion;
            grpDatos.Enabled = true;
            txtDescripcion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = txtDescripcion.Text.Trim();

                if (categoriaEnEdicion == null)
                {
                    categoriaNegocio.AgregarCategoria(new Categoria { Descripcion = descripcion });
                    MessageBox.Show("Categoría agregada correctamente.", "Categoría",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    categoriaNegocio.EditarCategoria(new Categoria
                    {
                        Id = categoriaEnEdicion.Id,
                        Descripcion = descripcion
                    });
                    MessageBox.Show("Categoría editada correctamente.", "Categoría",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
