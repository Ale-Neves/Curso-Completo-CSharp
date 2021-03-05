using System;
using System.Collections.Generic;
using System.Text;
using _1_Solucao_Sem_Interface.Entities;

namespace _1_Solucao_Sem_Interface.Services
{
    class ServicoDeAluguel
    {
        public double ValorPorHora { get; private set; }
        public double ValorPorDia { get; private set; }

        private ITaxaDeServico _taxaServico;

        public ServicoDeAluguel(double valorPorHora, double valorPorDia, ITaxaDeServico taxaDeServico)
        {
            ValorPorHora = valorPorHora;
            ValorPorDia = valorPorDia;
            _taxaServico = taxaDeServico;
        }

        public void ProcessarFatura(AlugelDeCarros alugelDeCarros)
        {
            //obtendo a duração.
            TimeSpan duracao = alugelDeCarros.Fim.Subtract(alugelDeCarros.Inicio);

            double pagamentoBasico = 0.0;
            if(duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = ValorPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = ValorPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxaServico.Taxa(pagamentoBasico);

            alugelDeCarros.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}
