namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            grpAlta = new GroupBox();
            lblRazon = new Label();
            txtRazon = new TextBox();
            lblCuit = new Label();
            txtCuit = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            grpBaja = new GroupBox();
            lblCuitBaja = new Label();
            cmbCuitBaja = new ComboBox();
            btnBaja = new Button();
            grpEditar = new GroupBox();
            lblCuitEditar = new Label();
            cmbCuitEditar = new ComboBox();
            lblTelefonoEditar = new Label();
            txtTelefonoEditar = new TextBox();
            lblDireccionEditar = new Label();
            txtDireccionEditar = new TextBox();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grpAlta.SuspendLayout();
            grpBaja.SuspendLayout();
            grpEditar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeight = 29;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(0, 0);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(860, 314);
            dgvClientes.TabIndex = 0;
            // 
            // grpAlta
            // 
            grpAlta.Controls.Add(lblRazon);
            grpAlta.Controls.Add(txtRazon);
            grpAlta.Controls.Add(lblCuit);
            grpAlta.Controls.Add(txtCuit);
            grpAlta.Controls.Add(lblTelefono);
            grpAlta.Controls.Add(txtTelefono);
            grpAlta.Controls.Add(lblDireccion);
            grpAlta.Controls.Add(txtDireccion);
            grpAlta.Controls.Add(btnNuevo);
            grpAlta.Controls.Add(btnGuardar);
            grpAlta.Controls.Add(btnCancelar);
            grpAlta.Dock = DockStyle.Bottom;
            grpAlta.Location = new Point(0, 314);
            grpAlta.Name = "grpAlta";
            grpAlta.Size = new Size(860, 140);
            grpAlta.TabIndex = 1;
            grpAlta.TabStop = false;
            grpAlta.Text = "Datos del cliente";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(15, 30);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(95, 20);
            lblRazon.TabIndex = 0;
            lblRazon.Text = "Razón social:";
            // 
            // txtRazon
            // 
            txtRazon.Location = new Point(110, 27);
            txtRazon.Name = "txtRazon";
            txtRazon.Size = new Size(300, 27);
            txtRazon.TabIndex = 1;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(440, 30);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(43, 20);
            lblCuit.TabIndex = 2;
            lblCuit.Text = "CUIT:";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(485, 27);
            txtCuit.MaxLength = 13;
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(170, 27);
            txtCuit.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(15, 65);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(110, 62);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(170, 27);
            txtTelefono.TabIndex = 5;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(310, 65);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(385, 62);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(270, 27);
            txtDireccion.TabIndex = 7;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(385, 100);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(85, 28);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(480, 100);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 28);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(575, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 28);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // grpBaja
            // 
            grpBaja.Controls.Add(lblCuitBaja);
            grpBaja.Controls.Add(cmbCuitBaja);
            grpBaja.Controls.Add(btnBaja);
            grpBaja.Dock = DockStyle.Bottom;
            grpBaja.Location = new Point(0, 454);
            grpBaja.Name = "grpBaja";
            grpBaja.Size = new Size(860, 70);
            grpBaja.TabIndex = 2;
            grpBaja.TabStop = false;
            grpBaja.Text = "Dar de baja un cliente";
            // 
            // lblCuitBaja
            // 
            lblCuitBaja.AutoSize = true;
            lblCuitBaja.Location = new Point(15, 33);
            lblCuitBaja.Name = "lblCuitBaja";
            lblCuitBaja.Size = new Size(43, 20);
            lblCuitBaja.TabIndex = 0;
            lblCuitBaja.Text = "CUIT:";
            // 
            // cmbCuitBaja
            // 
            cmbCuitBaja.DisplayMember = "Cuit";
            cmbCuitBaja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCuitBaja.Location = new Point(60, 30);
            cmbCuitBaja.Name = "cmbCuitBaja";
            cmbCuitBaja.Size = new Size(200, 28);
            cmbCuitBaja.TabIndex = 1;
            cmbCuitBaja.ValueMember = "Id";
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(280, 27);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(100, 28);
            btnBaja.TabIndex = 2;
            btnBaja.Text = "Dar de baja";
            btnBaja.Click += btnBaja_Click;
            // 
            // grpEditar
            // 
            grpEditar.Controls.Add(lblCuitEditar);
            grpEditar.Controls.Add(cmbCuitEditar);
            grpEditar.Controls.Add(lblTelefonoEditar);
            grpEditar.Controls.Add(txtTelefonoEditar);
            grpEditar.Controls.Add(lblDireccionEditar);
            grpEditar.Controls.Add(txtDireccionEditar);
            grpEditar.Controls.Add(btnEditar);
            grpEditar.Dock = DockStyle.Bottom;
            grpEditar.Location = new Point(0, 524);
            grpEditar.Name = "grpEditar";
            grpEditar.Size = new Size(860, 116);
            grpEditar.TabIndex = 3;
            grpEditar.TabStop = false;
            grpEditar.Text = "Actualizar datos del cliente";
            // 
            // lblCuitEditar
            // 
            lblCuitEditar.AutoSize = true;
            lblCuitEditar.Location = new Point(15, 33);
            lblCuitEditar.Name = "lblCuitEditar";
            lblCuitEditar.Size = new Size(43, 20);
            lblCuitEditar.TabIndex = 0;
            lblCuitEditar.Text = "CUIT:";
            // 
            // cmbCuitEditar
            // 
            cmbCuitEditar.DisplayMember = "Cuit";
            cmbCuitEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCuitEditar.Location = new Point(60, 30);
            cmbCuitEditar.Name = "cmbCuitEditar";
            cmbCuitEditar.Size = new Size(200, 28);
            cmbCuitEditar.TabIndex = 1;
            cmbCuitEditar.ValueMember = "Id";
            cmbCuitEditar.SelectedIndexChanged += cmbCuitEditar_SelectedIndexChanged;
            // 
            // lblTelefonoEditar
            // 
            lblTelefonoEditar.AutoSize = true;
            lblTelefonoEditar.Location = new Point(290, 33);
            lblTelefonoEditar.Name = "lblTelefonoEditar";
            lblTelefonoEditar.Size = new Size(70, 20);
            lblTelefonoEditar.TabIndex = 2;
            lblTelefonoEditar.Text = "Teléfono:";
            // 
            // txtTelefonoEditar
            // 
            txtTelefonoEditar.Location = new Point(365, 30);
            txtTelefonoEditar.Name = "txtTelefonoEditar";
            txtTelefonoEditar.Size = new Size(150, 27);
            txtTelefonoEditar.TabIndex = 3;
            // 
            // lblDireccionEditar
            // 
            lblDireccionEditar.AutoSize = true;
            lblDireccionEditar.Location = new Point(540, 33);
            lblDireccionEditar.Name = "lblDireccionEditar";
            lblDireccionEditar.Size = new Size(75, 20);
            lblDireccionEditar.TabIndex = 4;
            lblDireccionEditar.Text = "Dirección:";
            // 
            // txtDireccionEditar
            // 
            txtDireccionEditar.Location = new Point(620, 30);
            txtDireccionEditar.Name = "txtDireccionEditar";
            txtDireccionEditar.Size = new Size(215, 27);
            txtDireccionEditar.TabIndex = 5;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(735, 70);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 28);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Actualizar";
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmClientes
            // 
            ClientSize = new Size(860, 640);
            Controls.Add(dgvClientes);
            Controls.Add(grpAlta);
            Controls.Add(grpBaja);
            Controls.Add(grpEditar);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grpAlta.ResumeLayout(false);
            grpAlta.PerformLayout();
            grpBaja.ResumeLayout(false);
            grpBaja.PerformLayout();
            grpEditar.ResumeLayout(false);
            grpEditar.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox grpAlta;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpBaja;
        private System.Windows.Forms.Label lblCuitBaja;
        private System.Windows.Forms.ComboBox cmbCuitBaja;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.GroupBox grpEditar;
        private System.Windows.Forms.Label lblCuitEditar;
        private System.Windows.Forms.ComboBox cmbCuitEditar;
        private System.Windows.Forms.Label lblTelefonoEditar;
        private System.Windows.Forms.TextBox txtTelefonoEditar;
        private System.Windows.Forms.Label lblDireccionEditar;
        private System.Windows.Forms.TextBox txtDireccionEditar;
        private System.Windows.Forms.Button btnEditar;
    }
}
