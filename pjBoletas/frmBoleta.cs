namespace pjBoletas
{
    public partial class frmBoleta : Form
    {
        int cantidadacumulada = 0;
        double importe = 0;
        Boleta boleta = new Boleta();
        int numboleta = 1;
        public frmBoleta()
        {
            InitializeComponent();
        }

        private void frmBoleta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblNumBoleta.Text = (numboleta).ToString("0000");
            buttLimpiar_Click(sender, e);
            
        }
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text.Equals("PS5+ 1 MANDO DS5"))
            {
                lblPrecio.Text = (500).ToString("0.00"); 
                boleta.precio = 500;
            }
                
            if (txtProducto.Text.Equals("PS4 (1TB) + 1 MANDO DS4"))
            {
                lblPrecio.Text = (619).ToString("0.00"); 
                boleta.precio = 619;
            }
                
            if (txtProducto.Text.Equals("MANDO PS5/DS5"))
            {
                lblPrecio.Text = (69).ToString("0.00"); 
                boleta.precio = 69;
            }
                
            if (txtProducto.Text.Equals("MANDO PS4/DS4"))
            {
                lblPrecio.Text = (60).ToString("0.00"); 
                boleta.precio = 60;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boleta.cantidad = int.Parse(txtCantidad.Text);
            double precio = boleta.Precio();
            cantidadacumulada += boleta.cantidad;
            importe = importe + boleta.importe();
            lblImporte.Text = (importe).ToString("C");
        }

        private void buttLimpiar_Click(object sender, EventArgs e)
        {
            importe = 0;
            lblPrecio.Text = (0).ToString("C");
            lblImporte.Text = (0).ToString("C");
            txtNombre.Clear();
            txtDireccion.Clear();
            txtProducto.ResetText();
            txtCantidad.Clear();
            txtDNI.Clear();
            txtNombre.Focus();
            cantidadacumulada = 0;
        }

        private void buttEstadistica_Click(object sender, EventArgs e)
        {

            ListViewItem estadistica = new ListViewItem(lblNumBoleta.Text);
            estadistica.SubItems.Add(lblFecha.Text);
            estadistica.SubItems.Add(cantidadacumulada.ToString());
            estadistica.SubItems.Add(importe.ToString());
            lvEstadistica.Items.Add(estadistica);
            numboleta++;
            lblNumBoleta.Text = numboleta.ToString("0000");
        }
    }
}
/*PS5+ 1 MANDO DS5
PS4 (1TB) + 1 MANDO DS4
MANDO PS5/DS5
MANDO PS4/DS4*/