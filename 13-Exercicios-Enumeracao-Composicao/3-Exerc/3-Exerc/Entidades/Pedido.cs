using System;
using System.Collections.Generic;
using System.Text;
using _3_Exerc.Entidades.Enums;

namespace _3_Exerc.Entidades
{
    class Pedido
    {
        public DateTime DataAtual { get; set; }
        public StatusDoPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemDoPedido> listItensDoPedido { get; set; } = new List<ItemDoPedido>();

        public Pedido()
        { }
        public Pedido(DateTime data, StatusDoPedido status, Cliente cliente)
        {
            DataAtual = data;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItemDoPedido itemPedido)
        {
            listItensDoPedido.Add(itemPedido);
        }
        public void RemoverItem(ItemDoPedido itemPedido)
        {
            listItensDoPedido.Remove(itemPedido);
        }
        public double TotalPedido()
        {
            double soma = 0;
            foreach(ItemDoPedido p in listItensDoPedido)
            {
                soma += p.ValorTotal();
            }

            return soma;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(DataAtual.ToString());
            sb.Append("Client: ");
            sb.Append(Cliente.Nome);
            sb.Append(" - ");
            sb.AppendLine(Cliente.Email);
            sb.AppendLine("Order items:");
            foreach (ItemDoPedido p in listItensDoPedido)
            {
                sb.Append(p.Produto.Nome);
                sb.Append(", $");
                sb.Append(p.Valor);
                sb.Append(", Quantity: ");
                sb.Append(p.Quantidade);
                sb.Append(", Subtotal: $");
                sb.Append(p.ValorTotal().ToString("F2"));
                sb.AppendLine("\n");
            }
            sb.AppendLine("Total price: $" + TotalPedido().ToString("F2"));
            return sb.ToString();
        }

    }
}
