using System;
using System.Collections.Generic;

namespace _04_HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando objeto
            HashSet<string> set = new HashSet<string>();

            set.Add("Tv");
            set.Add("Notebook");
            set.Add("Tablet");

            //Percorrendo o conjunto de elementos e verificando se contem Computador
            Console.WriteLine(set.Contains("Computador")); // retornara: false;

            //percorrendo os elementos
            foreach(string p in set)
            {
                // imprimindo todos elementos.
                Console.WriteLine(p);
            }
        }
    }
}
