using System;

namespace _2._3_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();

            Console.Write("Nome do aluno: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            al.Nota1 = double.Parse(Console.ReadLine());
            al.Nota2 = double.Parse(Console.ReadLine());
            al.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = {0:f2}", al.MediaAluno());

            if (al.MediaAluno() > 60.00)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0:f2} PONTOS",  60.00 - al.MediaAluno());
            }
        }
    }
}
