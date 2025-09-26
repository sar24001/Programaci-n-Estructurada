using System;

class ControlSesion
{
    // Variable global que indica si la sesión está iniciada
    static bool sesionIniciada = false;

    // Contraseña predefinida 
    static string contraseñaCorrecta = "saralinas2025";

    // Funcion que simula el inicio de sesión
    static void IniciarSesion()
    {
        Console.Write("Ingresa la contraseña para iniciar sesión: ");
        string entrada = Console.ReadLine();

        if (entrada == contraseñaCorrecta)
        {
            sesionIniciada = true;
            Console.WriteLine("Sesión iniciada correctamente.");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta. Intenta nuevamente.");
        }

        Console.WriteLine($"Estado de sesión: {sesionIniciada}");
    }

    static void Main(string[] args)
    {
        IniciarSesion();
    }
}
