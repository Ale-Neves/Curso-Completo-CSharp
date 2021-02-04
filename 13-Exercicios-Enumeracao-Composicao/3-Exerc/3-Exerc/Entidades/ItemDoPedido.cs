using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Exerc.Entidades
{
    class ItemDoPedido
    {
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public Produto Produto { get; set; }

        public ItemDoPedido()
        { }
        public ItemDoPedido( int quantidade, double valor, Produto produto)
        {
            Quantidade = quantidade;
            Valor = valor;
            Produto = produto;
        }

        public double ValorTotal()
        {
            return Quantidade * Valor;
        }
    }
}
