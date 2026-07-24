using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _3.EjemploPOO
{
    internal class Program
    {
        public class CuentaBancaria
        {
            public string NumeroCuenta;
            public string Titular;
            public decimal Saldo;

            public void Depositar(decimal monto)
            {
                if (monto > 0)
                {
                    Saldo += monto; // saldo = saldo + monto
                    Console.WriteLine($"[+] Depósito exitoso de {monto:C}. Nuevo Saldo: {Saldo:C}");
                }
                else
                {
                    Console.WriteLine("[-] El monto a depositar debe ser mayor a 0.");
                }
            }

            public bool Retirar(decimal monto)
            {
                if (monto > 0 && monto <= Saldo)
                {
                    Saldo -= monto; // saldo = saldo - monto
                    Console.WriteLine($"[-] Retiro exitoso de {monto:C}. Saldo restante: {Saldo:C}");
                    return true;
                }
                else
                {
                    Console.WriteLine("[-] Fondos insuficientes o monto no válido.");
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria();
            cuenta1.NumeroCuenta = "100-58921-X";
            cuenta1.Titular = "Roberto Gómez";
            cuenta1.Saldo = 500.00m;

            cuenta1.Depositar(250.00m);
            cuenta1.Retirar(1000.00m); // Debería fallar por saldo insuficiente
            cuenta1.Retirar(300.00m);  // Debería ser exitoso
            cuenta1.Depositar(2500.00m);
            cuenta1.Retirar(1000.00m);
            Console.ReadLine();
        }
    }


    
}
