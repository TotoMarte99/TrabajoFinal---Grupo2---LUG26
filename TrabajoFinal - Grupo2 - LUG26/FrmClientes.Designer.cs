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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblBuscarCuit = new System.Windows.Forms.Label();
            this.cmbCuit = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblRazon = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblBuscarCuit);
            this.pnlTop.Controls.Add(this.cmbCuit);
            this.pnlTop.Controls.Add(this.btnEditar);
            this.pnlTop.Controls.Add(this.btnBaja);
            this.pnlTop.Controls.Add(this.btnNuevo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(720, 46);
            // 
            // lblBuscarCuit
            // 
            this.lblBuscarCuit.AutoSize = true;
            this.lblBuscarCuit.Location = new System.Drawing.Point(10, 17);
            this.lblBuscarCuit.Name = "lblBuscarCuit";
            this.lblBuscarCuit.Text = "CUIT:";
            // 
            // cmbCuit
            // 
            this.cmbCuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuit.Location = new System.Drawing.Point(55, 13);
            this.cmbCuit.Name = "cmbCuit";
            this.cmbCuit.Size = new System.Drawing.Size(180, 21);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(250, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 28);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(345, 9);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(100, 28);
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(625, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 28);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblRazon);
            this.grpDatos.Controls.Add(this.txtRazon);
            this.grpDatos.Controls.Add(this.lblCuit);
            this.grpDatos.Controls.Add(this.txtCuit);
            this.grpDatos.Controls.Add(this.lblTelefono);
            this.grpDatos.Controls.Add(this.txtTelefono);
            this.grpDatos.Controls.Add(this.lblDireccion);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(720, 145);
            this.grpDatos.Text = "Datos del cliente";
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.Location = new System.Drawing.Point(15, 28);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Text = "Razón social:";
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(110, 25);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(260, 20);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(390, 28);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Text = "CUIT:";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(435, 25);
            this.txtCuit.MaxLength = 13;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(150, 20);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(15, 63);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(110, 60);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 20);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(290, 63);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(360, 60);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(225, 20);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(400, 100);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 28);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(495, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 28);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmClientes
            // 
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBuscarCuit;
        private System.Windows.Forms.ComboBox cmbCuit;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

