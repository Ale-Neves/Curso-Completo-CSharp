using System;
using System.Collections.Generic;
using System.Text;
using _2_Exerc.Entities.Exceptions;

namespace _2_Exerc.Entities
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double ValorNaConta { get; set; }
        public double LimiteSaque { get; set; }

        public Conta()
        { }
        public Conta(int numeroConta, string titular, double valor, double limite)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            ValorNaConta = valor;
            LimiteSaque = limite;
        }

        public void Deposito(double quantia)
        {
            ValorNaConta += quantia;
        }
        public void Sacar(double quantia)
        {
            if(quantia > ValorNaConta)
            {
                throw new DominioException("Erro de retirada: saldo insuficiente!");
            }
            else if( quantia > LimiteSaque)
            {
                throw new DominioException("Erro de retirada: o valor excede o limite de retirada!");
            }

            ValorNaConta -= quantia;
        }

        public override string ToString()
        {
            return "Saldo em Conta Atualizado: " + ValorNaConta.ToString("f2");
        }
    }
}
