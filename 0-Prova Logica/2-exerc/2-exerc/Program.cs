using System;

namespace _2_exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] var = Console.ReadLine().Split(" ");

            double pi = 3.14159;
            float raio = float.Parse(Console.ReadLine());

            double areaCirculo = pi * Math.Pow(raio, 2);

            Console.WriteLine("A={0:f4}", areaCirculo);
        }
    }
}
