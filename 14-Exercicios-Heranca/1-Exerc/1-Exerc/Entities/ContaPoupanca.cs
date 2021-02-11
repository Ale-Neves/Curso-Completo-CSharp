using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Exerc.Entities
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        { }
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros)
            : base (numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizaSaldo(double quantia)
        {
            Saldo += quantia * TaxaJuros;
        }
    }
}
