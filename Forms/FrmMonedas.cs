using Billetes;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
namespace Forms
{
    public partial class FrmMonedas : Form
    {
        private bool flagLocked;

        public FrmMonedas()
        {
            InitializeComponent();
            flagLocked = false;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            int indice;
            if (flagLocked)
            {
                indice = 0;
                tBxCotizEuro.ReadOnly = true;
                tBxCotizPeso.ReadOnly = true;
                flagLocked = false;
            }
            else
            {
                indice = 1;
                tBxCotizEuro.ReadOnly = false;
                tBxCotizPeso.ReadOnly = false;
                flagLocked = true;
            }
            btnLock.ImageIndex = indice;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializo textBoxes de solo lectura
            tBxCotizEuro.ReadOnly = true;
            tBxCotizPeso.ReadOnly = true;
            tBxCotizDolar.ReadOnly = true;
            tBxEuroEuro.ReadOnly = true;
            tBxDolarEuro.ReadOnly = true;
            tBxPesoEuro.ReadOnly = true;
            tBxEuroDolar.ReadOnly = true;
            tBxDolarDolar.ReadOnly = true;
            tBxPesoDolar.ReadOnly = true;
            tBxEuroPeso.ReadOnly = true;
            tBxDolarPeso.ReadOnly = true;
            tBxPesoPeso.ReadOnly = true;

            // Cotización inicial del Euro
            tBxCotizEuro.Text = Euro.GetCotizacion.ToString("F2");

            // Cotización inicial del Peso
            tBxCotizPeso.Text = Peso.GetCotizacion.ToString("F2");
        }

        private void tBxCotizEuro_Leave(object sender, EventArgs e)
        {
            if(!ValidarDecimal(tBxCotizEuro.Text))
            {
                tBxCotizEuro.Focus();
            }
        }

        private void tBxCotizPeso_Leave(object sender, EventArgs e)
        {
            if (!ValidarDecimal(tBxCotizPeso.Text))
            {
                tBxCotizPeso.Focus();
            }
        }

        private bool ValidarDecimal(string numeroString)
        {
            double numero;
            string patron = @"^[0-9]+(?:,[0-9]{1,2})?$";

            if(double.TryParse(numeroString, out numero) && Regex.IsMatch(numeroString, patron))
            {
                if(numero >= 0)
                {
                    numeroString = numero.ToString();
                    return true;
                }
            }
            MessageBox.Show("Formato de número incorrecto\nSólo puedes ingresar números mayores a cero con dos decimales como máximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
            
        }
    }
}
