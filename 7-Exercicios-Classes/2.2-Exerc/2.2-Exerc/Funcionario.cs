using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2_Exerc
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentaSalario(double porcentagem)
        {
             SalarioBruto += SalarioBruto * (porcentagem / 100);
        }
    }
}
