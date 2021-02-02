using System;

namespace _4_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i =0; i < n; i ++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int valor1 = int.Parse(vet[0]);
                int valor2 = int.Parse(vet[1]);
                double divisao = 0.0;


                if (valor2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = (double) valor1 / valor2;
                    Console.WriteLine("{0:f1}", divisao);
                }
            }
        }
    }
}
