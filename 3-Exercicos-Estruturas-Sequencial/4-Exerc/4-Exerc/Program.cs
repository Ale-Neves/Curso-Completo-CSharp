using System;

namespace _4_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFun = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorH = double.Parse(Console.ReadLine());

            double salario = horas * valorH;

            Console.WriteLine("NUMBER = {0}\nSALARY = U$ {1:f2}", numeroFun, salario);
        }
    }
}
