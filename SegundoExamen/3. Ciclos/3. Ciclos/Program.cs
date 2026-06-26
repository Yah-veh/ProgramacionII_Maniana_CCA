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
