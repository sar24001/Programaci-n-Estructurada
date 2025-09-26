using System;

class Juego
{
    // Variable global que almacena la puntuación
    static int puntuacion = 0;

    // Método que suma 10 puntos y muestra el total
    static void GanarPuntos()
    {
        puntuacion += 10;
        Console.WriteLine($"Puntuación actual: {puntuacion}");
    }

    static void Main(string[] args)
    {
        // Simulación de llamadas al método
        GanarPuntos(); // +10
        GanarPuntos(); // +10
        GanarPuntos(); // +10
    }
}
