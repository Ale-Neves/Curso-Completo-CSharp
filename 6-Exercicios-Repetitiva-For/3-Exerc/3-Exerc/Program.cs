using System;

namespace _3_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] vet;
            double media = 0.0;

            for(int i = 0; i < n; i++)
            {
                vet = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(vet[0]);
                double valor2 = double.Parse(vet[1]);
                double valor3 = double.Parse(vet[2]);

                    media = (2 * valor1 + 3 * valor2 + 5 * valor3) / (2 + 3 + 5);

                Console.WriteLine(media.ToString("f1"));
            }

            
        }
    }
}
