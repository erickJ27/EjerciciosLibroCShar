using System;

namespace Capitulo3_e5
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            float valorI;
            Console.WriteLine("Que desea Calcular");
            Console.WriteLine("1-Perimetro");
            Console.WriteLine("2-Area");
            Console.Write("opcion: ");
            valor = Console.ReadLine();
            valorI = Convert.ToSingle(valor);

            switch (valorI)
            {
                case 1:
                    string valor3;
                    float numeroP2;
                    float Perimetro;
                    float valorL;
                    
                    Console.WriteLine("ingrese el numero de lados del poligono ");
                    valor3 = Console.ReadLine();
                    numeroP2 = Convert.ToSingle(valor3);


                    for (int i = 0; i < numeroP2;i++) {

                        Console.WriteLine("ingrese el valor del lado {0}", i);
                        valor3 = Console.ReadLine();
                        valorL = Convert.ToSingle(valor3);
                        valorL += valorL;
                        Perimetro = valorL;
                    }
                   
                    Console.WriteLine("el perimetro del poligono es {0}", Perimetro);

                    break;
                case 2:
                    string valor2;
                    float baseP;
                    float alturaP;
                    float numeroP;
                    float area;
                    Console.WriteLine("ingrese la base del poligono ");

                    valor2 = Console.ReadLine();
                    baseP = Convert.ToSingle(valor);
                    Console.WriteLine("ingrese la altura del poligono ");
                    valor2 = Console.ReadLine();
                    alturaP = Convert.ToSingle(valor);

                    Console.WriteLine("ingrese el numero de lados del poligono ");
                    valor2 = Console.ReadLine();
                    numeroP = Convert.ToSingle(valor2);


                    area = (numeroP * baseP * alturaP) / 2;
                    Console.WriteLine("el area del el poligono es {0}", area);

                    break;
            }

            
        }
    }
}
