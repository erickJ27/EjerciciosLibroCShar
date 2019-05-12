using System;

namespace Capitulo2_e5
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            double dolares;
            double euros;
            Console.WriteLine("Ingrese los dolares a convertir");
            valor = Console.ReadLine();
            dolares = Convert.ToDouble(valor);

            euros = dolares * 0.89;
            Console.WriteLine("En euros {0}",euros);
        }
    }
}
