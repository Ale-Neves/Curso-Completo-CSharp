using System;

namespace _1._2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double mediaSalario = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio = {0:f2}", mediaSalario);
        }
    }
}
