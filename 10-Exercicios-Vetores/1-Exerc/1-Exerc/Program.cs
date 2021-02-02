using System;

namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double soma = 0.0, media = 0.0;
            Produto[] vet = new Produto[n];

            for (int i =0; i< 3; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());


                vet[i] = new Produto { Nome = nome, Preco = preco};

                soma += vet[i].Preco; 
            }

            media = soma / n;

            Console.WriteLine("AVERAGE HEIGHT = {0:f2}", media);
        }
    }
}
