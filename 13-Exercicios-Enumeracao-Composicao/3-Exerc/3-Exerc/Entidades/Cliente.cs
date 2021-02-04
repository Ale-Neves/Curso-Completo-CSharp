using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Exerc.Entidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }

        public Cliente()
        { }
        public Cliente(string nome, string email, DateTime dataAniversario)
        {
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
        }
    }
}
