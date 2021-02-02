using System;

namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
           

            float raio = float.Parse(Console.ReadLine());

            float pi = 3.14159f;
            double areaCirculo = pi * Math.Pow(raio, 2.00);

            Console.WriteLine("A = {0:F4}", areaCirculo);
        }
    }
}
