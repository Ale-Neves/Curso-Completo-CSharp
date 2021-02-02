using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Entities.Enums;

namespace ConsoleApp2.Entities
{
    class Pedido
    {
        public int ID { get; set; }
        public DateTime Horario { get; set; }
        public StatusDoPedido Status { get; set; }

        public override string ToString()
        {
            return ID
                + ", "
                + Horario
                + ", "
                + Status;
        }
    }
}
