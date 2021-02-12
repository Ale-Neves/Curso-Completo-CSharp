using System;
using System.Collections.Generic;
using _2_Exerc.Entities;
namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionarios> listFunc = new List<Funcionarios>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("\nEmployee #{0} data:", (i+1));
                Console.Write("Outsourced (y/n)?");
                string op = Console.ReadLine();

                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Hours: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valorHora = double.Parse(Console.ReadLine());;

                if (op == "y" || op =="Y")
                {

                    Console.Write("Additional charge: ");
                    double valorAdd = double.Parse(Console.ReadLine());
                    listFunc.Add(new FuncionariosTercerizados(nome, horas, valorHora, valorAdd));
                }
                else
                {
                    listFunc.Add(new Funcionarios(nome, horas, valorHora));
                }
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("PAYMENTS:");
            foreach (Funcionarios func in listFunc)
            {
                Console.WriteLine(func.Nome + " - $ " + func.Pagamento().ToString("f2"));
            }
        }
    }
}
