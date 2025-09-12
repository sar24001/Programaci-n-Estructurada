using System;
class Program
{
    static void Main()
    {
    // Iniciar el bloque try para capturar posibles excepciones de formato o desbordamiento
        try
        {
            // Solicitar y leer la cantidad de productos
            Console.Write("Cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            //Solicitar y leer el precio unitario del producto
            Console.Write("Precio unitario: ");
            decimal precioUnitario = Convert.ToDecimal(Console.ReadLine());

            // Calcular subtotal multiplicando cantidad por precio unitario, luego el IVA (15%) y total
            decimal subtotal = cantidad * precioUnitario;
            decimal iva = 0.15m * subtotal;
            decimal total = subtotal + iva;

            Console.WriteLine($"\nSubtotal: {subtotal:C}");
            Console.WriteLine($"IVA (15%): {iva:C}");
            Console.WriteLine($"Total a pagar: {total:C}");
        }
        // Capturar excepciones específicas y mostrar mensajes de error adecuados
        catch (FormatException)
        {
        // Manejar errores de formato en la entrada del usuario
            Console.WriteLine("Entrada inválida. Use solo números (ej. 10).");
        }
        // Capturar excepciones de desbordamiento numérico
        catch (OverflowException)
        {
            Console.WriteLine("Número muy grande. Ingrese un valor menor.");
        }
    }
}

