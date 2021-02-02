using System;

namespace _1_exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorPagar = 0 ;

            for (int i = 1; i<=2; i++)
            {
                int codigo = int.Parse(Console.ReadLine());
                int quantidade = int.Parse(Console.ReadLine());
                float valorProduto = float.Parse(Console.ReadLine());

                valorPagar += quantidade * valorProduto;
            }

            Console.WriteLine("VALOR A PAGAR: R${0}", valorPagar);
        }
    }
}
