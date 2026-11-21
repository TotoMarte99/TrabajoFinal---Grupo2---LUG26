namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvUsuarios = new DataGridView();
            pnlTop = new Panel();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnBaja = new Button();
            grpDatos = new GroupBox();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblNombreCompleto = new Label();
            txtNombreCompleto = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            lblClave = new Label();
            txtClave = new TextBox();
            lblAyudaClave = new Label();
            chkActivo = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pnlTop.SuspendLayout();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeight = 29;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 190);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(760, 270);
            dgvUsuarios.TabIndex = 1;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnNuevo);
            pnlTop.Controls.Add(btnEditar);
            pnlTop.Controls.Add(btnBaja);
            pnlTop.Controls.Add(grpDatos);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(760, 190);
            pnlTop.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 28);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(108, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 28);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(204, 12);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(100, 28);
            btnBaja.TabIndex = 2;
            btnBaja.Text = "Dar de baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblNombreUsuario);
            grpDatos.Controls.Add(txtNombreUsuario);
            grpDatos.Controls.Add(lblNombreCompleto);
            grpDatos.Controls.Add(txtNombreCompleto);
            grpDatos.Controls.Add(lblRol);
            grpDatos.Controls.Add(cmbRol);
            grpDatos.Controls.Add(lblClave);
            grpDatos.Controls.Add(txtClave);
            grpDatos.Controls.Add(lblAyudaClave);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(btnGuardar);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Location = new Point(12, 48);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(736, 132);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del usuario";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(12, 28);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(50, 15);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Usuario:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(120, 25);
            txtNombreUsuario.MaxLength = 50;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(200, 23);
            txtNombreUsuario.TabIndex = 1;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(350, 28);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(108, 15);
            lblNombreCompleto.TabIndex = 2;
            lblNombreCompleto.Text = "Nombre completo:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(470, 25);
            txtNombreCompleto.MaxLength = 100;
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(250, 23);
            txtNombreCompleto.TabIndex = 3;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(12, 62);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 4;
            lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Location = new Point(120, 59);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(200, 23);
            cmbRol.TabIndex = 5;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(350, 62);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(70, 15);
            lblClave.TabIndex = 6;
            lblClave.Text = "Contraseña:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(470, 59);
            txtClave.MaxLength = 50;
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(250, 23);
            txtClave.TabIndex = 7;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblAyudaClave
            // 
            lblAyudaClave.AutoSize = true;
            lblAyudaClave.ForeColor = SystemColors.GrayText;
            lblAyudaClave.Location = new Point(470, 85);
            lblAyudaClave.Name = "lblAyudaClave";
            lblAyudaClave.Size = new Size(0, 15);
            lblAyudaClave.TabIndex = 8;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(120, 96);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 9;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(534, 96);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 28);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(630, 96);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 28);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmUsuarios
            // 
            ClientSize = new Size(760, 460);
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlTop);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            pnlTop.ResumeLayout(false);
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblAyudaClave;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
