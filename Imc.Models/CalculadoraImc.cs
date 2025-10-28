namespace Imc.Models
{
    public static class CalculadoraImc
    {
        public static decimal IndiceDeMasaCoporal(decimal peso, decimal Estatura)
        {
            return peso / (Estatura * Estatura);
        }


        public static string SituacionNutricional(decimal imc)
        {
            string estadoNutricional;

            if (imc < 18.5M)
            {
                estadoNutricional = "peso bajo";
            }
            else if (imc < 25.0M)
            {
                estadoNutricional = "peso normal";
            }
            else if (imc < 30.0M)
            {
                estadoNutricional = "sobre peso";
            }
            else if (imc < 40.0M)
            {
                estadoNutricional = "obesidad";
            }
            else
            {
                estadoNutricional = "Obesidad extrema";
            }

            return estadoNutricional;
        }
    }
}
