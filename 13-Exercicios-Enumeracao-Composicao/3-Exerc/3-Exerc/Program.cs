using System;
using _3_Exerc.Entidades;
using _3_Exerc.Entidades.Enums;


namespace _3_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dataAniversario = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter order data: " + DateTime.Now);
            Console.Write("\nStatus: ");
            StatusDoPedido status = Enum.Parse<StatusDoPedido>(Console.ReadLine());

            Cliente cliente = new Cliente(nome, email, dataAniversario);
            Pedido pedido = new Pedido(DateTime.Now, status,cliente);

            Console.Write("How many items to this order?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                Console.Write("Enter #{0} item data: ", (i + 1));
                Console.Write("Product name: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Product price: ");
                double valorProduto = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeProduto, valorProduto);
                ItemDoPedido item = new ItemDoPedido(quantidadeProduto, valorProduto, produto);

                pedido.AddItem(item);
            }
            Console.WriteLine(pedido);
        }
    }
}
