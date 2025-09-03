namespace pryPereiroApp
{
    partial class frmRegistroCompras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnComprar = new Button();
            btnSalir = new Button();
            nudCantidad = new NumericUpDown();
            fileSystemWatcher1 = new FileSystemWatcher();
            txtPrecioUnitario = new TextBox();
            txtFecha = new TextBox();
            txtProducto = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BorderStyle = BorderStyle.Fixed3D;
            lblFecha.Font = new Font("Segoe UI", 15F);
            lblFecha.Location = new Point(15, 56);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(64, 30);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            lblFecha.Click += this.label1_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BorderStyle = BorderStyle.Fixed3D;
            lblProducto.Font = new Font("Segoe UI", 15F);
            lblProducto.Location = new Point(15, 16);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(95, 30);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto\r\n";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BorderStyle = BorderStyle.Fixed3D;
            lblCantidad.Font = new Font("Segoe UI", 15F);
            lblCantidad.Location = new Point(15, 98);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(93, 30);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BorderStyle = BorderStyle.Fixed3D;
            lblPrecio.Font = new Font("Segoe UI", 15F);
            lblPrecio.Location = new Point(15, 143);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(144, 30);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio Unitario";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(txtPrecioUnitario);
            panel1.Controls.Add(nudCantidad);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblProducto);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblCantidad);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 196);
            panel1.TabIndex = 5;
            panel1.Paint += this.panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnComprar);
            panel2.Location = new Point(12, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 100);
            panel2.TabIndex = 6;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(104, 39);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(75, 23);
            btnComprar.TabIndex = 0;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += this.button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(197, 39);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += this.btnSalir_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(257, 98);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 4;
            nudCantidad.ValueChanged += this.numericUpDown1_ValueChanged;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(316, 147);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(61, 23);
            txtPrecioUnitario.TabIndex = 5;
            txtPrecioUnitario.TextChanged += this.textBox1_TextChanged;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(257, 63);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(120, 23);
            txtFecha.TabIndex = 6;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(257, 23);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(120, 23);
            txtProducto.TabIndex = 7;
            txtProducto.TextChanged += this.textBox3_TextChanged;
            // 
            // frmRegistroCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 326);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRegistroCompras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecio;
        private Panel panel1;
        private NumericUpDown nudCantidad;
        private Panel panel2;
        private Button btnSalir;
        private Button btnComprar;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txtProducto;
        private TextBox txtFecha;
        private TextBox txtPrecioUnitario;
    }
}
