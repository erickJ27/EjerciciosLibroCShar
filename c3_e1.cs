using System;

namespace Capitulo3_e1
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            Double numero;
            Console.WriteLine("Ingrese el numero ");
            valor = Console.ReadLine();
            numero = Convert.ToDouble(valor);

            if (numero % 2 == 0)
                Console.WriteLine("El numero es par");
            else
                Console.WriteLine("El numero es inpar");



        }
    }
}
