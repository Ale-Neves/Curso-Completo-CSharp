using System;
using System.Collections.Generic;
using System.Text;
using _1_Exerc.Entidades.Enums;

namespace _1_Exerc.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador  Nivel { get; set; }
        public double SalarioBase { get; set; }
        
        // Associação de duas classes diferentes.
        public Departamento Departamento { get; set; }

        public List<ContratoDeHora> listDeContratos { get; set; } = new List<ContratoDeHora>();

        public Trabalhador()
        { 
        }
        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato(ContratoDeHora contrato)
        {
            //Adicionando contrado na lista de contrados.
            listDeContratos.Add(contrato);
        }
        public void RemoverContrato(ContratoDeHora contrato)
        {
            //Removendo Contrado.
            listDeContratos.Remove(contrato);
        }
        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach(ContratoDeHora contrato in listDeContratos)
            {
                if(contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }

    }
}
