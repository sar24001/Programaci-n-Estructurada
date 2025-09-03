using System;

class FerreteriaVentas
{
    static void Main()
    {
        int totalProductos = 0;
        double totalVentas = 0;
        bool huboVentaMayorista = false;

        Console.WriteLine("CONTROL DIARIO DE VENTAS - FERRETERÍA");
        Console.WriteLine("Ingrese '0' como cantidad para finalizar el día.\n");

        while (true)
        {
            Console.Write("Cantidad de productos vendidos: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 0)
                break;

            Console.Write("Precio unitario (C$): ");
            double precioUnitario = double.Parse(Console.ReadLine());

            double subtotal = cantidad * precioUnitario;
            totalVentas += subtotal;
            totalProductos++;

            if (subtotal > 10000)
            {
                huboVentaMayorista = true;
                Console.WriteLine("⚠️ Alerta: Venta mayorista detectada (C$" + subtotal + ")");
            }

            Console.WriteLine("Subtotal de esta venta: C$" + subtotal + "\n");
        }

        Console.WriteLine("\n📊 RESUMEN DEL DÍA");
        Console.WriteLine("Total de ventas: C$" + totalVentas);
        Console.WriteLine("Número de productos registrados: " + totalProductos);

        if (huboVentaMayorista)
        {
            Console.WriteLine("⚠️ Se registraron ventas individuales mayores a C$10,000.");
        }
        else
        {
            Console.WriteLine("✅ No se detectaron ventas mayoristas.");
        }
    }
}
