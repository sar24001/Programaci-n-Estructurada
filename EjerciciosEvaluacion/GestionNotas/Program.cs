using System;
using System.Collections.Generic;
using System.Linq;

class GestionNotas
{
    // Lista global que almacena todas las notas
    static List<double> notas = new List<double>();

    // Método para agregar una nota
    static void AgregarNota()
    {
        Console.Write("Ingresa una nota: ");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double nota) && nota >= 0 && nota <= 100)
        {
            notas.Add(nota);
            Console.WriteLine($"Nota agregada: {nota}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Ingresa una nota entre 0 y 100.");
        }
    }

    // Método para calcular el promedio (solo con variables locales)
    static void CalcularPromedio()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("No hay notas registradas.");
            return;
        }

        double suma = 0;
        foreach (double nota in notas)
        {
            suma += nota;
        }

        double promedio = suma / notas.Count;
        Console.WriteLine($"Promedio de notas: {promedio:F2}");
    }

    // Método para mostrar la nota más alta y más baja
    static void MostrarExtremos()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("No hay notas registradas.");
            return;
        }

        double notaMaxima = notas.Max();
        double notaMinima = notas.Min();

        Console.WriteLine($"Nota más alta: {notaMaxima}");
        Console.WriteLine($"Nota más baja: {notaMinima}");
    }

    static void Main(string[] args)
    {
        // Simulación de acciones
        AgregarNota();
        AgregarNota();
        CalcularPromedio();
        MostrarExtremos();
    }
}
