using System;
using System.Collections.Generic;
using _4_Predicate.Entities;

namespace _4_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando obj do tipo product
            List<Product> list = new List<Product>();

            //Adicionando a Lista
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Remove apartir da expressão lambda
            list.RemoveAll(p => p.Price >= 100.00);

            //Imprimindo
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
