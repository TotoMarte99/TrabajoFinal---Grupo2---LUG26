namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuMaestros = new ToolStripMenuItem();
            mnuClientes = new ToolStripMenuItem();
            mnuProductos = new ToolStripMenuItem();
            mnuCategorias = new ToolStripMenuItem();
            mnuVentas = new ToolStripMenuItem();
            mnuNuevoPedido = new ToolStripMenuItem();
            mnuConsultaPedidos = new ToolStripMenuItem();
            mnuConsultas = new ToolStripMenuItem();
            mnuStock = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblEstado = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuMaestros, mnuVentas, mnuConsultas, mnuSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 1;
            // 
            // mnuMaestros
            // 
            mnuMaestros.DropDownItems.AddRange(new ToolStripItem[] { mnuClientes, mnuProductos, mnuCategorias });
            mnuMaestros.Name = "mnuMaestros";
            mnuMaestros.Size = new Size(67, 20);
            mnuMaestros.Text = "Maestros";
            // 
            // mnuClientes
            // 
            mnuClientes.Name = "mnuClientes";
            mnuClientes.Size = new Size(130, 22);
            mnuClientes.Text = "Clientes";
            mnuClientes.Click += mnuClientes_Click;
            // 
            // mnuProductos
            // 
            mnuProductos.Name = "mnuProductos";
            mnuProductos.Size = new Size(130, 22);
            mnuProductos.Text = "Productos";
            mnuProductos.Click += mnuProductos_Click;
            // 
            // mnuCategorias
            // 
            mnuCategorias.Name = "mnuCategorias";
            mnuCategorias.Size = new Size(130, 22);
            mnuCategorias.Text = "Categorías";
            mnuCategorias.Click += mnuCategorias_Click;
            // 
            // mnuVentas
            // 
            mnuVentas.DropDownItems.AddRange(new ToolStripItem[] { mnuNuevoPedido, mnuConsultaPedidos });
            mnuVentas.Name = "mnuVentas";
            mnuVentas.Size = new Size(53, 20);
            mnuVentas.Text = "Ventas";
            // 
            // mnuNuevoPedido
            // 
            mnuNuevoPedido.Name = "mnuNuevoPedido";
            mnuNuevoPedido.Size = new Size(182, 22);
            mnuNuevoPedido.Text = "Nuevo pedido";
            mnuNuevoPedido.Click += mnuNuevoPedido_Click;
            // 
            // mnuConsultaPedidos
            // 
            mnuConsultaPedidos.Name = "mnuConsultaPedidos";
            mnuConsultaPedidos.Size = new Size(182, 22);
            mnuConsultaPedidos.Text = "Consulta de pedidos";
            mnuConsultaPedidos.Click += mnuConsultaPedidos_Click;
            // 
            // mnuConsultas
            // 
            mnuConsultas.DropDownItems.AddRange(new ToolStripItem[] { mnuStock });
            mnuConsultas.Name = "mnuConsultas";
            mnuConsultas.Size = new Size(71, 20);
            mnuConsultas.Text = "Consultas";
            // 
            // mnuStock
            // 
            mnuStock.Name = "mnuStock";
            mnuStock.Size = new Size(103, 22);
            mnuStock.Text = "Stock";
            mnuStock.Click += mnuStock_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(41, 20);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEstado });
            statusStrip1.Location = new Point(0, 578);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 22);
            statusStrip1.TabIndex = 0;
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 17);
            // 
            // FrmPrincipal
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1000, 600);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Distribuidora Mayorista de Bebidas";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMaestros;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevoPedido;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultas;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}