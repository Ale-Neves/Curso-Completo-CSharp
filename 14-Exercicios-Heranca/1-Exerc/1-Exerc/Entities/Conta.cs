using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Exerc.Entities
{
    class Conta
    {
        public int Numero { get; protected set; }

        public string Titular { get; protected set; }

        public double Saldo { get; protected set; }

        public Conta()
        { }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia;
        }
        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
    }
}
