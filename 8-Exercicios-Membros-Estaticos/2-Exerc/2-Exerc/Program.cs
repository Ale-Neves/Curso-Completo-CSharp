using System;

namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a cotação do dólar?");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar?");
            ConversorDeMoeda.ValorDeCompra = double.Parse(Console.ReadLine());
            Console.Write("Valor a ser pago em reais = {0:f2}", ConversorDeMoeda.TotalParaPagar());
        }
    }
}
