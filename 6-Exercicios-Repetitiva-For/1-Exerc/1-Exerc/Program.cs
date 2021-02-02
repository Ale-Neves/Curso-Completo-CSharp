using System;

namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            
            for (int i = 0; i < n; i ++)
            {
                Console.Write("Valor #{0}: ", i+1);
                int valor = int.Parse(Console.ReadLine());
                soma += valor; 
            }
            Console.WriteLine("Soma = "+soma);
        }
    }
}
