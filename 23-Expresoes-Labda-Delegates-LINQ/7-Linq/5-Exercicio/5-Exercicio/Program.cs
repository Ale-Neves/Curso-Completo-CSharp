using _5_Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _5_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path:");
            string path = Console.ReadLine();

            Console.Write("Enter salary:");
            double pesquisaSalario = double.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string nome = fields[0];
                    string email = fields[1];
                    double salario = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(nome, email, salario));
                }
            }

            var pegaEmailComBaseSalario = list.Where(p => p.Salario > pesquisaSalario).OrderBy(p => p.Email).Select(p => p.Email);

            Console.WriteLine("Email of people whose salary is more than 2000.00: ");

            foreach (string obj in pegaEmailComBaseSalario)
            {
                Console.WriteLine(obj);
            }

            var somaDosSalarios = list.Where(p => p.Nome[0] == 'M').Sum(p => p.Salario);

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + somaDosSalarios.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
