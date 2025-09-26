using System;

class SumaAcumulada
{
    static int sumaTotal = 0;

    static void AgregarNumero()
    {
        Console.Write("Ingresa un número para sumar: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero))
        {
            sumaTotal += numero;
            Console.WriteLine($"Suma acumulada actual: {sumaTotal}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor ingresa un número entero.");
        }
    }

    static void Main(string[] args)
    {
        AgregarNumero();
        AgregarNumero();
        AgregarNumero();
    }
}
