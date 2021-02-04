using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Exerc.Entidades
{
    class ContratoDeHora
    {
        public DateTime Data { get; set; }
        public Double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoDeHora()
        {
        }
        public ContratoDeHora(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }
    }
}
