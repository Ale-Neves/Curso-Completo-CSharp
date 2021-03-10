using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Interface_IComparable.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1]);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("f2");
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee"); ;
            }
            //down casting
            Employee other = obj as Employee;

            return Name.CompareTo(other.Name);
        }
    }
}
