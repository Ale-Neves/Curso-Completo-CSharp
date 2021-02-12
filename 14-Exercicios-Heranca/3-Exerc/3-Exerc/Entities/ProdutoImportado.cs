using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Exerc.Entities
{
    class ProdutoImportado : Produto
    {
        public double CustoFrete { get; set; }

        public ProdutoImportado()
        { }
        public ProdutoImportado(string nome, double valor, double frete) : base( nome, valor)
        {
            CustoFrete = frete;
        }

        public override string EtiquetaPreco()
        {
            return Nome + " $ "+ PrecoTotal().ToString("f2") + " (Customs fee: $ " + CustoFrete.ToString("f2") + ")";
        }

        public double PrecoTotal()
        {
            return CustoFrete + Valor;
        }
    }
}
