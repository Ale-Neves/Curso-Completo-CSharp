using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp2.Entities.Enums
{
    enum StatusDoPedido : int
    {
        PagamentoPendente = 0,
        Processando = 1,
        Enviado = 2,
        Entrega = 3
    }
}
