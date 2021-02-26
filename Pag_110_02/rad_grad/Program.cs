using System;

namespace rad_grad
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;
            double radianes, grados, nradianes, ngrados;
            int op;
            Console.Write("¿Desea convertir grados a radianes o radianes a grados?");
            Console.Write("\n 1. Radianes a grados. \n 2. Grados a radianes. \n");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Write("\nIngrese el numero de radianes: ");
                    radianes = double.Parse(Console.ReadLine());
                    ngrados = radianes * (180 / pi);
                    Console.WriteLine(radianes + "pi rad con vertidos a grados son: " + ngrados + "°.");
                    break;
                case 2:
                    Console.Write("\nIngrese el numero de grados: ");
                    grados = double.Parse(Console.ReadLine());
                    nradianes = grados * (pi / 180);
                    Console.WriteLine(grados + "° convertidos a radianes son: " + nradianes + "pi rad.");
                    break;
                default:
                    Console.WriteLine("Opcion no válida o fuera de rango.");
                    break;

            }
        }
    }
}
