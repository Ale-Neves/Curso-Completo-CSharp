using System;
using _03_GetHashCode_Equals.Entities;

namespace _03_GetHashCode_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente a = new Cliente { Nome = "Alexandre", Email = "alexandre@gmail.com" };
            Cliente b = new Cliente { Nome = "Gian", Email = "gian@gmail.com" };

            Console.WriteLine(a.Equals(b)); // return = false
            Console.WriteLine(a.GetHashCode()); // return = -123256643 (valor aleatorio)

            // Essa comparação é diferente pois comprara com a posição da memoria a outra compara valor.
            Console.WriteLine(a == b); 
        }
    }
}
