using System;

namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            double numeroConta = double.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string op = Console.ReadLine();

            if(op == "s" || op == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine("\nDados da conta: \n" + conta);

            Console.Write("\nEntre um valor para depósito: ");
            double depositar = double.Parse(Console.ReadLine());
            conta.Depositos(depositar);
            Console.WriteLine("Dados da conta atualizados: \n" + conta);

            Console.Write("\nEntre um valor para saque: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: \n" + conta);
        }
    }
}
