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
            txtProducto = new TextBox();
            mtbPrecioUnitario = new MaskedTextBox();
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
            lblFecha.Location = new Point(17, 22);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(97, 43);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BorderStyle = BorderStyle.Fixed3D;
            lblProducto.Font = new Font("Segoe UI", 15F);
            lblProducto.Location = new Point(17, 90);
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
            lblPrecio.Location = new Point(17, 237);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(215, 43);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio Unitario";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(mtbPrecioUnitario);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(nudCantidad);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblProducto);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblCantidad);
            panel1.Location = new Point(17, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 327);
            panel1.TabIndex = 5;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(246, 90);
            txtProducto.Margin = new Padding(4, 5, 4, 5);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(167, 31);
            txtProducto.TabIndex = 8;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Location = new Point(330, 237);
            mtbPrecioUnitario.Margin = new Padding(4, 5, 4, 5);
            mtbPrecioUnitario.Mask = "000";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(83, 31);
            mtbPrecioUnitario.TabIndex = 7;
            mtbPrecioUnitario.ValidatingType = typeof(int);
            mtbPrecioUnitario.MaskInputRejected += mtbPrecioUnitario_MaskInputRejected;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(246, 30);
            dtpFecha.Margin = new Padding(4, 5, 4, 5);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(167, 31);
            dtpFecha.TabIndex = 6;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(330, 162);
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
            panel2.Size = new Size(451, 130);
            panel2.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(246, 43);
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
            btnRegistrar.Location = new Point(99, 43);
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
            panel3.Location = new Point(17, 500);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 315);
            panel3.TabIndex = 7;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblResultado.Location = new Point(4, 30);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(443, 263);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "      \r\n";
            lblResultado.Click += lblResultado_Click;
            // 
            // frmRegistroCompras
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(484, 835);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegistroCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Ventas";
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
        private MaskedTextBox mtbPrecioUnitario;
        private TextBox txtProducto;
        private Panel panel3;
        private Label lblResultado;
    }
}
