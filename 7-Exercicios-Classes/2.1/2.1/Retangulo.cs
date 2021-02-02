using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1
{
    class Retangulo
    {
        public double Largula;
        public double Altura;

        public double Area()
        {
            return Largula * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largula + Altura);
        }
        public double Diagonal()
        {

            return Math.Sqrt(Largula * Largula + Altura * Altura);
        }
    }
}
