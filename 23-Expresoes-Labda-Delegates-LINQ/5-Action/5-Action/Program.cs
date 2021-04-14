using System;
using System.Collections.Generic;
using _5_Action.Entities;

namespace _5_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //1° Versão
            list.ForEach(UpadatePrice);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

            //2° Versão Utilizando Action
            Action<Product> act = UpadatePrice;
            list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            //3° Versão Utilizando Action + expressão lambda
            Action<Product> act2 = p => { p.Price += p.Price * 0.1; };
            list.ForEach(act2);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            //4° Versão Utilizando expressão lambda
            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        //Metodo simples que atualiza preço de um produto.
        static void UpadatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
