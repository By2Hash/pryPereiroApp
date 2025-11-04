namespace pryPereiroApp
{
    public partial class frmRegistroCompras : Form
    {
        public frmRegistroCompras()
        {
            InitializeComponent();
            btnRegistrar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DateTime vFecha;
        string vProducto;
        int vCantidad;
        string vPrecioUnitario;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            
            vFecha = dtpFecha.Value;
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            vPrecioUnitario = txtPrecioUnitario.Text;
            vProducto = txtProducto.Text;

            lblResultado.Text =  "Producto: " + vProducto.ToString() + " - " +
                                  "Fecha: " + vFecha.ToString() + " -  " +
                                  "Cantidad: " + vCantidad.ToString() + " - " +
                                 "Precio: " + vPrecioUnitario.ToString();
            //lblResultado.Text = vCantidad.ToString() + " - " + vPrecioUnitario.ToString() + " - " + vFecha.ToString() + " - " + vProducto.ToString();

            txtProducto.Text = "";
            txtPrecioUnitario.Text = "";
            nudCantidad.Value = 0;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }


        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            ActivarBoton();
        }

        private void frmRegistroCompras_Load(object sender, EventArgs e)
        {

        }

        private void mtbPrecioUnitario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ActivarBoton();
        }

        public void ActivarBoton()
        {
            if (!string.IsNullOrWhiteSpace(txtProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
            {
                btnRegistrar.Enabled = true;

            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            ActivarBoton();
        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled= false;
            }
        }
    }
}
