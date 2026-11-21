using System;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            AplicarPermisos();
        }

        // El vendedor ve clientes, pedidos y consultas.
        // El administrador ve además productos, categorías y usuarios.
        // Esconder el menú es solo comodidad: el control real está en la capa Negocio (RN-11).
        private void AplicarPermisos()
        {
            Usuario? usuario = Sesion.UsuarioActual;
            bool esAdministrador = Sesion.EsAdministrador;

            mnuProductos.Visible = esAdministrador;
            mnuCategorias.Visible = esAdministrador;
            mnuUsuarios.Visible = esAdministrador;

            string nombre = usuario != null ? usuario.NombreCompleto : "Sin usuario";
            string rol = usuario != null ? usuario.Rol : "-";
            lblEstado.Text = nombre + "  ·  " + rol + "      " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Abrir(Form f)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void mnuClientes_Click(object sender, EventArgs e) { Abrir(new FrmClientes()); }
        private void mnuProductos_Click(object sender, EventArgs e) { Abrir(new FrmProductos()); }
        private void mnuCategorias_Click(object sender, EventArgs e) { Abrir(new FrmCategorias()); }
        private void mnuUsuarios_Click(object sender, EventArgs e) { Abrir(new FrmUsuarios()); }
        private void mnuNuevoPedido_Click(object sender, EventArgs e) { Abrir(new FrmPedido()); }
        private void mnuConsultaPedidos_Click(object sender, EventArgs e) { Abrir(new FrmConsultaPedidos()); }
        private void mnuStock_Click(object sender, EventArgs e) { Abrir(new FrmConsultaStock()); }
        private void mnuSalir_Click(object sender, EventArgs e) { Close(); }
    }
}
