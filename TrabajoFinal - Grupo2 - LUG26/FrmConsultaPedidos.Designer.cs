namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmConsultaPedidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPedidos = new DataGridView();
            pnlTop = new Panel();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeight = 29;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Location = new Point(0, 85);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(780, 395);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.CellDoubleClick += dgvPedidos_CellDoubleClick;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblCliente);
            pnlTop.Controls.Add(cmbCliente);
            pnlTop.Controls.Add(lblEstado);
            pnlTop.Controls.Add(cmbEstado);
            pnlTop.Controls.Add(lblDesde);
            pnlTop.Controls.Add(dtpDesde);
            pnlTop.Controls.Add(lblHasta);
            pnlTop.Controls.Add(dtpHasta);
            pnlTop.Controls.Add(btnBuscar);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(780, 85);
            pnlTop.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(10, 15);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.DisplayMember = "RazonSocial";
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Location = new Point(65, 12);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(250, 28);
            cmbCliente.TabIndex = 1;
            cmbCliente.ValueMember = "Id";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(335, 15);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.AddRange(new object[] { "(Todos)", "confirmado", "anulado" });
            cmbEstado.Location = new Point(398, 11);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(120, 28);
            cmbEstado.TabIndex = 3;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(10, 53);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(54, 20);
            lblDesde.TabIndex = 4;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(65, 49);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(130, 27);
            dtpDesde.TabIndex = 5;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(215, 53);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(50, 20);
            lblHasta.TabIndex = 6;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(265, 49);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(130, 27);
            dtpHasta.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(428, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 28);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmConsultaPedidos
            // 
            ClientSize = new Size(780, 480);
            Controls.Add(dgvPedidos);
            Controls.Add(pnlTop);
            Name = "FrmConsultaPedidos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Consulta de pedidos";
            Load += FrmConsultaPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscar;
    }
}
