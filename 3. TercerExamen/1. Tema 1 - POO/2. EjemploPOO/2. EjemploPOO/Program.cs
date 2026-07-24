using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.EjemploPOO
{
    internal class Program
    {
        public class Estudiante
        {
            // Atributos
            public string Nombre;
            public string Carnet;
            public double NotaExamen1;
            public double NotaExamen2;

            // Método para calcular el promedio
            public double CalcularPromedio()
            {
                return (NotaExamen1 + NotaExamen2) / 2.0;
            }

            // Método para mostrar la información del estudiante
            public void MostrarInformacion()
            {
                Console.WriteLine($"Estudiante: {Nombre} | CI: {Carnet}");
                Console.WriteLine($"Promedio: {CalcularPromedio():F2}");
                Console.WriteLine(CalcularPromedio() >= 51 ? "Estado: APROBADO" : "Estado: REPROBADO");
                Console.WriteLine(new string('-', 40));

               }
        }

        static void Main(string[] args)
        {
            // Instanciación de objetos
            Estudiante est1 = new Estudiante();
            est1.Nombre = "Carlos Mendoza";
            est1.Carnet = "8492011";
            est1.NotaExamen1 = 65.5;
            est1.NotaExamen2 = 78.0;

            Estudiante est2 = new Estudiante();
            est2.Nombre = "Ana María Torres";
            est2.Carnet = "9123044";
            est2.NotaExamen1 = 40.0;
            est2.NotaExamen2 = 50.0;

            Estudiante est3 = new Estudiante();
            est3.Nombre = "Yerko Mancilla";
            est3.Carnet = "12345666";
            est3.NotaExamen1 = 91.50;
            est3.NotaExamen2 = 98.9;

            Estudiante est4 = new Estudiante();
            est4.Nombre = "Edson Balcera";
            est4.Carnet = "66666666";
            est4.NotaExamen1 = 99.50;
            est4.NotaExamen2 = 90.45;


            Estudiante est5 = new Estudiante();
            est5.Nombre = "Rodrigo Flores";
            est5.Carnet = "987454155";
            est5.NotaExamen1 = 100.00;
            est5.NotaExamen2 = 0.00;

            // Ejecución de métodos
            est1.MostrarInformacion();
            est2.MostrarInformacion();
            est3.MostrarInformacion();
            est4.MostrarInformacion();
            est5.MostrarInformacion();

            Console.ReadLine();

        }
    }
}
