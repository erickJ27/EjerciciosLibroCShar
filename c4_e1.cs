using System;

namespace Capitulo4_e1
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            float numero;
            Console.WriteLine("De cual numero quiere saber la tabla de 1 al 10");
            valor = Console.ReadLine();
            numero = Convert.ToSingle(valor);
            for (int i = 1; i < 11; i++)
            {
                Console.Write("{0} * {1} =",i,numero);
                Console.WriteLine(numero*i);
            }

        }
    }
}
