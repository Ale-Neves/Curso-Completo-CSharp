using System;

namespace _3_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = 0, result2 = 0;

            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a>b)
            {
               result1 = a / b;
            }
            else
            {
               result2 += b / a;
            }

            if( a == result1 * b || b == result2 * a)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }


            /*
             string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
            */

        }
    }
}
