using System;
using System.Windows.Forms;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            lblEstado.Text = "Administrador  ·  administrador      " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Abrir(Form f)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void mnuClientes_Click(object sender, EventArgs e) { Abrir(new FrmClientes()); }
        private void mnuProductos_Click(object sender, EventArgs e) { Abrir(new FrmProductos()); }
        private void mnuCategorias_Click(object sender, EventArgs e) { Abrir(new FrmCategorias()); }
        private void mnuNuevoPedido_Click(object sender, EventArgs e) { Abrir(new FrmConsultaPedidos()); }
        private void mnuConsultaPedidos_Click(object sender, EventArgs e) { Abrir(new FrmConsultaPedidos()); }
        private void mnuStock_Click(object sender, EventArgs e) { Abrir(new FrmConsultaStock()); }
        private void mnuSalir_Click(object sender, EventArgs e) { Close(); }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {

        }
    }
}