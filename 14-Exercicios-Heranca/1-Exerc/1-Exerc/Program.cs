using System;
using _1_Exerc.Entities;
namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cont = new Conta(1, "Marcelo", 1500.00);

            ContaDeNegocio contNegocio = new ContaDeNegocio(2, "Alexandre", 550.00 , 200.00);

            // UPCASTING

            Conta conta1 = new Conta(1, "Pedro", 300.00);

            Conta conta2 = new ContaPoupanca(2, "Maria", 300.00, 0.10);

            Conta conta3 = new ContaDeNegocio(3, "Joao", 300.00, 200.00);

            conta1.Sacar(10.00); 
            conta2.Sacar(10.00);
            conta3.Sacar(10.00);

            Console.WriteLine(conta1.Saldo); // Resultado: 285.00
            Console.WriteLine(conta2.Saldo); // Resultado: 290.00
            Console.WriteLine(conta3.Saldo); // Resultado: 290.00
        }
    }
}
