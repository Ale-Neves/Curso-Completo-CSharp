using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc
{
    class ConversorDeMoeda
    {
        public static double Cotacao;
        public static double ValorDeCompra;

        public static double TotalParaPagar()
        {
            double aux = (ValorDeCompra * Cotacao);
            return  aux += aux * 0.06;
        }

        /*
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao) 
        {
          double total = quantia * cotacao;
          return total + total * Iof / 100.0;
        }
         */
    }
}
