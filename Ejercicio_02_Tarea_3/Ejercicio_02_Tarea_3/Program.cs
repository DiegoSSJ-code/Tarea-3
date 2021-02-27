using System;

namespace Ejercicio_02_Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, n, i, aux;
            Console.Write("Ingrese el número de la serie que desea mostrar: ");
            n = int.Parse(Console.ReadLine());
            x = 0;
            y = 1;
            for (i = 0; i < n; i++)
            {
                aux = x;
                x = y;
                y = aux + x;
                Console.WriteLine(x);
            }
        }
    }
}