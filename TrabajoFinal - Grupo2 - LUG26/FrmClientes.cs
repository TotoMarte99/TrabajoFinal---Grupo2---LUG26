using System;
using System.Linq;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmClientes : Form
    {
        
        

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            
            
            Cargar();
        }

        
        private void Cargar()
        {
            try
            {
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Limpiar()
        {
            
            txtRazon.Clear();
            txtCuit.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtRazon.Focus();
        }

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbCuit.SelectedValue == null)
            {
                MessageBox.Show("Elegí un CUIT.");
                return;
            }

            try
            {
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        
        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
