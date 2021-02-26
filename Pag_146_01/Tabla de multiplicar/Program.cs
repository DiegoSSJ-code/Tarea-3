using System;

namespace Tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0,nt, resultado;
            Console.Write("Ingrese el numero que quieres calcular su tabla de multiplicar: ");
            nt = int.Parse(Console.ReadLine());
            Console.Write("Calculando la tabla del {0} ", nt);
            while (contador <= 9)
            {
                contador++;
                resultado = contador * nt;
                Console.WriteLine("\n \n" + nt + " * " + contador + " = " + resultado);
            }
        }
    }
}
