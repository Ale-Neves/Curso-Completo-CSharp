using System;
using System.Collections.Generic;

namespace _07_Exerc_Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Alunos> course = new HashSet<Alunos>();

            Console.Write("How many students for course A?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int codigo = int.Parse(Console.ReadLine());
                course.Add(new Alunos { CodigoAluno = codigo });
            }

            Console.Write("How many students for course B?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int codigo = int.Parse(Console.ReadLine());
                course.Add(new Alunos { CodigoAluno = codigo });
            }

            Console.Write("How many students for course C?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int codigo = int.Parse(Console.ReadLine());
                course.Add(new Alunos { CodigoAluno = codigo });
            }

            Console.WriteLine("Total students: " + course.Count);


            /* Resolução do Professor
             
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);
             
             */
        }
    }
}
