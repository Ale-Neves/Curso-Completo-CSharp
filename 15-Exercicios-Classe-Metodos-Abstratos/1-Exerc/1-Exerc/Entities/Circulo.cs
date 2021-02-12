using System;
using System.Collections.Generic;
using System.Text;
using _1_Exerc.Entities.Enums;

namespace _1_Exerc.Entities
{
    class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo()
        { }
        public Circulo(Cores cor, double raio) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return 3.1416 * (Raio * Raio);
        }
    }
}
