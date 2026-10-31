using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TrabajoFinal___Grupo2___LUG26
{
    partial class FrmPedido
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvDetalle = new System.Windows.Forms.DataGridView();
            pnlTop = new System.Windows.Forms.Panel();
            lblCliente = new System.Windows.Forms.Label();
            cmbCliente = new System.Windows.Forms.ComboBox();
            lblProducto = new System.Windows.Forms.Label();
            cmbProducto = new System.Windows.Forms.ComboBox();
            lblCajas = new System.Windows.Forms.Label();
            nudCantidad = new System.Windows.Forms.NumericUpDown();
            btnAgregar = new System.Windows.Forms.Button();
            lblInfo = new System.Windows.Forms.Label();
            pnlBottom = new System.Windows.Forms.Panel();
            lblTotal = new System.Windows.Forms.Label();
            btnQuitar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            btnVaciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgvDetalle)).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(nudCantidad)).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblCliente);
            pnlTop.Controls.Add(cmbCliente);
            pnlTop.Controls.Add(lblProducto);
            pnlTop.Controls.Add(cmbProducto);
            pnlTop.Controls.Add(lblCajas);
            pnlTop.Controls.Add(nudCantidad);
            pnlTop.Controls.Add(btnAgregar);
            pnlTop.Controls.Add(lblInfo);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(760, 115);
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new System.Drawing.Point(10, 18);
            lblCliente.Name = "lblCliente";
            lblCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.DisplayMember = "RazonSocial";
            cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCliente.Location = new System.Drawing.Point(75, 14);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new System.Drawing.Size(320, 21);
            cmbCliente.ValueMember = "Id";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new System.Drawing.Point(10, 55);
            lblProducto.Name = "lblProducto";
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProducto.Location = new System.Drawing.Point(75, 51);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new System.Drawing.Size(320, 21);
            cmbProducto.ValueMember = "Id";
            cmbProducto.SelectedIndexChanged += new System.EventHandler(cmbProducto_SelectedIndexChanged);
            // 
            // lblCajas
            // 
            lblCajas.AutoSize = true;
            lblCajas.Location = new System.Drawing.Point(415, 55);
            lblCajas.Name = "lblCajas";
            lblCajas.Text = "Cajas:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new System.Drawing.Point(460, 52);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new System.Drawing.Size(70, 20);
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(545, 48);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(90, 28);
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += new System.EventHandler(btnAgregar_Click);
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new System.Drawing.Point(75, 88);
            lblInfo.Name = "lblInfo";
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(btnQuitar);
            pnlBottom.Controls.Add(btnConfirmar);
            pnlBottom.Controls.Add(btnVaciar);
            pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new System.Drawing.Size(760, 55);
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            lblTotal.Location = new System.Drawing.Point(10, 16);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total: $ 0,00";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new System.Drawing.Point(340, 13);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new System.Drawing.Size(100, 28);
            btnQuitar.Text = "Quitar línea";
            btnQuitar.Click += new System.EventHandler(btnQuitar_Click);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new System.Drawing.Point(450, 13);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(150, 28);
            btnConfirmar.Text = "Confirmar pedido";
            btnConfirmar.Click += new System.EventHandler(btnConfirmar_Click);
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new System.Drawing.Point(610, 13);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new System.Drawing.Size(90, 28);
            btnVaciar.Text = "Vaciar";
            btnVaciar.Click += new System.EventHandler(btnVaciar_Click);
            // 
            // FrmNuevoPedido
            // 
            ClientSize = new System.Drawing.Size(760, 500);
            Controls.Add(dgvDetalle);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Name = "FrmNuevoPedido";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Nuevo pedido";
            Load += new System.EventHandler(FrmNuevoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(dgvDetalle)).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(nudCantidad)).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblCajas;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVaciar;
    }
}
