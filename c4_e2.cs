using System;

namespace Capitulo4_e2
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            Double numero;
            Double Potencia;
            Console.WriteLine("numero");
            valor = Console.ReadLine();
            numero = Convert.ToDouble(valor);
            Console.WriteLine("potencia");
            valor = Console.ReadLine();
            Potencia = Convert.ToDouble(valor);


            for (int i = 0; i < Potencia; i++)
            {
                numero *= numero;
            }

            Console.WriteLine("El resultado es: {0}", numero);
        }
    }
}
