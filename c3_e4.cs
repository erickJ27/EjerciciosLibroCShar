using System;

namespace Capitulo3_e4
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            Double numero;
            Console.WriteLine("Ingrese un numero de 1 al 7 ");
            valor = Console.ReadLine();
            numero = Convert.ToDouble(valor);

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabados");
                    break;
                case 7:
                    Console.WriteLine("Domingos");
                    break;
            }
        }
    }
}
