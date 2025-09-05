namespace pryPereiroApp
{
    public partial class frmRegistroCompras : Form
    {
        public frmRegistroCompras()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DateTime vFecha;
        string vProducto;
        int vCantidad;
        int vPrecioUnitario;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            vFecha = dtpFecha.Value;
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            vPrecioUnitario = Convert.ToInt32(mtbPrecioUnitario.Text);
            vProducto = txtProducto.Text;

            lblResultado.Text = vCantidad.ToString() + " - " + vPrecioUnitario.ToString() + " - " + vFecha.ToString() + " - " + vProducto.ToString();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Text != "")
            {
                mtbPrecioUnitario.Enabled = true;
            }
            else
            {
                mtbPrecioUnitario.Enabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                nudCantidad.Enabled = true;
            }
            else
            {
                nudCantidad.Enabled = false;
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }


        private void lblResultado_Click(object sender, EventArgs e)
        {





        }

        private void mtbPrecioUnitario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
