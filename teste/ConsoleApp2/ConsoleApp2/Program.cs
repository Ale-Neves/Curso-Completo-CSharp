using System;
using System.Globalization;
using ConsoleApp2.Entities;
using ConsoleApp2.Entities.Enums;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                ID = 1080,
                Horario = DateTime.Now,
                Status = StatusDoPedido.Processando
            };

            Console.WriteLine("Pedido: " + pedido);

            string txt = StatusDoPedido.Processando.ToString();

            StatusDoPedido os1 = Enum.Parse<StatusDoPedido>("Entrega");
            StatusDoPedido os2 = (StatusDoPedido)Enum.Parse(typeof(StatusDoPedido), "Entrega");
            StatusDoPedido os3;
            Enum.TryParse("Entrega", out os3);
        }
    }
}

