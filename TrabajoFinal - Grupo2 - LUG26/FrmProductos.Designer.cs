namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            pnlTop = new Panel();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            btnEditar = new Button();
            btnBaja = new Button();
            btnNuevo = new Button();
            grpDatos = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblPrecio = new Label();
            nudPrecio = new NumericUpDown();
            lblStock = new Label();
            nudStock = new NumericUpDown();
            lblMinimo = new Label();
            nudMinimo = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            pnlTop.SuspendLayout();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinimo).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeight = 29;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(0, 46);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(760, 304);
            dgvProductos.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblProducto);
            pnlTop.Controls.Add(cmbProducto);
            pnlTop.Controls.Add(btnEditar);
            pnlTop.Controls.Add(btnBaja);
            pnlTop.Controls.Add(btnNuevo);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(760, 46);
            pnlTop.TabIndex = 2;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(10, 17);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Location = new Point(75, 13);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(230, 28);
            cmbProducto.TabIndex = 1;
            cmbProducto.ValueMember = "Id";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(320, 9);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 28);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(415, 9);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(100, 28);
            btnBaja.TabIndex = 3;
            btnBaja.Text = "Dar de baja";
            btnBaja.Click += btnBaja_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(665, 9);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(85, 28);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblCategoria);
            grpDatos.Controls.Add(cmbCategoria);
            grpDatos.Controls.Add(lblPrecio);
            grpDatos.Controls.Add(nudPrecio);
            grpDatos.Controls.Add(lblStock);
            grpDatos.Controls.Add(nudStock);
            grpDatos.Controls.Add(lblMinimo);
            grpDatos.Controls.Add(nudMinimo);
            grpDatos.Controls.Add(btnGuardar);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Dock = DockStyle.Bottom;
            grpDatos.Location = new Point(0, 350);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(760, 150);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del producto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(400, 28);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(475, 25);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(200, 28);
            cmbCategoria.TabIndex = 3;
            cmbCategoria.ValueMember = "Id";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(15, 68);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(111, 20);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio por caja:";
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Location = new Point(120, 65);
            nudPrecio.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(110, 27);
            nudPrecio.TabIndex = 5;
            nudPrecio.ThousandsSeparator = true;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(250, 68);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(95, 20);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock (cajas):";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(351, 65);
            nudStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(80, 27);
            nudStock.TabIndex = 7;
            // 
            // lblMinimo
            // 
            lblMinimo.AutoSize = true;
            lblMinimo.Location = new Point(446, 68);
            lblMinimo.Name = "lblMinimo";
            lblMinimo.Size = new Size(103, 20);
            lblMinimo.TabIndex = 8;
            lblMinimo.Text = "Stock mínimo:";
            // 
            // nudMinimo
            // 
            nudMinimo.Location = new Point(555, 65);
            nudMinimo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMinimo.Name = "nudMinimo";
            nudMinimo.Size = new Size(80, 27);
            nudMinimo.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(495, 105);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 28);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(590, 105);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 28);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmProductos
            // 
            ClientSize = new Size(760, 500);
            Controls.Add(dgvProductos);
            Controls.Add(grpDatos);
            Controls.Add(pnlTop);
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Productos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinimo).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.NumericUpDown nudMinimo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
