using System;
using System.Collections.Generic;
using _3_Exerc.Entities;
namespace _3_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listProduto = new List<Produto>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());


            for(int i = 0; i<n; i++)
            {
                Console.Write("\nProduct #{0} data:", (i+1));
                Console.Write("\nCommon, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Price: ");
                double valor = double.Parse(Console.ReadLine());

                if (op == 'i')
                {
                    Console.Write("Customs fee: ");
                    double valorFrete = double.Parse(Console.ReadLine());
                    listProduto.Add(new ProdutoImportado(nome, valor, valorFrete));
                }
                else if (op == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY):  ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    listProduto.Add(new ProdutoUsado(nome, valor, data));
                }
                else
                {
                    listProduto.Add(new Produto(nome, valor));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach(Produto p in listProduto)
            {
                Console.WriteLine(p.EtiquetaPreco());
            }
        }
    }
}
