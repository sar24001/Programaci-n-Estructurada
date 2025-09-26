using System;
class SumaAcumulada
{
    static void sumaTotal = 0;
    static void Main()
        {
            Sumar(5);
            Sumar(10);
            Sumar(15);
        }
    static void Sumar(int numero)
    {
        sumaTotal += numero;
        Console.WriteLine("Suma acumulada: " + sumaTotal);
    }
}
