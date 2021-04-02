using System;
using System.Collections.Generic;

namespace _04_HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando e já inserindo elementos 
            SortedSet<int> a = new SortedSet<int>() { 1, 2, 5, 8, 9, 10 };
            SortedSet<int> b = new SortedSet<int>() { 4, 5, 6, 7, 8, 9, 10 };

            
            ImprimeColecao(a); //retorn:  1 2 5 8 9 10

            //União entre os elementos c com b.
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            ImprimeColecao(c); //retorn:  1 2 4 5 6 7 8 9 10.

            //Intersecção entre os elementos d com b.
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            ImprimeColecao(d);  //return: 5 8 9 10.

            //Diferenças entre os elementos d com b.
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            ImprimeColecao(e);  //return: 1 2
        }

        /*
        IEnumerable: é uma interface para percorrer uma coleção, 
        implementada pelo pacote System.Collections */
        //<T>: Coleção do tipo T;

        static void ImprimeColecao<T>(IEnumerable<T> colecao)
        {
            foreach(T obj in colecao)
            {
                Console.Write(obj + " "); 
            }
            Console.WriteLine();
        }
    }
}
