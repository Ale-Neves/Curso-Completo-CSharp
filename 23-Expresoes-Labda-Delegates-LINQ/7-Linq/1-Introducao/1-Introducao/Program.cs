using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Especificando o data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Definindo a expressão query
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Executa a query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
