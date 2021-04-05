using System;
using System.Collections.Generic;
using _05_ColecaoHashComparamIgualdade.Entities;

namespace _05_ColecaoHashComparamIgualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTACIANDO OBJ A
            HashSet<Product> a = new HashSet<Product>();

            //INSTANCIANDO E ADD PRODUTO.
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            //INSTACIANDO OBJ B
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));


            //INSTACIANDO OBJ C
            Product c = new Product("Notebook", 1200.00);

            Console.WriteLine(a.Contains(c));
            //return: false, pois o endereço de memoria é diferente.

            /*Caso o metodo GetHashCode e equals esteja implementado,
              retornara true, pois estara comparando com o produto com o outro 
              e não o objeto na memoria. Ou seja o Conteudo dele é igual.
            */

            Point d = new Point(5, 10);
            Console.WriteLine(b.Contains(d));
            /* Retornara true, pois o tipo struct mesmo sem o GetHashCode e equals 
            ele compara o conteudo e não o objeto na memoria */

        }
    }
}
