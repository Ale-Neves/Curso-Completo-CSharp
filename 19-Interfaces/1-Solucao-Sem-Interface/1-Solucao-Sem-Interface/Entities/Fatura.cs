using System;

namespace _1_Solucao_Sem_Interface.Entities
{
    class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public Fatura(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get{ return PagamentoBasico + Taxa; }
        }

        public override string ToString()
        {
            return "INVOICE: \n Basic payment:"
                    + PagamentoBasico.ToString("f2")
                    + " Tax: "
                    + Taxa.ToString("f2")
                    + " Total payment: "
                    + PagamentoTotal;
        }
    }
}
