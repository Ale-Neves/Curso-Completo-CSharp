using System;

namespace _5_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int p1Codigo = int.Parse(vet[0]);
            int p1Quantidade = int.Parse(vet[1]);
            double p1Valor = double.Parse(vet[2]);

            vet = Console.ReadLine().Split(' ');
            int p2Codigo = int.Parse(vet[0]);
            int p2Quantidade = int.Parse(vet[1]);
            double p2Valor = double.Parse(vet[2]);

            double total = (p1Quantidade * p1Valor) + (p2Quantidade  * p2Valor);

            Console.WriteLine("VALOR A PAGAR: R$ {0:f2}", total);

        }
    }
}
