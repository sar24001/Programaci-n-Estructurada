using System;
using System.Collections.Generic;

namespace SistemaNomina
{
    // Clase que representa a un empleado
    class Empleado
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Deducciones { get; set; }

        public decimal CalcularSalarioNeto()
        {
            return SalarioBase - Deducciones;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = IngresarEmpleados();
            MostrarResultados(empleados);
        }

        // Subproblema 1: Ingreso de empleados
        static List<Empleado> IngresarEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            Console.Write("¿Cuántos empleados desea ingresar? ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nEmpleado #{i + 1}");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Salario base: ");
                decimal salarioBase = decimal.Parse(Console.ReadLine());

                Console.Write("Deducciones: ");
                decimal deducciones = decimal.Parse(Console.ReadLine());

                lista.Add(new Empleado
                {
                    Nombre = nombre,
                    SalarioBase = salarioBase,
                    Deducciones = deducciones
                });
            }

            return lista;
        }

        // Subproblema 2 y 3: Cálculo y presentación
        static void MostrarResultados(List<Empleado> empleados)
        {
            Console.WriteLine("\n--- Resultados de Nómina ---");
            foreach (var emp in empleados)
            {
                decimal salarioNeto = emp.CalcularSalarioNeto();
                Console.WriteLine($"Empleado: {emp.Nombre}");
                Console.WriteLine($"Salario Base: {emp.SalarioBase:C}");
                Console.WriteLine($"Deducciones: {emp.Deducciones:C}");
                Console.WriteLine($"Salario Neto: {salarioNeto:C}\n");
            }
        }
    }
}
