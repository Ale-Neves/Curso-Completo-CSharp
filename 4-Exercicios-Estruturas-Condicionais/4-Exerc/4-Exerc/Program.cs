using System;

namespace _4_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);

            int dia = 24;

            int horaJogada = 0;

            if( horaInicial > horaFinal)
            {
                horaJogada = dia - horaInicial + horaFinal;
            }
            else if(horaInicial < horaFinal)
            {
                horaJogada =  horaFinal - horaInicial;
            }
            else if( horaInicial == 0 && horaFinal==0)
            {
                horaJogada = 24;
            }
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", horaJogada);
        }
    }
}
