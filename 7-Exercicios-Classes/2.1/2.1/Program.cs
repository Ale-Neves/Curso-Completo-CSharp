using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo re;

            re = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            re.Largula = double.Parse(Console.ReadLine());
            re.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nAREA = " + re.Area().ToString("F2"));
            Console.WriteLine("\nPERÍMETRO = " + re.Perimetro().ToString("F2"));
            Console.WriteLine("\nDIAGONAL = " + re.Diagonal().ToString("F2"));
        }
    }
}
