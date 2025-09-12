static List<Empleado> IngresarEmpleados()
{
    List<Empleado> empleados = new List<Empleado>();

    Console.Write("¿Cuántos empleados desea ingresar? ");
    int cantidad = int.Parse(Console.ReadLine());

    for (int i = 0; i < cantidad; i++)
    {
        Console.WriteLine($"\nEmpleado #{i + 1}");

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Salario base: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.Write("Deducciones: ");
        double deducciones = double.Parse(Console.ReadLine());

        empleados.Add(new Empleado
        {
            Nombre = nombre,
            SalarioBase = salarioBase,
            Deducciones = deducciones
        });
    }

    return empleados;
}
