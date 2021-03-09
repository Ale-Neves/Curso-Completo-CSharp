using System;
using _3_Herdar_vs_Cumprir_Contrato.Model.Entities;
using _3_Herdar_vs_Cumprir_Contrato.Model.Enums;

namespace _3_Herdar_vs_Cumprir_Contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Retangulo() { Color = Color.Black, Height = 4.2, Width = 3.5 };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
