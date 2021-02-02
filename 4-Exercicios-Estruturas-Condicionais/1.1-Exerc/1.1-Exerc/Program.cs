using System;

namespace _1._1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = int.Parse(Console.ReadLine());

            if(numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            
        }
    }
}
