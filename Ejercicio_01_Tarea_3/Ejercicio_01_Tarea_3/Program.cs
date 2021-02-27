using System;

namespace Ejercicio_01_Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Por favor Digite un número: ");
                num = int.Parse(Console.ReadLine());
                verif(num);
            } while (num < 0);
            fact(num);
        }
        static void verif(int n)
        {
            if (n < 0)
            {
                Console.Write("\nError: No existe el factorial de un número negativo!!!!!\n");
            }
        }
        static void fact(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de {0} es: {1}", n, fact);
        }
    }
}
