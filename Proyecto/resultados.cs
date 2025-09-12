static void MostrarResultados(List<Empleado> empleados)
{
    Console.WriteLine("\n=== Resultados de Nómina ===");
    foreach (var emp in empleados)
    {
        Console.WriteLine($"Empleado: {emp.Nombre}");
        Console.WriteLine($"Salario Neto: {emp.CalcularSalarioNeto():C2}");
        Console.WriteLine("-----------------------------");
    }
}
