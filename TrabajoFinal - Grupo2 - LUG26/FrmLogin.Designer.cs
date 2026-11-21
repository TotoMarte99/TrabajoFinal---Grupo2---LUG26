namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblClave = new Label();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Distribuidora Mayorista de Bebidas";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(22, 62);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(110, 59);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(190, 23);
            txtUsuario.TabIndex = 2;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(22, 97);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(70, 15);
            lblClave.TabIndex = 3;
            lblClave.Text = "Contraseña:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(110, 94);
            txtClave.MaxLength = 50;
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(190, 23);
            txtClave.TabIndex = 4;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(110, 135);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(90, 28);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(210, 135);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 28);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmLogin
            // 
            AcceptButton = btnIngresar;
            ClientSize = new Size(324, 181);
            Controls.Add(lblTitulo);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblClave);
            Controls.Add(txtClave);
            Controls.Add(btnIngresar);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso al sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
    }
}
