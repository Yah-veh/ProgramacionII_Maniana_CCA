using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.EjemploPOO
{
    internal class Program
    {
        public class Producto
        {
            private string _codigo;
            private string _nombre;
            private decimal _precio;
            private int _stock;

            // Propiedad de solo lectura (Read-Only)
            public string Codigo
            {
                get { return _codigo; }
            }

            public string Nombre
            {
                get { return _nombre; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        _nombre = value;
                    else
                        Console.WriteLine("El nombre no puede estar vacío.");
                }
            }

            public decimal Precio
            {
                get { return _precio; }
                set
                {
                    if (value >= 0)
                        _precio = value;
                    else
                        Console.WriteLine("El precio no puede ser negativo.");
                }
            }

            public int Stock
            {
                get { return _stock; }
                private set { _stock = value; } // Modificable solo dentro de la clase
            }

            public Producto(string codigo, string nombre, decimal precio, int stockInicial)
            {
                _codigo = codigo;
                Nombre = nombre;
                Precio = precio;
                if (stockInicial >= 0) _stock = stockInicial;
            }

            public void AgregarStock(int cantidad)
            {
                if (cantidad > 0)
                    _stock += cantidad;
            }

            public void Vender(int cantidad)
            {
                if (cantidad > 0 && cantidad <= _stock)
                {
                    _stock -= cantidad;
                    Console.WriteLine($"Venta realizada. Stock restante de {_nombre}: {_stock}");
                }
                else
                {
                    Console.WriteLine($"Error: Stock insuficiente de {_nombre}.");
                }
            }
        }


        static void Main(string[] args)
        {
            Producto pro1 = new Producto("123", "Ever", 145.00m, 1500);
            pro1.Vender(2000);
            pro1.Vender(500);
            pro1.AgregarStock(3333);
        }
    }
}
