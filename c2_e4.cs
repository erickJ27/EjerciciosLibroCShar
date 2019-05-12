using System;

namespace Capitulo2_e4
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            double grado;
            double Fahrenheit;
            Console.WriteLine("Ingrese el grado");
            valor = Console.ReadLine();
            grado = Convert.ToDouble(valor);

            Fahrenheit = (grado*1.8)+32;
            Console.WriteLine("Radianes {0}", Fahrenheit);


        }
    }
}
