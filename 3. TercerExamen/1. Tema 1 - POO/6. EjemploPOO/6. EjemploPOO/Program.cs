using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.EjemploPOO
{
    internal class Program
    {
        public class Impresora
        {
            // Método 1: Imprime un texto simple
            public void Imprimir(string texto)
            {
                Console.WriteLine($"[TEXTO]: {texto}");
            }

            // Método 2: Sobrecarga para imprimir números enteros
            public void Imprimir(int numero)
            {
                Console.WriteLine($"[ENTERO]: {numero}");
            }

            // Método 3: Sobrecarga para imprimir decimales con formato
            public void Imprimir(double numero, int decimales)
            {
                string formato = "F" + decimales;
                Console.WriteLine($"[DECIMAL]: {numero.ToString(formato)}");
            }

            // Método 4: Sobrecarga para imprimir un arreglo/vector
            public void Imprimir(string[] coleccion)
            {
                Console.WriteLine("[LISTA DE ELEMENTOS]:");
                foreach (var elemento in coleccion)
                {
                    Console.WriteLine($" - {elemento}");
                }
            }
        }


        static void Main(string[] args)
        {
            Impresora imp = new Impresora();

            imp.Imprimir("Hola a la clase de Programación II");
            imp.Imprimir(2026);
            imp.Imprimir(3.14159265, 2);
            imp.Imprimir(new string[] { "C#", "Visual Studio", "POO", "SQL Server" });

            Console.ReadLine();
        }
    }
}
