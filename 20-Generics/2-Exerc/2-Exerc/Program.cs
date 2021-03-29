using System;
using System.Collections.Generic;
using _2_Exerc.Entities;
using _2_Exerc.Services;

namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i =0; i<n; i++)
            {
                string[] vect = Console.ReadLine().Split(",");
                string name = vect[0];
                double price = double.Parse(vect[1]);

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);
            Console.WriteLine("Max: " + max);
        }
    }
}
