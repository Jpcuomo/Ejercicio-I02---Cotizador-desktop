using Billetes;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
namespace Forms
{
    public partial class FrmMonedas : Form
    {
        // Atributos
        private bool flagLocked;
        Euro euro;
        Dolar dolar;
        Peso peso;

        // Constructor
        public FrmMonedas()
        {
            InitializeComponent();
            flagLocked = false;
        }

        // Inicialización del formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializo textBoxes de solo lectura
            tBxCotizEuro.ReadOnly = true;
            tBxCotizPeso.ReadOnly = true;
            tBxCotizDolar.ReadOnly = true;
            tBxEuroAEuro.ReadOnly = true;
            tBxEuroADolar.ReadOnly = true;
            tBxEuroAPeso.ReadOnly = true;
            tBxDolarAEuro.ReadOnly = true;
            tBxDolarADolar.ReadOnly = true;
            tBxDolarAPeso.ReadOnly = true;
            tBxPesoAEuro.ReadOnly = true;
            tBxPesoADolar.ReadOnly = true;
            tBxPesoAPeso.ReadOnly = true;

            // Cotización inicial del Euro
            tBxCotizEuro.Text = Euro.GetCotizacion.ToString("F4");

            // Cotización inicial del Peso
            tBxCotizPeso.Text = Peso.GetCotizacion.ToString("F4");
        }


        // Botón para bloquear/ desbloquear la edición de las cotizaciones
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


        // Métodos para volver el foco al TextBox con número erroneo ingresado
        // Si el número es correcto actualiza la cotización
        private void tBxCotizEuro_Leave(object sender, EventArgs e)
        {
            if (!ValidarNumeroDecimal(tBxCotizEuro.Text))
            {
                tBxCotizEuro.Focus();
            }
            else
            {
                Euro.SetCotizacion(double.Parse(tBxCotizEuro.Text));
                tBxCotizEuro.Text = Euro.GetCotizacion.ToString("F4");
            }
        }

        private void tBxCotizPeso_Leave(object sender, EventArgs e)
        {
            if (!ValidarNumeroDecimal(tBxCotizPeso.Text))
            {
                tBxCotizPeso.Focus();
            }
            else
            {
                Peso.SetCotizacion(double.Parse(tBxCotizPeso.Text));
                tBxCotizPeso.Text = Peso.GetCotizacion.ToString("F4");
            }
        }


        // Métodos para botones de conversión de moneda
        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (!ValidarNumeroDecimal(tBxCantEuro.Text))
            {
                tBxCantEuro.Focus();
                tBxCantEuro.Clear();
            }
            else
            {
                tBxEuroAEuro.Text = tBxCantEuro.Text.ToString();

                euro = new Euro(double.Parse(tBxCantEuro.Text), Euro.GetCotizacion);
                tBxEuroADolar.Text = ((Dolar)euro).ToString();

                tBxEuroAPeso.Text = ((Peso)euro).ToString();
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (!ValidarNumeroDecimal(tBxCantDolar.Text))
            {
                tBxCantDolar.Focus();
                tBxCantDolar.Clear();
            }
            else
            {
                tBxDolarADolar.Text = tBxCantDolar.Text.ToString();

                dolar = new Dolar(double.Parse(tBxCantDolar.Text), Dolar.GetCotizacion);
                tBxDolarAEuro.Text = ((Euro)dolar).ToString();

                tBxDolarAPeso.Text = (((Peso)dolar).ToString());
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (!ValidarNumeroDecimal(tBxCantPeso.Text))
            {
                tBxCantPeso.Focus();
                tBxCantPeso.Clear();
            }
            else
            {
                peso = new Peso(double.Parse(tBxCantPeso.Text), Peso.GetCotizacion);
                tBxPesoAEuro.Text = ((Euro)peso).ToString();

                tBxPesoADolar.Text = ((Dolar)peso).ToString();

                tBxPesoAPeso.Text = tBxCantPeso.Text.ToString();
            }
        }


        // Valida el número decimal ingresado. En caso de error muestra un MessageBox
        private bool ValidarNumeroDecimal(string numeroString)
        {
            string mensaje;
            double numero;
            string patron = @"^-?[0-9]+(?:,[0-9]+)?$";

            if (string.IsNullOrEmpty(numeroString))
            {
                mensaje = "El campo no puede estar vacío";
            }
            else if (!Regex.IsMatch(numeroString, patron))
            {
                mensaje = "El formato de número no cumple con el requerido";
            }
            else
            {
                numero = double.Parse(numeroString);
                if (numero >= 0)
                {
                    numeroString = numero.ToString();
                    return true;

                }
                else
                {
                    mensaje = "No puedes ingresar números negativos";
                }
            }
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
