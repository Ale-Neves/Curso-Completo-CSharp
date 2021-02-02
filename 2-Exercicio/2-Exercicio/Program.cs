using System;

namespace _2_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');

            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            float altura = float.Parse(vet[2]);


            Console.WriteLine("\n{0}\n{1}\n{2:f2}\n{3}\n{4}\n{5:f2}\n", nome, quartos, preco, ultimoNome, idade, altura);
        }
    }
}
