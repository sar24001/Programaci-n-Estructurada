using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Cantidad: ");
            string inputCantidad = Console.ReadLine();
            int cantidad = int.Parse(inputCantidad);

            Console.Write("Precio unitario: ");
            string inputPrecio = Console.ReadLine();
            decimal precioUnitario = decimal.Parse(inputPrecio);

            decimal subtotal = cantidad * precioUnitario;
            decimal iva = 0.15m * subtotal;
            decimal total = subtotal + iva;

            Console.WriteLine($"\nSubtotal: {subtotal:C}");
            Console.WriteLine($"IVA (15%): {iva:C}");
            Console.WriteLine($"Total a pagar: {total:C}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Use solo números (ej. 10).");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Número muy grande. Ingrese un valor menor.");
        }
    }
}

