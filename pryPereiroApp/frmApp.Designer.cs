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
            lblFecha.Location = new Point(12, 13);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(64, 30);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BorderStyle = BorderStyle.Fixed3D;
            lblProducto.Font = new Font("Segoe UI", 15F);
            lblProducto.Location = new Point(12, 54);
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
            lblCantidad.Location = new Point(12, 97);
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
            lblPrecio.Location = new Point(12, 142);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(144, 30);
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 196);
            panel1.TabIndex = 5;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(172, 54);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(118, 23);
            txtProducto.TabIndex = 8;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Location = new Point(231, 142);
            mtbPrecioUnitario.Mask = "000";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(59, 23);
            mtbPrecioUnitario.TabIndex = 7;
            mtbPrecioUnitario.ValidatingType = typeof(int);
            mtbPrecioUnitario.MaskInputRejected += mtbPrecioUnitario_MaskInputRejected;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(172, 18);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(118, 23);
            dtpFecha.TabIndex = 6;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(231, 97);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(59, 23);
            nudCantidad.TabIndex = 4;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnRegistrar);
            panel2.Location = new Point(12, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 78);
            panel2.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(172, 26);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(69, 26);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblResultado);
            panel3.Location = new Point(12, 300);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 78);
            panel3.TabIndex = 7;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 30F);
            lblResultado.Location = new Point(23, 11);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(276, 54);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "                       \r\n";
            lblResultado.Click += lblResultado_Click;
            // 
            // frmRegistroCompras
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(339, 390);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRegistroCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Ventas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
