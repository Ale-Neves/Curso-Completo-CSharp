using System;
using _2_Exerc.Entities;
using _2_Exerc.Entities.Exceptions;

namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados da conta");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Valor Inicial: ");
            double valorInicial = double.Parse(Console.ReadLine());
            Console.Write("Limite de Saque:  ");
            double limitSaque = double.Parse(Console.ReadLine());

            Conta c = new Conta(numero, titular, valorInicial, limitSaque);

            Console.Write("\nInsira o valor para sacar:  ");
            double sacar = double.Parse(Console.ReadLine());

            try
            {
                c.Sacar(sacar);
                Console.WriteLine(c);
            }
            catch (DominioException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
