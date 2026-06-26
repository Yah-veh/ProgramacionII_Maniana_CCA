using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el dia");
            int aux = int.Parse(Console.ReadLine());
            switch ( aux)
            {
                case 1:
                    {
                        Console.WriteLine("Lunes");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Ingrese un numero");
                        break;
                    }

            }

            /*

            Console.WriteLine("Ingrese la nota");
            int num = int.Parse(Console.ReadLine());

            if (num >= 90)
            {
                Console.WriteLine("Excelente");
            }
            else if (num >= 70)
            {
                Console.WriteLine("Bueno");
            }
            else if (num >= 51)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }


            /*
            Console.WriteLine("Ingrese el numero");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                    Console.WriteLine("Impar");
            }
            */
        }
    }
}
