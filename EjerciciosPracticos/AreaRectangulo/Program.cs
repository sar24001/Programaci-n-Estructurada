using System;
class AreaRectangulo
{
    static void Main()
    {
        CalcularArea();
    }
    static void CalcularArea()
    {
        Console.WriteLine("Ingrese la base del rectángulo:");
        double baseRectangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del rectángulo:");
        double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
        double area = baseRectangulo * alturaRectangulo;
        Console.WriteLine("El área del rectángulo es: " + area);
    }
}
