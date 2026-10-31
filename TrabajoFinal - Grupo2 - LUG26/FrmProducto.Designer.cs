namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Buscar = new Label();
            txtBuscar = new TextBox();
            label1 = new Label();
            cbtFiltroCategoria = new ComboBox();
            label2 = new Label();
            cbFiltroEstado = new ComboBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            dgvProductos = new DataGridView();
            btnNuevoProducto = new Button();
            btnEditarProducto = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // Buscar
            // 
            Buscar.AutoSize = true;
            Buscar.Location = new Point(12, 16);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(42, 15);
            Buscar.TabIndex = 0;
            Buscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 34);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(147, 23);
            txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 16);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Categoria";
            // 
            // cbtFiltroCategoria
            // 
            cbtFiltroCategoria.FormattingEnabled = true;
            cbtFiltroCategoria.Location = new Point(193, 34);
            cbtFiltroCategoria.Name = "cbtFiltroCategoria";
            cbtFiltroCategoria.Size = new Size(169, 23);
            cbtFiltroCategoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 16);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Estado";
            // 
            // cbFiltroEstado
            // 
            cbFiltroEstado.FormattingEnabled = true;
            cbFiltroEstado.Location = new Point(417, 34);
            cbFiltroEstado.Name = "cbFiltroEstado";
            cbFiltroEstado.Size = new Size(169, 23);
            cbFiltroEstado.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(634, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(104, 31);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(760, 26);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 34);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(11, 72);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(1054, 340);
            dgvProductos.TabIndex = 8;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(12, 432);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(104, 31);
            btnNuevoProducto.TabIndex = 9;
            btnNuevoProducto.Text = "Nuevo";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(131, 432);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(104, 31);
            btnEditarProducto.TabIndex = 10;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(258, 432);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 31);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 475);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnNuevoProducto);
            Controls.Add(dgvProductos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(cbFiltroEstado);
            Controls.Add(label2);
            Controls.Add(cbtFiltroCategoria);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(Buscar);
            Name = "FrmProducto";
            Text = "FrmProducto";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Buscar;
        private TextBox txtBuscar;
        private Label label1;
        private ComboBox cbtFiltroCategoria;
        private Label label2;
        private ComboBox cbFiltroEstado;
        private Button btnBuscar;
        private Button btnLimpiar;
        private DataGridView dgvProductos;
        private Button btnNuevoProducto;
        private Button btnEditarProducto;
        private Button btnEliminar;
    }
}