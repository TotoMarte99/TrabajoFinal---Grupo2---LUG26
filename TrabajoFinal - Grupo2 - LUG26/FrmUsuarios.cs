using System;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    // ABM de usuarios. Solo lo abre el administrador (y la capa Negocio lo vuelve a controlar).
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioBLL usuarioBLL = new UsuarioBLL();

        private Usuario? usuarioEnEdicion = null;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add(Sesion.RolVendedor);
            cmbRol.Items.Add(Sesion.RolAdministrador);

            try
            {
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void Cargar()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarioBLL.ObtenerTodos();

            // El hash de la contraseña no se muestra
            if (dgvUsuarios.Columns.Contains(nameof(Usuario.Contrasena)))
                dgvUsuarios.Columns[nameof(Usuario.Contrasena)].Visible = false;
            if (dgvUsuarios.Columns.Contains(nameof(Usuario.NombreUsuario)))
                dgvUsuarios.Columns[nameof(Usuario.NombreUsuario)].HeaderText = "Usuario";
            if (dgvUsuarios.Columns.Contains(nameof(Usuario.NombreCompleto)))
                dgvUsuarios.Columns[nameof(Usuario.NombreCompleto)].HeaderText = "Nombre completo";
        }

        private void Limpiar()
        {
            usuarioEnEdicion = null;
            txtNombreUsuario.Clear();
            txtNombreCompleto.Clear();
            txtClave.Clear();
            cmbRol.SelectedIndex = -1;
            chkActivo.Checked = true;
            lblAyudaClave.Text = "";
            grpDatos.Enabled = false;
        }

        private Usuario? UsuarioSeleccionado()
        {
            if (dgvUsuarios.CurrentRow == null) return null;
            return dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbRol.SelectedItem = Sesion.RolVendedor;
            lblAyudaClave.Text = "Mínimo 6 caracteres.";
            grpDatos.Enabled = true;
            txtNombreUsuario.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario? seleccionado = UsuarioSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuarioEnEdicion = seleccionado;
            txtNombreUsuario.Text = seleccionado.NombreUsuario;
            txtNombreCompleto.Text = seleccionado.NombreCompleto;
            cmbRol.SelectedItem = seleccionado.Rol;
            chkActivo.Checked = seleccionado.Activo;
            txtClave.Clear();
            lblAyudaClave.Text = "Déjela vacía para no cambiarla.";
            grpDatos.Enabled = true;
            txtNombreUsuario.Focus();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Usuario? seleccionado = UsuarioSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!seleccionado.Activo)
            {
                MessageBox.Show("El usuario ya está dado de baja.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmar = MessageBox.Show(
                "¿Dar de baja al usuario '" + seleccionado.NombreUsuario + "'?",
                "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                usuarioBLL.BajaLogica(seleccionado.Id);
                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario
                {
                    Id = usuarioEnEdicion?.Id ?? 0,
                    NombreUsuario = txtNombreUsuario.Text,
                    NombreCompleto = txtNombreCompleto.Text,
                    Rol = cmbRol.SelectedItem?.ToString() ?? "",
                    Activo = chkActivo.Checked
                };

                if (usuarioEnEdicion == null)
                {
                    usuarioBLL.Insertar(usuario, txtClave.Text);
                    MessageBox.Show("Usuario agregado correctamente.", "Usuarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    usuarioBLL.Modificar(usuario, txtClave.Text);
                    MessageBox.Show("Usuario modificado correctamente.", "Usuarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
