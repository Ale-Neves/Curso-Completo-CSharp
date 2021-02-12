using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Exerc.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto()
        { }
        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public virtual string EtiquetaPreco()
        {
            return Nome + " $ " + Valor.ToString("f2");
        }
    }
}
