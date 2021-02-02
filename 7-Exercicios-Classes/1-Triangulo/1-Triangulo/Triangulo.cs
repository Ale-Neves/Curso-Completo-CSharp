using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Triangulo
{
    class Triangulo
    {
        //Fazendo definição da classe
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return raiz;
        }
    }
}
