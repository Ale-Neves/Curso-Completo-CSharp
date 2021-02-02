using System;

namespace _5_exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002;
            int senha = 0;

            do
            {
                senha = int.Parse(Console.ReadLine());
                if (senha != senhaCorreta)
                {
                    Console.WriteLine("Senha Invalida");
                }
            } while (senha != senhaCorreta);

            Console.WriteLine("Acesso Permitido");
        }
    }
}
