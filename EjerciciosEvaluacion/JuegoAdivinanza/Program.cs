using System;

class JuegoAdivinanza
{
    // Variable global: número secreto
    static int numeroSecreto = new Random().Next(1, 101); // entre 1 y 100

    // Variable global: contador de intentos
    static int intentos = 0;

    // Método que pide al usuario que adivine (usa variables locales)
    static int PedirAdivinanza()
    {
        Console.Write("Ingresa tu adivinanza (1-100): ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int adivinanza))
        {
            return adivinanza;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Se tomará como 0.");
            return 0;
        }
    }

    // Método que evalúa la adivinanza y actualiza el contador
    static void EvaluarAdivinanza(int intentoUsuario)
    {
        intentos++;

        if (intentoUsuario == numeroSecreto)
        {
            Console.WriteLine($"¡Correcto! El número secreto era {numeroSecreto}.");
            Console.WriteLine($"Número de intentos: {intentos}");
        }
        else if (intentoUsuario < numeroSecreto)
        {
            Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
        }
        else
        {
            Console.WriteLine("Demasiado alto. Intenta de nuevo.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al juego de adivinanza.");
        Console.WriteLine("Adivina el número secreto entre 1 y 100.");

        int intento;
        do
        {
            intento = PedirAdivinanza();
            EvaluarAdivinanza(intento);
        } while (intento != numeroSecreto);
    }
}
