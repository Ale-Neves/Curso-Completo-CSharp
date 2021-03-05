using System;
using _1_Solucao_Sem_Interface.Entities;
using _1_Solucao_Sem_Interface.Services;

namespace _1_Solucao_Sem_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string modelo = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime entrada = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime saida = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter price per hour: ");
            double valorHora = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double valorDia = double.Parse(Console.ReadLine());

            AlugelDeCarros alugCar = new AlugelDeCarros(entrada, saida, new Veiculo(modelo));
            ServicoDeAluguel servAlug = new ServicoDeAluguel(valorHora, valorDia);

            servAlug.ProcessarFatura(alugCar);

            Console.WriteLine(alugCar.Fatura);
        }
    }
}
