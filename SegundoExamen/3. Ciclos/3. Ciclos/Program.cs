using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("Tamanio de vector");
            int n = int.Parse(Console.ReadLine());

            int[] vec = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Valor del vector " + (i+1)) ;
                vec[i] = int.Parse(Console.ReadLine());
                suma = suma + vec[i];
            }
            Console.WriteLine("La suma total es: " + suma);



            /*
            Console.WriteLine("Ingrese su clave");
            int clave = int.Parse(Console.ReadLine());

            while(clave != 1234)
            {
                Console.WriteLine("Clave Incorrecta. Intente de nuevo");
                clave = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Bienvenido al Sistema");
            
            
            /*
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Numero "+ i);
            }
            */

        }
    }
}
