namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCombustible.Items.Add("Premium");
            cmbCombustible.Items.Add("Regular");
            cmbCombustible.Items.Add("Gasoil");

            cmbPago.Items.Add("Efectivo");
            cmbPago.Items.Add("Tarjeta");

            cmbCombustible.SelectedIndex = 0;
            cmbPago.SelectedIndex = 0;
        }

        private bool ValidarDatos()
        {
            if (txtPlaca.Text.Trim().Length != 7)
            {
                MessageBox.Show("La placa debe tener 7 caracteres.");
                txtPlaca.Focus();
                return false;
            }

            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("Los galones deben ser más de 0.");
                nudGalones.Focus();
                return false;
            }

            return true;
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            decimal precio = cmbCombustible.Text switch
            {
                "Premium" => 290,
                "Regular" => 272,
                "Gasoil" => 225,
                _ => 0
            };

            decimal galones = nudGalones.Value;

            decimal subtotal = precio * galones;

            decimal descuento = 0;

            if (galones >= 20)
            {
                descuento = subtotal * 0.02m;
            }

            decimal totalDescuento = subtotal - descuento;

            decimal recargo = 0;

            if (cmbPago.Text == "Tarjeta")
            {
                recargo = totalDescuento * 0.03m;
            }

            decimal total = totalDescuento + recargo;

            lstDetalle.Items.Clear();

            lstDetalle.Items.Add("Combustible: " + cmbCombustible.Text);
            lstDetalle.Items.Add("Precio por galón: RD$ " + precio.ToString("N2"));
            lstDetalle.Items.Add("Galones: " + galones);
            lstDetalle.Items.Add("Subtotal: RD$ " + subtotal.ToString("N2"));
            lstDetalle.Items.Add("Descuento: RD$ " + descuento.ToString("N2"));
            lstDetalle.Items.Add("Recargo: RD$ " + recargo.ToString("N2"));
            lstDetalle.Items.Add("TOTAL: RD$ " + total.ToString("N2"));
        }
    }
}
