using System;

namespace _1._3_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome:");
            p.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque:");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);

            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("\nDigite o número de produtos a ser removido do estoque:");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);

            Console.WriteLine("\nDados atualizados: " + p);
        }
    }
}
