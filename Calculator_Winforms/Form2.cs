using System.Globalization;

namespace Calculator_Winforms
{
    public partial class Form2 : Form
    {
        private static readonly CultureInfo SpanishCulture = CultureInfo.GetCultureInfo("es-ES");
        private decimal? firstOperand;
        private string? pendingOperator;
        private bool startNewNumber = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (startNewNumber || txtDisplay.Text == "0")
            {
                txtDisplay.Text = button.Text;
                startNewNumber = false;
            }
            else
            {
                txtDisplay.Text += button.Text;
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (startNewNumber)
            {
                txtDisplay.Text = "0,";
                startNewNumber = false;
            }
            else if (!txtDisplay.Text.Contains(','))
            {
                txtDisplay.Text += ",";
            }
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button button || !TryGetDisplayValue(out decimal value))
            {
                return;
            }

            if (firstOperand.HasValue && pendingOperator is not null && !startNewNumber)
            {
                if (!TryCalculate(firstOperand.Value, value, pendingOperator, out decimal result))
                {
                    return;
                }

                firstOperand = result;
                txtDisplay.Text = result.ToString("G29", SpanishCulture);
            }
            else
            {
                firstOperand = value;
            }

            pendingOperator = button.Text;
            startNewNumber = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!firstOperand.HasValue || pendingOperator is null || !TryGetDisplayValue(out decimal secondOperand))
            {
                return;
            }

            if (!TryCalculate(firstOperand.Value, secondOperand, pendingOperator, out decimal result))
            {
                return;
            }

            txtDisplay.Text = result.ToString("G29", SpanishCulture);
            firstOperand = null;
            pendingOperator = null;
            startNewNumber = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstOperand = null;
            pendingOperator = null;
            startNewNumber = true;
        }

        private bool TryGetDisplayValue(out decimal value)
        {
            if (decimal.TryParse(txtDisplay.Text, NumberStyles.Number, SpanishCulture, out value))
            {
                return true;
            }

            MessageBox.Show(
                "Introduce un número válido.",
                "Datos no válidos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        private bool TryCalculate(decimal left, decimal right, string operation, out decimal result)
        {
            result = operation switch
            {
                "+" => left + right,
                "−" => left - right,
                "×" => left * right,
                "÷" when right != 0m => left / right,
                _ => 0m
            };

            if (operation == "÷" && right == 0m)
            {
                MessageBox.Show(
                    "No se puede dividir entre cero.",
                    "Operación no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return operation is "+" or "−" or "×" or "÷";
        }
    }
}
