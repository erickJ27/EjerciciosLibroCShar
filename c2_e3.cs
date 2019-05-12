using System;

namespace Capitulo2_e3
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            double grado;
            double radianes;
            Console.WriteLine("Ingrese el grado");
            valor = Console.ReadLine();
            grado = Convert.ToDouble(valor);

            radianes = grado * 0.0174;
            Console.WriteLine("Radianes {0}", radianes);


        }
    }
}
