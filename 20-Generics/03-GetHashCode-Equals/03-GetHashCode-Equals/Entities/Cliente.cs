using System;
using System.Collections.Generic;
using System.Text;

namespace _03_GetHashCode_Equals.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente()
        { }
        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Cliente))
                return false;

            // other esta recebendo o objto como cliente(Conversão DownCasting)
            Cliente other = obj as Cliente;

            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
