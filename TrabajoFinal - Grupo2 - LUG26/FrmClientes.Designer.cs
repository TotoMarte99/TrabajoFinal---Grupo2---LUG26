namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmClientes
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
            label1 = new Label();
            txtRazonSocial = new TextBox();
            btnValidarCliente = new Button();
            label2 = new Label();
            txtCUIT = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            chkActivo = new CheckBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnDesactivar = new Button();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            label7 = new Label();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Razon Social";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(37, 58);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(125, 27);
            txtRazonSocial.TabIndex = 1;
            // 
            // btnValidarCliente
            // 
            btnValidarCliente.Location = new Point(433, 33);
            btnValidarCliente.Name = "btnValidarCliente";
            btnValidarCliente.Size = new Size(119, 33);
            btnValidarCliente.TabIndex = 2;
            btnValidarCliente.Text = "Validar Cliente";
            btnValidarCliente.UseVisualStyleBackColor = true;
            btnValidarCliente.Click += btnValidarCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 22);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "CUIT";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(230, 58);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(125, 27);
            txtCUIT.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 103);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(37, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 103);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(230, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 191);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(37, 233);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 191);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(230, 233);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 12;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(37, 290);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 13;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(37, 331);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(119, 33);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(195, 331);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 33);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(354, 331);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(119, 33);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Location = new Point(508, 331);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(119, 33);
            btnDesactivar.TabIndex = 17;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += btnDesactivar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(679, 331);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 33);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(31, 431);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(355, 27);
            txtBuscar.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 385);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 20;
            label7.Text = "Buscar Cliente";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(31, 480);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(863, 188);
            dgvClientes.TabIndex = 21;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(dgvClientes);
            Controls.Add(label7);
            Controls.Add(txtBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDesactivar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(chkActivo);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtCUIT);
            Controls.Add(label2);
            Controls.Add(btnValidarCliente);
            Controls.Add(txtRazonSocial);
            Controls.Add(label1);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRazonSocial;
        private Button btnValidarCliente;
        private Label label2;
        private TextBox txtCUIT;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtDireccion;
        private CheckBox chkActivo;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnDesactivar;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private Label label7;
        private DataGridView dgvClientes;
    }
}
