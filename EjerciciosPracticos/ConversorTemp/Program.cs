using System;

class ConversorTemperatura
{
    static string escalaConversion = "FahrenheitACelsius"; // Cambiar a "CelsiusAFahrenheit" para otra conversión

    static double ConvertirTemperatura(double valor)
    {
        if (escalaConversion == "CelsiusAFahrenheit")
        {
            return (valor * 9 / 5) + 32;
        }
        else if (escalaConversion == "FahrenheitACelsius")
        {
            return (valor - 32) * 5 / 9;
        }
        else
        {
            Console.WriteLine("Escala de conversión no válida.");
            return double.NaN;
        }
    }

    static void Main(string[] args)
    {
        double temperaturaOriginal = 25.0;
        double temperaturaConvertida = ConvertirTemperatura(temperaturaOriginal);

        Console.WriteLine($"Temperatura original: {temperaturaOriginal}");
        Console.WriteLine($"Temperatura convertida ({escalaConversion}): {temperaturaConvertida}");
    }
}

