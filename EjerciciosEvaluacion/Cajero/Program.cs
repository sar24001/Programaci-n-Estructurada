using System;

class CajeroAutomatico
{
    // Variable global que representa el saldo de la cuenta
    static double saldoCuenta = 1000.00; // Saldo inicial

    // Método para depositar dinero
    static void Depositar()
    {
        Console.Write("Monto a depositar: ");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double monto) && monto > 0)
        {
            saldoCuenta += monto;
            Console.WriteLine($"Depósito exitoso. Nuevo saldo: {saldoCuenta:F2}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Ingresa un monto positivo.");
        }
    }

    // Método para retirar dinero
    static void Retirar()
    {
        Console.Write("Monto a retirar: ");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double monto) && monto > 0)
        {
            if (monto <= saldoCuenta)
            {
                saldoCuenta -= monto;
                Console.WriteLine($"Retiro exitoso. Nuevo saldo: {saldoCuenta:F2}");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Ingresa un monto positivo.");
        }
    }

    // Método para consultar el saldo actual
    static void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo actual: {saldoCuenta:F2}");
    }

    static void Main(string[] args)
    {
        // Simulación de operaciones
        ConsultarSaldo();
        Depositar();
        Retirar();
        ConsultarSaldo();
    }
}

