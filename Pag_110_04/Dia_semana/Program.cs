using System;

namespace Dia_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese un numero del 1 al 7: ");
            n = Int16.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Ingrese un numero válido por favor");
                    break;
            }
        }
    }
}
