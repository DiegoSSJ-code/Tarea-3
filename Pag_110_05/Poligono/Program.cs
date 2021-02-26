using System;

namespace Poligono
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double a, b, A, P;
            Console.WriteLine("¿Qué desea calcular? \n 1. Area \n 2. Perimetro");
            op = Int16.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Write("Ingrese el lado a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el lado b: ");
                    b = double.Parse(Console.ReadLine());
                    A = a * b;
                    Console.Write("El area de su poligono es: "+ A);
                    break;
                case 2:
                    Console.Write("Ingrese el lado a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el lado b: ");
                    b = double.Parse(Console.ReadLine());
                    P = 2 * (a + b);
                    Console.Write("El perimetro de su poligono es: " + P);
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida!!!!");
                    break;
            }
        }
    }
}
