using System;

namespace _3_exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo = int.Parse(Console.ReadLine());
            int quantidade = int.Parse(Console.ReadLine());
            double total = 0;

            if (codigo == 1)
            {
                total =  quantidade * 4.00;
            }
            else if(codigo == 2)
            {
                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;
            }
            else
            {
                Console.WriteLine("Código invalido.");
            }

            Console.WriteLine("Total: R$ {0:f2} ", total);
        }
    }
}
