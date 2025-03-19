using CapaAccesoDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private readonly LogicaBanco logica;

        public Form1()
        {
            InitializeComponent();
            logica = new LogicaBanco(new ConexionSQLServer());
            cbTipoDoc.SelectedIndex = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            if (!ValidarEntradas(out decimal MontoSoliciatdo, out int PlazoSolicitado,
                out decimal IngresosTotales, out decimal EgresosTotales, out int NroDoc))
            {
                MessageBox.Show("Entradas inválidas");
                return;
            }

            var resultado = logica.EvaluarCredito(
                MontoSoliciatdo,
                PlazoSolicitado,
                IngresosTotales,
                EgresosTotales,
                NroDoc
            );

            MessageBox.Show(resultado);
        }

        private bool ValidarEntradas(
    out decimal MontoSolicitado,
    out int PlazoSolicitado,
    out decimal IngresosTotales,
    out decimal EgresosTotales,
    out int NroDoc)
        {
            // Inicialización correcta por tipo
            MontoSolicitado = 0m;
            PlazoSolicitado = 0;
            IngresosTotales = 0m;
            EgresosTotales = 0m;
            NroDoc = 0;

            return decimal.TryParse(tbMontoS.Text, out MontoSolicitado) &&
                   int.TryParse(tbPlazoS.Text, out PlazoSolicitado) &&
                   decimal.TryParse(tbIngresosT.Text, out IngresosTotales) &&
                   decimal.TryParse(tbEgresosT.Text, out EgresosTotales) &&
                   int.TryParse(tbNroDoc.Text, out NroDoc);
        }
    }
}