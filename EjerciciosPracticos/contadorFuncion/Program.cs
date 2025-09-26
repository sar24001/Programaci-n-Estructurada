using System;
class ContadorFuncion
{
    static int contador = 0;
    static void Main()
    {
        EjecutarFuncion();
        EjecutarFuncion();
        EjecutarFuncion();  
    }
    static void EjecutarFuncion()
    {
        contador++;
        Console.WriteLine("La función se ha ejecutado {0} veces.", contador);
    }
}
