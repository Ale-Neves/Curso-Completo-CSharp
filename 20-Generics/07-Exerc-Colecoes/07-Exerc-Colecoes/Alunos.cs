using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Exerc_Colecoes
{
    class Alunos
    {
        public int CodigoAluno { get; set; }

        public Alunos()
        {

        }
        public Alunos(int codigo)
        {
            CodigoAluno = codigo;
        }

        public override int GetHashCode()
        {
            return CodigoAluno.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Alunos))
                return false;

            Alunos other = obj as Alunos;
            return CodigoAluno.Equals(other.CodigoAluno);
        }
    }
}
