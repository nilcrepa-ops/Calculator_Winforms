using System.Globalization;

namespace Calculator_Winforms
{
    public partial class Form1 : Form
    {
        private static readonly CultureInfo SpanishCulture = CultureInfo.GetCultureInfo("es-ES");

        public Form1()
        {
            InitializeComponent();
            UpdateDiscountState();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!TryParseDecimal(txtPrice.Text, "Price", 0.01m, out decimal price) ||
                !TryParseDecimal(txtQuantity.Text, "Quantity", 1m, out decimal quantity))
            {
                return;
            }

            decimal subtotal = price * quantity;
            decimal discountRate = chkPartner.Checked ? 0.30m : GetSelectedDiscountRate();
            decimal noIva = subtotal * (1m - discountRate);
            decimal withIva = noIva * (1m + GetSelectedIvaRate());

            txtNoIva.Text = noIva.ToString("C2", SpanishCulture);
            txtWithIva.Text = withIva.ToString("C2", SpanishCulture);
        }

        private void chkPartner_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDiscountState();
        }

        private void btnOpenBasicCalculator_Click(object sender, EventArgs e)
        {
            using Form2 basicCalculator = new();
            basicCalculator.ShowDialog(this);
        }

        private void UpdateDiscountState()
        {
            grpDiscount.Enabled = !chkPartner.Checked;
        }

        private decimal GetSelectedIvaRate()
        {
            if (rbIva21.Checked) return 0.21m;
            if (rbIva10.Checked) return 0.10m;
            if (rbIva4.Checked) return 0.04m;
            return 0m;
        }

        private decimal GetSelectedDiscountRate()
        {
            if (rbD20.Checked) return 0.20m;
            if (rbD10.Checked) return 0.10m;
            if (rbD5.Checked) return 0.05m;
            return 0m;
        }

        private bool TryParseDecimal(string text, string fieldName, decimal minimum, out decimal value)
        {
            if (!decimal.TryParse(text, NumberStyles.Number, SpanishCulture, out value) || value < minimum)
            {
                MessageBox.Show(
                    $"Introduce un valor v\u00E1lido para {fieldName}. El m\u00EDnimo es {minimum.ToString("N2", SpanishCulture)}.",
                    "Datos no v\u00E1lidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
