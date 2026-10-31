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
            dgvStock = new System.Windows.Forms.DataGridView();
            pnlTop = new System.Windows.Forms.Panel();
            lblEstado = new System.Windows.Forms.Label();
            cmbEstado = new System.Windows.Forms.ComboBox();
            btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgvStock)).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersVisible = false;
            dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblEstado);
            pnlTop.Controls.Add(cmbEstado);
            pnlTop.Controls.Add(btnActualizar);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(720, 46);
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new System.Drawing.Point(10, 17);
            lblEstado.Name = "lblEstado";
            lblEstado.Text = "Mostrar:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEstado.Items.AddRange(new object[] { "Todos", "Solo los que hay que reponer", "Solo los que tienen stock" });
            cmbEstado.Location = new System.Drawing.Point(65, 13);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.SelectedIndex = 0;
            cmbEstado.Size = new System.Drawing.Size(210, 21);
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new System.Drawing.Point(295, 9);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(90, 28);
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += new System.EventHandler(btnActualizar_Click);
            // 
            // FrmConsultaStock
            // 
            ClientSize = new System.Drawing.Size(720, 460);
            Controls.Add(dgvStock);
            Controls.Add(pnlTop);
            Name = "FrmConsultaStock";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Consulta de stock";
            Load += new System.EventHandler(FrmConsultaStock_Load);
            ((System.ComponentModel.ISupportInitialize)(dgvStock)).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnActualizar;
    }
}
