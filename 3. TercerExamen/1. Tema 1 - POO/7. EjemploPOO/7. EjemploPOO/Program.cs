using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7.EjemploPOO
{
    internal class Program
    {
        public class NumeroComplejo
        {
            public double Real { get; set; }
            public double Imaginario { get; set; }

            public NumeroComplejo(double real, double imaginario)
            {
                Real = real;
                Imaginario = imaginario;
            }

            // Sobrecarga del operador '+'
            public static NumeroComplejo operator +(NumeroComplejo c1, NumeroComplejo c2)
            {
                return new NumeroComplejo(c1.Real + c2.Real, c1.Imaginario + c2.Imaginario);
            }

            // Sobrecarga del operador '-'
            public static NumeroComplejo operator -(NumeroComplejo c1, NumeroComplejo c2)
            {
                return new NumeroComplejo(c1.Real - c2.Real, c1.Imaginario - c2.Imaginario);
            }

            // Sobrecarga del operador '=='
            public static bool operator ==(NumeroComplejo c1, NumeroComplejo c2)
            {
                
                if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null)) return true;
                if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null)) return false;

                return c1.Real == c2.Real && c1.Imaginario == c2.Imaginario;
            }

            // Al sobrecargar '==' es obligatorio sobrecargar '!='
            public static bool operator !=(NumeroComplejo c1, NumeroComplejo c2)
            {
                return !(c1 == c2);
            }

            public override string ToString()
            {
                return $"{Real} + {Imaginario}i";
            }

            public override bool Equals(object obj)
            {
                if (obj is NumeroComplejo c)
                    return this == c;
                return false;
            }

 
        }

        static void Main(string[] args)
        {
            NumeroComplejo num1 = new NumeroComplejo(3.0, 4.5);
            NumeroComplejo num2 = new NumeroComplejo(1.5, 2.5);

            NumeroComplejo suma = num1 + num2;
            NumeroComplejo resta = num1 - num2;

            Console.WriteLine($"Número 1: {num1}");
            Console.WriteLine($"Número 2: {num2}");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");

            Console.WriteLine($"¿Son iguales?: {num1 == num2}");

            Console.ReadLine();

        }
    }
}
