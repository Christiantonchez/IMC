using Imc.Models;

Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona. \n");


decimal peso =
    ReadDecimal("Proporciona el peso en KG: ");


decimal Estatura =
    ReadDecimal("Proporciona la estatura en Metros: ");


decimal imc = CalculadoraImc.IndiceDeMasaCoporal(peso, Estatura) ;
    


Console.WriteLine($"El indice de masa corporal de la persona es: {imc:F4}");
Console.WriteLine($"El estado nutricional de la persona es: {CalculadoraImc.SituacionNutricional(imc)}");




static decimal ReadDecimal (string indicacion)

{
    Console.Write(indicacion);
    var Entrada = Console.ReadLine();
 return Convert.ToDecimal(Entrada);

}

