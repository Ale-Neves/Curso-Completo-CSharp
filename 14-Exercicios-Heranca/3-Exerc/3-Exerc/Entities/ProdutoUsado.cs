using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Exerc.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        { }

        public ProdutoUsado(string nome, double valor, DateTime data) : base(nome, valor)
        {
            DataFabricacao = data;
        }

        public override string EtiquetaPreco()
        {
            return Nome + " (used) $ " + Valor.ToString("f2") + "  (Manufacture date: " + DataFabricacao.ToString("dd/MM/yyyy") + " )" ;
        }
    }
}
