using System;
using _1_Exerc.Entities;
namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Numero Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome Titular: ");
            string nome = Console.ReadLine();
            Console.Write("Saldo da Conta: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.Write("Limite de Emprestimo: ");
            double limite = double.Parse(Console.ReadLine());

            ContaDeNegocio ctNegocio = new ContaDeNegocio(numero, nome, saldo, limite);

            Console.WriteLine("\n\n----------------------- ");
            Console.WriteLine("Numero Conta: " + ctNegocio.Numero);
            Console.WriteLine("Nome Titular: " + ctNegocio.Titular);
            Console.WriteLine("Saldo da Conta: " + ctNegocio.Saldo);
            Console.WriteLine("Limite de Emprestimo: " + ctNegocio.LimiteEmprestimo);
        }
    }
}
