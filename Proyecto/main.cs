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
            decimal neto = SalarioBase - Deducciones;
            return neto < 0 ? 0 : neto; // Evitar negativos
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
            int cantidad;

            // Validación de cantidad de empleados
            while (true)
            {
                Console.Write("¿Cuántos empleados desea ingresar? ");
                if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0)
                    break;
                Console.WriteLine("Ingrese un número entero válido mayor que 0.");
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nEmpleado #{i + 1}");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                // Validación salario base
                decimal salarioBase;
                while (true)
                {
                    Console.Write("Salario base: ");
                    if (decimal.TryParse(Console.ReadLine(), out salarioBase) && salarioBase >= 0)
                        break;
                    Console.WriteLine("Ingrese un valor numérico válido para el salario base (>= 0).");
                }

                // Validación deducciones
                decimal deducciones;
                while (true)
                {
                    Console.Write("Deducciones: ");
                    if (decimal.TryParse(Console.ReadLine(), out deducciones) && deducciones >= 0)
                        break;
                    Console.WriteLine("Ingrese un valor numérico válido para las deducciones (>= 0).");
                }

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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- Resultados de Nómina ---");
            Console.ResetColor();

            decimal totalNomina = 0;

            foreach (var emp in empleados)
            {
                decimal salarioNeto = emp.CalcularSalarioNeto();
                totalNomina += salarioNeto;

                Console.WriteLine($"Empleado: {emp.Nombre}");
                Console.WriteLine($"Salario Base: {emp.SalarioBase:C}");
                Console.WriteLine($"Deducciones: {emp.Deducciones:C}");
                Console.WriteLine($"Salario Neto: {salarioNeto:C}\n");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"TOTAL A PAGAR EN NÓMINA: {totalNomina:C}");
            Console.ResetColor();
        }
    }
}
