using System;
using System.Collections.Generic;

class RegistroUsuarios
{
    // Lista global que almacena los nombres de usuarios registrados
    static List<string> usuariosRegistrados = new List<string>();

    // Método para registrar un nuevo usuario
    static void RegistrarUsuario()
    {
        Console.Write("Ingresa el nombre de usuario a registrar: ");
        string nuevoUsuario = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nuevoUsuario))
        {
            Console.WriteLine("El nombre no puede estar vacío.");
            return;
        }

        if (usuariosRegistrados.Contains(nuevoUsuario))
        {
            Console.WriteLine("El usuario ya está registrado.");
        }
        else
        {
            usuariosRegistrados.Add(nuevoUsuario);
            Console.WriteLine($"Usuario '{nuevoUsuario}' registrado correctamente.");
        }
    }

    // Método para validar si un usuario ya existe
    static void ValidarUsuario()
    {
        Console.Write("Ingresa el nombre de usuario a validar: ");
        string usuario = Console.ReadLine();

        if (usuariosRegistrados.Contains(usuario))
        {
            Console.WriteLine($"El usuario '{usuario}' está registrado.");
        }
        else
        {
            Console.WriteLine($"El usuario '{usuario}' no existe en el sistema.");
        }
    }

    // Método para mostrar todos los usuarios registrados
    static void MostrarUsuarios()
    {
        Console.WriteLine("Lista de usuarios registrados:");

        if (usuariosRegistrados.Count == 0)
        {
            Console.WriteLine("No hay usuarios registrados.");
        }
        else
        {
            foreach (string usuario in usuariosRegistrados)
            {
                Console.WriteLine($"• {usuario}");
            }
        }
    }

    static void Main(string[] args)
    {
        // Simulación de acciones
        RegistrarUsuario();
        ValidarUsuario();
        MostrarUsuarios();
    }
}
