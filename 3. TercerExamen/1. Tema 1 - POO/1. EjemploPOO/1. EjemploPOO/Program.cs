using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.EjemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class Auto
        {
            // Atributos / Campos
            public string Marca;
            public string Modelo;
            public int Anio;

            // Método
            public void Arrancar()
            {
                Console.WriteLine($"El auto {Marca} {Modelo} está arrancando...");
            }
        }

    }
}
