using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmCategoria : Form
    {
        private readonly CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        public FrmCategoria()
        {
            InitializeComponent();

            Load += FrmCategoria_Load;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click;
            categoriaNegocio.CategoriaAgregada += (s, c) => CargarCategorias();
        }

        private void FrmCategoria_Load(object? sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            cmbCategorias.DataSource = null;
            cmbCategorias.DisplayMember = nameof(Categoria.Descripcion);
            cmbCategorias.ValueMember = nameof(Categoria.Id);
            cmbCategorias.DataSource = categoriaNegocio.ObtenerCategorias();
        }

        private void btnGuardarCategoria_Click(object? sender, EventArgs e)
        {
           
        }

        private void btnGuardarCategoria_Click_1(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una categoría y que se haya ingresado una nueva descripción
            try
            {
                if (cmbCategorias.SelectedItem == null)
                {
                    throw new Exception("Debe seleccionar una categoría para editar.");
                }
                categoriaNegocio.EditarCategoria(new Categoria { Id = (int)cmbCategorias.SelectedValue, Descripcion = txtEditarNombreCategoria.Text.Trim() });
                txtEditarNombreCategoria.Clear();
                MessageBox.Show("Categoría editada correctamente.", "Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                categoriaNegocio.AgregarCategoria(new Categoria
                {
                    Descripcion = txtCategoriaNueva.Text.Trim()
                });
                MessageBox.Show("Categoría agregada correctamente.", "Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();
                txtCategoriaNueva.Clear();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
