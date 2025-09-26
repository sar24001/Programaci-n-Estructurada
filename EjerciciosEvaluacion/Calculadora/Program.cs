using System;

class CalculadoraCientifica
{
    // Variable global que guarda el último resultado
    static double ultimoResultado = 0;

    // Método para sumar
    static void Sumar()
    {
        Console.Write("Ingresa dos números separados por espacio: ");
        string[] entrada = Console.ReadLine().Split();

        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);

        double resultado = a + b;
        ultimoResultado = resultado;

        Console.WriteLine($"Resultado: {resultado}");
    }

    // Método para restar
    static void Restar()
    {
        Console.Write("Ingresa dos números separados por espacio: ");
        string[] entrada = Console.ReadLine().Split();

        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);

        double resultado = a - b;
        ultimoResultado = resultado;

        Console.WriteLine($"Resultado: {resultado}");
    }

    // Método para multiplicar
    static void Multiplicar()
    {
        Console.Write("Ingresa dos números separados por espacio: ");
        string[] entrada = Console.ReadLine().Split();

        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);

        double resultado = a * b;
        ultimoResultado = resultado;

        Console.WriteLine($"Resultado: {resultado}");
    }

    // Método para dividir
    static void Dividir()
    {
        Console.Write("Ingresa dividendo y divisor separados por espacio: ");
        string[] entrada = Console.ReadLine().Split();

        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);

        if (b != 0)
        {
            double resultado = a / b;
            ultimoResultado = resultado;
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero.");
        }
    }

    // Método para potencia
    static void Potencia()
    {
        Console.Write("Ingresa base y exponente separados por espacio: ");
        string[] entrada = Console.ReadLine().Split();

        double baseNum = double.Parse(entrada[0]);
        double exponente = double.Parse(entrada[1]);

        double resultado = Math.Pow(baseNum, exponente);
        ultimoResultado = resultado;

        Console.WriteLine($"Resultado: {resultado}");
    }

    // Método para raíz cuadrada
    static void RaizCuadrada()
    {
        Console.Write("Ingresa el número para calcular su raíz cuadrada: ");
        string entrada = Console.ReadLine();

        double numero = double.Parse(entrada);

        if (numero >= 0)
        {
            double resultado = Math.Sqrt(numero);
            ultimoResultado = resultado;
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
        }
    }

    static void Main(string[] args)
    {
        // Simulación de operaciones
        Sumar();
        Restar();
        Multiplicar();
        Dividir();
        Potencia();
        RaizCuadrada();

        Console.WriteLine($"Último resultado calculado: {ultimoResultado}");
    }
}
