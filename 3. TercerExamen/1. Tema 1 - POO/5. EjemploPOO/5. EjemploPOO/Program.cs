using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.EjemploPOO
{
    internal class Program
    {
        public class Empleado
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Cargo { get; set; }
            public decimal Sueldo { get; set; }

            // Constructor 1: Por defecto (sin parámetros)
            public Empleado()
            {
                Id = 0;
                Nombre = "Sin Asignar";
                Cargo = "General";
                Sueldo = 2250.00m; // Salario base por defecto
            }

            // Constructor 2: Con parámetros básicos
            public Empleado(int id, string nombre) : this()
            {
                Id = id;
                Nombre = nombre;
            }

            // Constructor 3: Parametrizado completo
            public Empleado(int id, string nombre, string cargo, decimal sueldo)
            {
                Id = id;
                Nombre = nombre;
                Cargo = cargo;
                Sueldo = sueldo;
            }

            // Destructor
            ~Empleado()
            {
                // Código de limpieza simbólico
                System.Diagnostics.Debug.WriteLine($"El objeto Empleado '{Nombre}' ha sido destruido.");
            }

            public void ImprimirFicha()
            {
                Console.WriteLine($"[ID: {Id}] {Nombre} - Cargo: {Cargo} | Sueldo: {Sueldo:C}");
            }
        }

        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado();
            Empleado emp2 = new Empleado(101, "Lucía Morales");
            Empleado emp3 = new Empleado(102, "Marcos Ramos", "Jefe de Sistemas", 8500.00m);

            emp1.ImprimirFicha();
            emp2.ImprimirFicha();
            emp3.ImprimirFicha();

            Console.ReadLine();

        }
    }
}
