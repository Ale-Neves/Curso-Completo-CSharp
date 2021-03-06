using System;
using _2_Exerc_Fixacao.Entities;
using _2_Exerc_Fixacao.Services;
using System.Collections.Generic;

namespace _2_Exerc_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contract> listContrato = new List<Contract>();

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            ContratService contractService = new ContratService(new PayPal());
            contractService.processContract(contract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
