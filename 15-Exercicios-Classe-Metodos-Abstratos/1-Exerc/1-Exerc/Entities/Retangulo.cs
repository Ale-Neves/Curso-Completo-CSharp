using System;
using System.Collections.Generic;
using System.Text;
using _1_Exerc.Entities.Enums;

namespace _1_Exerc.Entities
{
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo()
        { }
        public Retangulo(Cores cor, double largura, double altura) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
