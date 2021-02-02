using System;

namespace _3_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoCombustivel = int.Parse(Console.ReadLine());
            int alcool= 0, gasolina=0, diesel=0;

            while( tipoCombustivel !=4 )
            {
                if(tipoCombustivel == 1)
                {
                   alcool++;
                }
                else if( tipoCombustivel ==2)
                {
                    gasolina++;
                }
                else if (tipoCombustivel == 3)
                {
                    diesel++;
                }

                tipoCombustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
