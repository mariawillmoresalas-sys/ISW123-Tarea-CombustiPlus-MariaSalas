namespace CombustiPlus
{
    public partial class Form1 : Form

    {
        List<Despacho> despachos = new List<Despacho>();
        Dictionary<string, decimal> galonesPorCombustible = new Dictionary<string, decimal>();

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

        private void btnDespachar_Click(object sender, EventArgs e)
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


            Despacho nuevoDespacho = new Despacho();

            nuevoDespacho.Numero = despachos.Count + 1;
            nuevoDespacho.Placa = txtPlaca.Text;
            nuevoDespacho.Combustible = cmbCombustible.Text;
            nuevoDespacho.Galones = galones;
            nuevoDespacho.Pago = cmbPago.Text;
            nuevoDespacho.Total = total;

            despachos.Add(nuevoDespacho);

            lstDespachos.Items.Add(nuevoDespacho);

            decimal totalVendido = 0;
            decimal galonesTotales = 0;

            Despacho despachoMayor = despachos[0];

            foreach (Despacho despacho in despachos)
            {
                totalVendido += despacho.Total;
                galonesTotales += despacho.Galones;

                if (despacho.Total > despachoMayor.Total)
                {
                    despachoMayor = despacho;
                }
            }

            lblResumen.Text =
                "Cantidad de despachos: " + despachos.Count +
                "\nTotal vendido: RD$ " + totalVendido.ToString("N2") +
                "\nGalones vendidos: " + galonesTotales.ToString("N1") +
                "\nDespacho mayor: #" + despachoMayor.Numero;

        }

        private void bntPorCombustible_Click(object sender, EventArgs e)
        {
            if (despachos.Count == 0)
            {
                MessageBox.Show("Todavía no hay despachos registrados.");
                return;
            }

            galonesPorCombustible.Clear();

            foreach (Despacho despacho in despachos)
            {
                if (galonesPorCombustible.ContainsKey(despacho.Combustible))
                {
                    galonesPorCombustible[despacho.Combustible] += despacho.Galones;
                }
                else
                {
                    galonesPorCombustible[despacho.Combustible] = despacho.Galones;
                }
            }

            lstDetalle.Items.Clear();

            foreach (KeyValuePair<string, decimal> combustible in galonesPorCombustible)
            {
                lstDetalle.Items.Add(
                    combustible.Key + ": " +
                    combustible.Value.ToString("N1") + " galones"
                );
            }
        }
    }
}
