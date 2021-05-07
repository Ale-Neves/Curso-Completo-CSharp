using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Exercicio.Entities
{
    class Employee
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Employee(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}
