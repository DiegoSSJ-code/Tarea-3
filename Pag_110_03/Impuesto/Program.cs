using System;

namespace Impuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto;
            double impuesto, precio;
            Console.WriteLine("Ingrese el tipo de producto: ");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto");
            precio = double.Parse(Console.ReadLine());
            if (producto == "medicina")
            {
                impuesto = 0;
                Console.Write("El impuesto es de: " + impuesto);
            }
            else
            {
                impuesto = precio * 0.09;
                Console.Write("El impuesto es de: " + impuesto);
            }
        }
    }
}

