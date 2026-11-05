namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmConsultaStock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvStock = new DataGridView();
            pnlTop = new Panel();
            label1 = new Label();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            cmbEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ColumnHeadersHeight = 34;
            dgvStock.Dock = DockStyle.Fill;
            dgvStock.Location = new Point(0, 146);
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersVisible = false;
            dgvStock.RowHeadersWidth = 62;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(862, 544);
            dgvStock.TabIndex = 0;
            dgvStock.CellContentClick += dgvStock_CellContentClick;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(lblCategoria);
            pnlTop.Controls.Add(cmbCategoria);
            pnlTop.Controls.Add(cmbEstado);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(862, 146);
            pnlTop.TabIndex = 1;
            pnlTop.Paint += pnlTop_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 43);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 5;
            label1.Text = "Estado:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(451, 46);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(92, 25);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(544, 43);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(210, 33);
            cmbCategoria.TabIndex = 3;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(161, 40);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(210, 33);
            cmbEstado.TabIndex = 1;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // FrmConsultaStock
            // 
            ClientSize = new Size(862, 690);
            Controls.Add(dgvStock);
            Controls.Add(pnlTop);
            Name = "FrmConsultaStock";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Consulta de stock";
            Load += FrmConsultaStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cmbEstado;
        private ComboBox cmbCategoria;
        private Label label1;
        private Label lblCategoria;
    }
}
