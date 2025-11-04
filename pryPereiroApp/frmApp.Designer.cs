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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCompras));
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            panel1 = new Panel();
            txtPrecioUnitario = new TextBox();
            txtProducto = new TextBox();
            dtpFecha = new DateTimePicker();
            nudCantidad = new NumericUpDown();
            panel2 = new Panel();
            btnSalir = new Button();
            btnRegistrar = new Button();
            panel3 = new Panel();
            lblResultado = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BorderStyle = BorderStyle.Fixed3D;
            lblFecha.Font = new Font("Segoe UI", 15F);
            lblFecha.Location = new Point(17, 90);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(97, 43);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BorderStyle = BorderStyle.Fixed3D;
            lblProducto.Font = new Font("Segoe UI", 15F);
            lblProducto.Location = new Point(17, 18);
            lblProducto.Margin = new Padding(4, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(142, 43);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto\r\n";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BorderStyle = BorderStyle.Fixed3D;
            lblCantidad.Font = new Font("Segoe UI", 15F);
            lblCantidad.Location = new Point(17, 162);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(139, 43);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BorderStyle = BorderStyle.Fixed3D;
            lblPrecio.Font = new Font("Segoe UI", 15F);
            lblPrecio.Location = new Point(17, 227);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(215, 43);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio Unitario";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(txtPrecioUnitario);
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(nudCantidad);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblProducto);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblCantidad);
            panel1.Location = new Point(17, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 327);
            panel1.TabIndex = 5;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(482, 237);
            txtPrecioUnitario.MaxLength = 4;
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(84, 31);
            txtPrecioUnitario.TabIndex = 9;
            txtPrecioUnitario.TextChanged += textBox1_TextChanged;
            txtPrecioUnitario.KeyPress += txtPrecioUnitario_KeyPress;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(399, 18);
            txtProducto.Margin = new Padding(4, 5, 4, 5);
            txtProducto.MaxLength = 20;
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(167, 31);
            txtProducto.TabIndex = 8;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(399, 90);
            dtpFecha.Margin = new Padding(4, 5, 4, 5);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(167, 31);
            dtpFecha.TabIndex = 6;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(482, 162);
            nudCantidad.Margin = new Padding(4, 5, 4, 5);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(84, 31);
            nudCantidad.TabIndex = 4;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnRegistrar);
            panel2.Location = new Point(17, 357);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 130);
            panel2.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(125, 43);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(399, 43);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 38);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblResultado);
            panel3.Location = new Point(668, 20);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 467);
            panel3.TabIndex = 7;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblResultado.Location = new Point(17, 18);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(218, 437);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "      \r\n";
            // 
            // frmRegistroCompras
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(1010, 505);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegistroCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Ventas";
            Load += frmRegistroCompras_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private Button btnRegistrar;
        private DateTimePicker dtpFecha;
        private TextBox txtProducto;
        private Panel panel3;
        private Label lblResultado;
        private TextBox txtPrecioUnitario;
    }
}
