using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Criando_Excecoes_Personalizadas.Entities.Exceptions
{
    class DominioException : ApplicationException
    {
        public DominioException(string message) : base (message)
        {}
    }
}
