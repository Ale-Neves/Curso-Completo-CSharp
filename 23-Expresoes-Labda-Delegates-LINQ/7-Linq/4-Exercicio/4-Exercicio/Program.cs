using System;
using System.Collections.Generic;
using _4_Exercicio.Entities;
using System.IO;
using System.Linq;

namespace _4_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path:");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1]);

                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

            Console.WriteLine("Average price: " + avg.ToString("f2"));

            var abaixoPrecoMedio = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach(string obj in abaixoPrecoMedio)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
