using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc.Entidades
{
    class Comentario
    {
        public string Texto { get; set; }

        public Comentario()
        { }
        public Comentario( string texto)
        {
            Texto = texto;
        }
    }
}
