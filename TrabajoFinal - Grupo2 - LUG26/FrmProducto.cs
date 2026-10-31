using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabajoFinal___Grupo2___LUG26
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmCargarProducto frmCargarProducto = new FrmCargarProducto();
            frmCargarProducto.ShowDialog();
            Refresh();
        }
    }
}
