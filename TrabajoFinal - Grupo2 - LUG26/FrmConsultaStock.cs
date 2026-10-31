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
        
        List<Categoria> categorias;

        public FrmConsultaStock()
        {
            InitializeComponent();
        }

        private void FrmConsultaStock_Load(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            

            
        }
    }
}

