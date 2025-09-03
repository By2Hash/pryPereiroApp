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
            mtbPrecioUnitario = new MaskedTextBox();
            dtpFecha = new DateTimePicker();
            cmbProducto = new ComboBox();
            nudCantidad = new NumericUpDown();
            panel2 = new Panel();
            btnSalir = new Button();
            btnRegistrar = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BorderStyle = BorderStyle.Fixed3D;
            lblFecha.Font = new Font("Segoe UI", 15F);
            lblFecha.Location = new Point(12, 55);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(64, 30);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BorderStyle = BorderStyle.Fixed3D;
            lblProducto.Font = new Font("Segoe UI", 15F);
            lblProducto.Location = new Point(12, 15);
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
            panel1.Controls.Add(mtbPrecioUnitario);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(cmbProducto);
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
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Location = new Point(231, 142);
            mtbPrecioUnitario.Mask = "00000";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(59, 23);
            mtbPrecioUnitario.TabIndex = 7;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(172, 55);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(118, 23);
            dtpFecha.TabIndex = 6;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(172, 15);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(118, 23);
            cmbProducto.TabIndex = 5;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(231, 97);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(59, 23);
            nudCantidad.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnRegistrar);
            panel2.Location = new Point(12, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 100);
            panel2.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(172, 38);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(69, 38);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmRegistroCompras
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(339, 326);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRegistroCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Ventas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            panel2.ResumeLayout(false);
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
        private Button btnRegistrar;
        private FileSystemWatcher fileSystemWatcher1;
        private DateTimePicker dtpFecha;
        private ComboBox cmbProducto;
        private MaskedTextBox mtbPrecioUnitario;
    }
}
