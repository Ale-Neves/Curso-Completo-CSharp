using System;
using _1_Demonstração.Extensions;

namespace _1_Demonstração
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 04, 01, 0, 0, 0);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
