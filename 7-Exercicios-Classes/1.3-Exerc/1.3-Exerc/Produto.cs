using System;
using System.Collections.Generic;
using System.Text;

namespace _1._3_Exerc
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("f2") + ", " + Quantidade + " unidades, Total: $ "
                        + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
