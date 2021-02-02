using System;

namespace _5_Exec
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            float total = 0.0f;

            if(codigo == 1)
            {
                total = quantidade * 4.00f;
            }
            else if(codigo == 2)
            {
                total = quantidade * 4.50f;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00f;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00f;
            }
            else
            {
                total = quantidade * 1.50f;
            }

            Console.WriteLine("Total: R$ {0:f2}", total);
        }
    }
}
