using System;
using System.Collections.Generic;
using _2_Exerc.Etities;

namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> listCont = new List<Contribuinte>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Tax payer #{0} data:", (i+1));
                Console.Write("Individual or company (i/c)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name:  ");
                string nome = Console.ReadLine();
                Console.Write("Anual income: ");
                double rendimentoAnual = double.Parse(Console.ReadLine());

                if (op == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double dispesaSaude = double.Parse(Console.ReadLine());

                    listCont.Add(new Individual(nome, rendimentoAnual, dispesaSaude));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int func = int.Parse(Console.ReadLine());

                    listCont.Add(new Company(nome, rendimentoAnual, func));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            foreach(Contribuinte c in listCont)
            {
                Console.WriteLine(c.Nome + ": $ " + c.Taxa().ToString("f2"));
            }
        }
    }
}
