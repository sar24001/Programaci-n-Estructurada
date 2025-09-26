using System;

class TiendaEnLinea
{
    // Variable global que almacena el total del carrito
    static double carritoTotal = 0;

    // Método para agregar un producto
    static void AgregarProducto()
    {
        Console.Write("Ingresa el precio del producto a agregar: ");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double precio) && precio > 0)
        {
            carritoTotal += precio;
            Console.WriteLine($"Producto agregado. Total actual: {carritoTotal:F2}");
        }
        else
        {
            Console.WriteLine("Precio inválido. Ingresa un número positivo.");
        }
    }

    // Método para eliminar un producto
    static void EliminarProducto()
    {
        Console.Write("Ingresa el precio del producto a eliminar: ");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double precio) && precio > 0)
        {
            if (precio <= carritoTotal)
            {
                carritoTotal -= precio;
                Console.WriteLine($"Producto eliminado. Total actual: {carritoTotal:F2}");
            }
            else
            {
                Console.WriteLine("El precio excede el total del carrito.");
            }
        }
        else
        {
            Console.WriteLine("Precio inválido. Ingresa un número positivo.");
        }
    }

    // Método para consultar el total actual
    static void ConsultarTotal()
    {
        Console.WriteLine($"Total actual de la compra: {carritoTotal:F2}");
    }

    // Menú principal
    static void MostrarMenu()
    {
        int opcion;
        do
        {
            Console.WriteLine("\nMENÚ DE TIENDA EN LÍNEA");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Consultar total");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción (1-4): ");

            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarProducto();
                        break;
                    case 2:
                        EliminarProducto();
                        break;
                    case 3:
                        ConsultarTotal();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar la tienda. ¡Hasta pronto!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingresa un número del 1 al 4.");
            }

        } while (opcion != 4);
    }

    static void Main(string[] args)
    {
        MostrarMenu(); // Inicia el menú interactivo
    }
}
