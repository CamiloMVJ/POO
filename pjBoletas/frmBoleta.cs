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
            lblNumBoleta.Text = (numboleta).ToString("D5");
            buttLimpiar_Click(sender, e);
            boleta.Producto = txtProducto.Text;

        }
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            boleta.Producto = txtProducto.Text;
            lblPrecio.Text = boleta.Precio().ToString("C");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                CapturaDatos();
                ListViewItem info = new ListViewItem(txtCantidad.Text);
                info.SubItems.Add(txtProducto.Text);
                info.SubItems.Add(boleta.Precio().ToString());
                info.SubItems.Add(boleta.Importe().ToString());
                lvInfo.Items.Add(info);
                
                double precio = boleta.Precio();
                cantidadacumulada += boleta.Cantidad;
                importe = importe + boleta.Importe();
                
            }
            else
                MessageBox.Show("El error se encuentra en " + Valida());
        }

        private void CapturaDatos()
        {
            boleta.Cantidad = int.Parse(txtCantidad.Text);
            boleta.NumBoleta = int.Parse(lblNumBoleta.Text);
            boleta.Direccion = txtDireccion.Text;
            boleta.DNI = txtDNI.Text;
            boleta.FechaCompra = DateTime.Parse(lblFecha.Text);
        }

        private string Valida()
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                txtNombre.Focus();
                return "El Nombre del cliente";
            }
            else if (txtDNI.Text.Trim().Length == 0)
            {
                txtDNI.Focus();
                return "El DNI del cliente";
            }
            else if (txtDireccion.Text.Trim().Length == 0)
            {
                txtDireccion.Focus();
                return "La direccion del cliente";
            }
            else if(txtCantidad.Text.Trim().Length == 0)
            {
                txtCantidad.Focus();
                return "La cantidad del producto";
            }

            return "";
        }

        private void buttLimpiar_Click(object sender, EventArgs e)
        {
            importe = 0;
            lblPrecio.Text = (0).ToString("C");
            lvInfo.Items.Clear();
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
            lblNumBoleta.Text = numboleta.ToString("D5");
            buttLimpiar_Click(sender, e);
        }


    }
}
/*PS5+ 1 MANDO DS5
PS4 (1TB) + 1 MANDO DS4
MANDO PS5/DS5
MANDO PS4/DS4*/