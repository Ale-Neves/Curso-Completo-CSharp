using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc.Etities
{
    class Company : Contribuinte
    {
        public int NumeroFuncionarios { get; set; }

        public Company()
        { }
        public Company(string nome, double rendimento, int numFunc) : base(nome, rendimento)
        {
            NumeroFuncionarios = numFunc;
        }

        public override double Taxa()
        {
            if(NumeroFuncionarios > 10)
            {
                return RendimentoAnual * 0.14;
            }
            else
            {
                return RendimentoAnual * 0.16;
            }
        }
    }
}
