using System;

namespace _4_exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] var = Console.ReadLine().Split(" ");

            double a = float.Parse(var[0]);
            double b = float.Parse(var[1]);
            double c = float.Parse(var[2]);

            double valorDelta = Math.Pow(b, 2) - (4 * a * c);

            if(valorDelta >= 0)
            {
                b = b * -1;
                
                if( a != 0)
                {
                    double x1 = (b + Math.Sqrt(valorDelta) ) / (2 * a);
                    double x2 = (b - Math.Sqrt(valorDelta) ) / (2 * a);

                    Console.WriteLine(" X1 = {0:f4} \n X2 = {1:f4}", x1, x2);
                }
                else
                {
                    Console.WriteLine("Impossivel calcular: Valor de A é Zero!");
                }
                
            }
            else
            {
                Console.WriteLine("Impossivel calcular: Valor Delta é negativo!");
            }
        }
    }
}
