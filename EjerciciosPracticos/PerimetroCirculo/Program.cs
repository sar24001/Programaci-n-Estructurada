using System;

class Geometria
{
    // Método que recibe el radio y retorna el perímetro
    static double CalcularPerimetro(double radio)
    {
        // Variable local para el valor de PI
        double pi = Math.PI;

        // Variable local para el perímetro
        double perimetro = 2 * pi * radio;

        return perimetro;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingresa el radio del círculo: ");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double radio))
        {
            double resultado = CalcularPerimetro(radio);
            Console.WriteLine($"El perímetro del círculo es: {resultado:F2}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor ingresa un número.");
        }
    }
}
