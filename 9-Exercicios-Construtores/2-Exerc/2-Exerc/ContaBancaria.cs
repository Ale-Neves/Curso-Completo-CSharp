using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc
{
    class ContaBancaria
    {
        public double NumeroDaConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {
        }
        public ContaBancaria( double numerodaConta, string nometilular)
        {
            NumeroDaConta = numerodaConta;
            NomeTitular = nometilular;
        }
        public ContaBancaria(double numerodaConta, string nometilular, double deposito) : this(numerodaConta, nometilular)
        {
            Depositos(deposito);
        }

        public void Depositos(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double quantia)
        {
            Saldo = ( Saldo - quantia) - 5.00;
        }

        public override string ToString()
        {
            return "Conta " + NumeroDaConta + ", Titular: " + NomeTitular + ", Saldo: $ " + Saldo.ToString("f2");
        }
    }
}
