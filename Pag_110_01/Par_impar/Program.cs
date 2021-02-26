using System;

namespace Par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero: ");
            n = Int32.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
