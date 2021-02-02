using System;

namespace _2._2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();

            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFuncionário: {0}, $ {1:f2}", fun.Nome, fun.SalarioLiquido());

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            fun.AumentaSalario(porcentagem);


            Console.WriteLine("\nDados atualizados: {0}, $ {1:f2}", fun.Nome, fun.SalarioLiquido());


        }
    }
}
