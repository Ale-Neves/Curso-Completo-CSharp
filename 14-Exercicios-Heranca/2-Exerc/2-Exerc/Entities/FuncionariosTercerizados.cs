using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc.Entities
{
    class FuncionariosTercerizados : Funcionarios
    {
        public double DispesaAdicional { get; set; }

        public FuncionariosTercerizados()
        { }
        public FuncionariosTercerizados(string nome, int horas, double valor, double dispesaAd)
            :base(nome, horas, valor)
        {
            DispesaAdicional = dispesaAd;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DispesaAdicional;
        }
    }
}
