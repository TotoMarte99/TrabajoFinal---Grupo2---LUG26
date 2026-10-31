namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmCategoria
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
            txtCategoriaNueva = new TextBox();
            grupoCategoriaNueva = new GroupBox();
            button1 = new Button();
            grupoCategoriaExistente = new GroupBox();
            btnGuardarCategoria = new Button();
            txtEditarNombreCategoria = new TextBox();
            cmbCategorias = new ComboBox();
            label2 = new Label();
            grupoCategoriaNueva.SuspendLayout();
            grupoCategoriaExistente.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtCategoriaNueva
            // 
            txtCategoriaNueva.Location = new Point(16, 56);
            txtCategoriaNueva.Name = "txtCategoriaNueva";
            txtCategoriaNueva.Size = new Size(195, 23);
            txtCategoriaNueva.TabIndex = 1;
            // 
            // grupoCategoriaNueva
            // 
            grupoCategoriaNueva.Controls.Add(button1);
            grupoCategoriaNueva.Controls.Add(label1);
            grupoCategoriaNueva.Controls.Add(txtCategoriaNueva);
            grupoCategoriaNueva.Location = new Point(12, 12);
            grupoCategoriaNueva.Name = "grupoCategoriaNueva";
            grupoCategoriaNueva.Size = new Size(277, 136);
            grupoCategoriaNueva.TabIndex = 2;
            grupoCategoriaNueva.TabStop = false;
            grupoCategoriaNueva.Text = "Categoria Nueva";
            // 
            // button1
            // 
            button1.Location = new Point(16, 85);
            button1.Name = "button1";
            button1.Size = new Size(78, 31);
            button1.TabIndex = 5;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grupoCategoriaExistente
            // 
            grupoCategoriaExistente.Controls.Add(btnGuardarCategoria);
            grupoCategoriaExistente.Controls.Add(txtEditarNombreCategoria);
            grupoCategoriaExistente.Controls.Add(cmbCategorias);
            grupoCategoriaExistente.Controls.Add(label2);
            grupoCategoriaExistente.Location = new Point(12, 180);
            grupoCategoriaExistente.Name = "grupoCategoriaExistente";
            grupoCategoriaExistente.Size = new Size(277, 144);
            grupoCategoriaExistente.TabIndex = 3;
            grupoCategoriaExistente.TabStop = false;
            grupoCategoriaExistente.Text = "Editar Categoria";
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.Location = new Point(16, 104);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(76, 32);
            btnGuardarCategoria.TabIndex = 4;
            btnGuardarCategoria.Text = "Editar";
            btnGuardarCategoria.UseVisualStyleBackColor = true;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click_1;
            // 
            // txtEditarNombreCategoria
            // 
            txtEditarNombreCategoria.Location = new Point(16, 71);
            txtEditarNombreCategoria.Name = "txtEditarNombreCategoria";
            txtEditarNombreCategoria.Size = new Size(245, 23);
            txtEditarNombreCategoria.TabIndex = 2;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(16, 22);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(245, 23);
            cmbCategorias.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 53);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 0;
            label2.Text = "Nuevo Nombre";
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 347);
            Controls.Add(grupoCategoriaExistente);
            Controls.Add(grupoCategoriaNueva);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            grupoCategoriaNueva.ResumeLayout(false);
            grupoCategoriaNueva.PerformLayout();
            grupoCategoriaExistente.ResumeLayout(false);
            grupoCategoriaExistente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtCategoriaNueva;
        private GroupBox grupoCategoriaNueva;
        private GroupBox grupoCategoriaExistente;
        private TextBox txtEditarNombreCategoria;
        private ComboBox cmbCategorias;
        private Label label2;
        private Button btnGuardarCategoria;
        private Button button1;
    }
}