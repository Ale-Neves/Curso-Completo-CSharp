using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Exercicio_Fixacao
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        { }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotal()
        { 
            return Preco * Quantidade;
        }
    }
}
