using System;

namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cont = 0;

            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j< n; j++)
                {
                    mat[i , j] = int.Parse(vet[j]);

                    if(mat[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("\nMain diagonal:");

            for(int i =0; i< n; i++)
            {
                Console.Write(mat[i, i] + " "); 
            }

            Console.WriteLine("\nNegative numbers = {0}", cont);
        }
    }
}
