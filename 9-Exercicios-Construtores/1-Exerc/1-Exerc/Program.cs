using System;
using System.Globalization;

namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV LG";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

        }
    }
}
