



Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona. \n");


decimal peso =
    ReadDecimal("Proporciona el peso en KG: ");


decimal Estatura =
    ReadDecimal("Proporciona la estatura en Metros: ");


decimal imc = IndiceDeMasaCoporal(peso, Estatura) ;
    


Console.WriteLine($"El indice de masa corporal de la persona es: {imc:G6}");
Console.WriteLine($"El estado nutricional de la persona es: {SituacionNutricional}");


decimal ReadDecimal (string indicacion)

{
    Console.Write(indicacion);
    var Entrada = Console.ReadLine();
 return Convert.ToDecimal(Entrada);

}

static decimal IndiceDeMasaCoporal(decimal peso, decimal Estatura)
{
    return peso / (Estatura * Estatura);
}


static string SituacionNutricional(decimal imc)
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