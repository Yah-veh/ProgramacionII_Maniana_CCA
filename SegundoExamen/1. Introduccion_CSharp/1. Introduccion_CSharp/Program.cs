using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Introduccion_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Espacio Principal del programa

            //WhiteLine = Mensaje con salto de linea
            Console.WriteLine("Este texto tiene salto de linea");
           
            //white = Mensaje SIN SALTO  de linea
            Console.Write("Este texto NO TIENE salto de linea");

            //WriteLine sin contenido SALTO DE LINEA
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Suma Sencilla
            int valor1 = 5;
            int valor2 = 10;

            int resultado = valor1 + valor2;

            Console.WriteLine(resultado);

            //Suma Sencilla con datos 1
            
            //Crear Tipo de variable
 
            Console.WriteLine("Ingrese el valor de A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de B");
            int b = int.Parse(Console.ReadLine());

            int suma = a + b;
            Console.WriteLine("El resultado es: " + suma);
            


        }
    }
}
