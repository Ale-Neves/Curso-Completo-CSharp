using System;
using System.Collections.Generic;

namespace _01_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?");
            int qtEmpregados = int.Parse(Console.ReadLine());

            List<Empregado> listEmpregados = new List<Empregado>();

            for(int i = 0; i < qtEmpregados; i++)
            {
                Console.WriteLine("\nEmplyoee #{0}:", (i + 1));
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                listEmpregados.Add(new Empregado(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idDigitado = int.Parse(Console.ReadLine());

            Empregado idEncontrado = listEmpregados.Find(x => x.ID == idDigitado);

            if (idEncontrado != null)
            {
                Console.Write("Enter the percentage:");
                double porc = double.Parse(Console.ReadLine());
                idEncontrado.IncreaseSalary(porc);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees: ");
            foreach (Empregado obj in listEmpregados)
            {
                Console.WriteLine(obj);
            }
        }

    }
}
