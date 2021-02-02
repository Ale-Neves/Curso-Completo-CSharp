using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Exercicio
{
    class Empregado
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Empregado()
        {

        }
        public Empregado(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", " + Salary.ToString("f2");
        }
    }
}
