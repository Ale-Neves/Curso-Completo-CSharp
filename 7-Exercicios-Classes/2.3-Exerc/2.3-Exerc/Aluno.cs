using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3_Exerc
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double MediaAluno()
        {
            return (Nota1 + Nota2 + Nota3);
        }
    }
}
