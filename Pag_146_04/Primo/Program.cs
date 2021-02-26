using System;

namespace Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int div = 1;
            int contador = 0;
            for(int i = 2; i < 1001; i++)
            {
                contador = 0;
                for (div = 1; div <=i; div++)
                {
                    if (i % div == 0)
                    {
                        contador++;
                    }
                    if (contador < 3)
                    {
                        Console.WriteLine("El " + i + "es un numero primo");
                    }
                }
            }
        }
    }
}
