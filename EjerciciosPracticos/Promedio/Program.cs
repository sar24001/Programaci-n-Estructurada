using System;

class Programa
{
    static void CalcularPromedio()
    {
        // Solicitar y leer tres notas del usuario
        Console.Write("Ingresa la primera nota: ");
        string entrada1 = Console.ReadLine();

        Console.Write("Ingresa la segunda nota: ");
        string entrada2 = Console.ReadLine();

        Console.Write("Ingresa la tercera nota: ");
        string entrada3 = Console.ReadLine();

        // Validar y convertir las entradas
        if (double.TryParse(entrada1, out double nota1) &&
            double.TryParse(entrada2, out double nota2) &&
            double.TryParse(entrada3, out double nota3))
        {
            // Calcular el promedio usando variables locales
            double suma = nota1 + nota2 + nota3;
            double promedio = suma / 3;

            Console.WriteLine($"El promedio de las tres notas es: {promedio:F2}");
        }
        else
        {
            Console.WriteLine("Una o más entradas no son válidas. Por favor ingresa números.");
        }
    }

    static void Main(string[] args)
    {
        CalcularPromedio(); 
    }
}
