using System;

namespace Capitulo2_e1
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            float baseP;
            float alturaP;
            float numeroP;
            float area;
            Console.WriteLine("ingrese la base del poligono ");
            
            valor = Console.ReadLine();
            baseP = Convert.ToSingle(valor);
            Console.WriteLine("ingrese la altura del poligono ");
            valor = Console.ReadLine();
            alturaP = Convert.ToSingle(valor);
            
            Console.WriteLine("ingrese el numero de lados del poligono ");
            valor = Console.ReadLine();
            numeroP = Convert.ToSingle(valor);
            

            area = (numeroP * baseP * alturaP) / 2;
            Console.WriteLine("el area del el poligono es {0}", area);

        }
    }
}
