using Imc.Models;

namespace IMC.Gui
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            LimpiarInformacion();
        }

        private void LimpiarInformacion()
        {
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty;
        }

        private void Calcular_Button_Clicked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
            decimal imc = CalculadoraImc.IndiceDeMasaCoporal(peso, estatura);
            ImcLabel.Text = imc.ToString("G6");

            string estadoNutricional = string.Empty;

            SituacionNutricionalLabel.Text = CalculadoraImc.SituacionNutricional(imc);
        }


        private void Limpiar_Button_Clicked(object sender, EventArgs e)
        {
            LimpiarInformacion();
        }


    }
    
}
