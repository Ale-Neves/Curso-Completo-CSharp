using System;

namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int valor = int.Parse(Console.ReadLine());

            while(valor >=0)
            {
                double raiz = Math.Sqrt(valor);
                Console.WriteLine(raiz.ToString("F3"));

                Console.Write("Digite um número: ");
                valor = int.Parse(Console.ReadLine());
            }
            Console.Write("Número negativo!");
        }
    }
}
