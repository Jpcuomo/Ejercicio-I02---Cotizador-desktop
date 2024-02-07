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
        }
    }
}
