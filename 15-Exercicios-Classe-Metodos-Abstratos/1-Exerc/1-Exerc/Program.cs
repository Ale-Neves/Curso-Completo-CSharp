using System;
using System.Collections.Generic;
using _1_Exerc.Entities.Enums;
using _1_Exerc.Entities;
namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> listFormas = new List<Forma>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                Console.Write("\nShape #{0} data: ", (i + 1));
                Console.Write("Rectangle or Circle (r/c)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Cores cor = Enum.Parse<Cores>(Console.ReadLine());
                if (op == 'r')
                {
                    Console.Write("Width: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Height:  ");
                    double altura = double.Parse(Console.ReadLine());

                    listFormas.Add(new Retangulo(cor, largura, altura));
                }
                else
                {
                    Console.Write("Radius: ");
                    double largura = double.Parse(Console.ReadLine());

                    listFormas.Add(new Circulo(cor, largura));
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach(Forma fm in listFormas)
            {
                Console.WriteLine(fm.Area().ToString("f2")); 
            }
        }
    }
}
