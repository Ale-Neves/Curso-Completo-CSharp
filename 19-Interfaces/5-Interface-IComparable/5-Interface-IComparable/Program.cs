using System;
using System.Collections.Generic;
using System.IO;
using _5_Interface_IComparable.Entities;

namespace _5_Interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\alexa\Desktop\Curso de c# Completo\19-Interfaces\5-Interface-IComparable\in.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while(!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    // Ordena a lista.
                    list.Sort();
                    
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
