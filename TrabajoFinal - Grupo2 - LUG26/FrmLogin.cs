using System;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmLogin : Form
    {
        private const int MaximoIntentos = 3;

        private readonly UsuarioBLL usuarioBLL = new UsuarioBLL();
        private int intentos = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtClave.Text.Length == 0)
            {
                MessageBox.Show("Escriba su usuario y su contraseña.", "Ingreso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario? usuario;
            try
            {
                usuario = usuarioBLL.Login(txtUsuario.Text, txtClave.Text);
            }
            catch (Exception ex)
            {
                // Un error de conexión no cuenta como intento fallido
                MessageBox.Show("No se pudo consultar la base de datos." + Environment.NewLine + ex.Message,
                    "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario != null)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            intentos++;

            if (intentos >= MaximoIntentos)
            {
                MessageBox.Show("Superó los " + MaximoIntentos + " intentos. La aplicación se va a cerrar.",
                    "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            MessageBox.Show("Usuario o contraseña incorrectos. Le quedan " +
                            (MaximoIntentos - intentos) + " intento(s).",
                "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtClave.Clear();
            txtClave.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
