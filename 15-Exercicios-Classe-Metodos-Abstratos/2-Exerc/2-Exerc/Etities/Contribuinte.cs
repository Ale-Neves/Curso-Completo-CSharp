using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc.Etities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendimentoAnual { get; set; }

        public Contribuinte()
        { }
        public Contribuinte(string nome, double rendimento)
        {
            Nome = nome;
            RendimentoAnual = rendimento;
        }

        public abstract double Taxa();
    }
}
