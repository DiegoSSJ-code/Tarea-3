using System;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, p, Pot;
            Console.WriteLine("Ingrese el numero que desea hacer la potencia: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la potencia: ");
            p = double.Parse(Console.ReadLine());
            Pot = Math.Pow(n, p);
            Console.WriteLine("La potencia de " + n + "a " + p + "es : " + Pot);
        }
    }
}
