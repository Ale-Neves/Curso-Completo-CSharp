using System;

namespace _7_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            float x = float.Parse(vet[0]);
            float y = float.Parse(vet[1]);

            if(x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else
            {
                Console.WriteLine("Origem");
            }


        }
    }
}
