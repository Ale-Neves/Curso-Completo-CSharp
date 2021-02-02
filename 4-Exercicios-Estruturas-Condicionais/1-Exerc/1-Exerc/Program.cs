using System;

namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if(hora<12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if(hora < 18)
            {
                Console.WriteLine("Bom Tarde!");
            }
            else
            {
                Console.WriteLine("Bom Noite!");
            }
        }
    }
}
