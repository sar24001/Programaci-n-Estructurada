using System;

class Inventario
{
    // Variable global que almacena el total de productos
    static int totalProductos = 0;

    // Método para agregar productos
    static void AgregarProductos()
    {
        Console.Write("Cantidad a agregar: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int cantidad) && cantidad > 0)
        {
            totalProductos += cantidad;
            Console.WriteLine($"Se agregaron {cantidad} productos.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ingresa un número positivo.");
        }

        ConsultarInventario();
    }

    // Método para retirar productos
    static void RetirarProductos()
    {
        Console.Write("Cantidad a retirar: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int cantidad) && cantidad > 0)
        {
            if (cantidad <= totalProductos)
            {
                totalProductos -= cantidad;
                Console.WriteLine($"Se retiraron {cantidad} productos.");
            }
            else
            {
                Console.WriteLine("No hay suficientes productos en inventario.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ingresa un número positivo.");
        }

        ConsultarInventario();
    }

    // Método para consultar el inventario actual
    static void ConsultarInventario()
    {
        Console.WriteLine($"Inventario actual: {totalProductos} productos.");
    }

    static void Main(string[] args)
    {
        // Simulación de acciones
        AgregarProductos();
        RetirarProductos();
        ConsultarInventario();
    }
}

