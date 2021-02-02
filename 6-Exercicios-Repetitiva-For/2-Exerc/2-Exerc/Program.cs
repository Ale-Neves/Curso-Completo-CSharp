using System;

namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            int dentro = 0, fora =0;
      
            for(int i =0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                
                if(x>=10 && x<=20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine("{0} in\n{1} out", dentro, fora);


        }
    }
}
