using System;

namespace _1._1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] vet = new Aluguel[10];

            for(int i =0; i < n; i++)
            {
                Console.WriteLine("\nAluguel #{0}:", i + 1);

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int opQuarto = int.Parse(Console.ReadLine());

                vet[opQuarto] = new Aluguel { Nome = nome, Email = email };
            }

            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < 10; i++)
            {
                if(vet[i] != null)
                {
                    Console.WriteLine("{0}: {1}, {2}", i, vet[i].Nome, vet[i].Email);
                }
                else
                {
                    Console.WriteLine("{0}: Quarto - Desocupado", i);
                }   
            }
        }
    }
}
