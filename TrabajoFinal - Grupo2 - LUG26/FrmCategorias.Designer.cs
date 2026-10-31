namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmCategorias
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvCategorias = new System.Windows.Forms.DataGridView();
            pnlTop = new System.Windows.Forms.Panel();
            lblCategoria = new System.Windows.Forms.Label();
            cmbCategoria = new System.Windows.Forms.ComboBox();
            btnEditar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            grpDatos = new System.Windows.Forms.GroupBox();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgvCategorias)).BeginInit();
            pnlTop.SuspendLayout();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblCategoria);
            pnlTop.Controls.Add(cmbCategoria);
            pnlTop.Controls.Add(btnEditar);
            pnlTop.Controls.Add(btnNuevo);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(480, 46);
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new System.Drawing.Point(10, 17);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new System.Drawing.Point(80, 13);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new System.Drawing.Size(200, 21);
            cmbCategoria.ValueMember = "Id";
            // 
            // btnEditar
            // 
            btnEditar.Location = new System.Drawing.Point(295, 9);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(85, 28);
            btnEditar.Text = "Editar";
            btnEditar.Click += new System.EventHandler(btnEditar_Click);
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(385, 9);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(85, 28);
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += new System.EventHandler(btnNuevo_Click);
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblDescripcion);
            grpDatos.Controls.Add(txtDescripcion);
            grpDatos.Controls.Add(btnGuardar);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new System.Drawing.Size(480, 105);
            grpDatos.Text = "Datos de la categoría";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(15, 28);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(100, 25);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(250, 20);
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(270, 60);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(85, 28);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += new System.EventHandler(btnGuardar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(365, 60);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(85, 28);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += new System.EventHandler(btnCancelar_Click);
            // 
            // FrmCategorias
            // 
            ClientSize = new System.Drawing.Size(480, 400);
            Controls.Add(dgvCategorias);
            Controls.Add(grpDatos);
            Controls.Add(pnlTop);
            Name = "FrmCategorias";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Categorías";
            Load += new System.EventHandler(FrmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(dgvCategorias)).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}