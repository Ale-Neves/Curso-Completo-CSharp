using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc.Entities
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionarios()
        { }
        public Funcionarios(string nome, int horas, double valor)
        {
            Nome = nome;
            HorasTrabalhadas = horas;
            ValorPorHora = valor;
        }

        public virtual double Pagamento()
        {
            return HorasTrabalhadas * ValorPorHora;
        }
    }
}
