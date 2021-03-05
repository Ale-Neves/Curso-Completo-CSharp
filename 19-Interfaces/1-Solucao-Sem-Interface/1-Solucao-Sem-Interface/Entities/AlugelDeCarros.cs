using System;

namespace _1_Solucao_Sem_Interface.Entities
{
    class AlugelDeCarros
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AlugelDeCarros(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
