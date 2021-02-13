using System;
using _2_Criando_Excecoes_Personalizadas.Entities;
using _2_Criando_Excecoes_Personalizadas.Entities.Exceptions;
namespace _2_Criando_Excecoes_Personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int numQuarto = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy):  ");
                DateTime entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime saida = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numQuarto, entrada, saida);

                Console.WriteLine(reserva);

                Console.Write("\nEnter data to update the reservation: ");
                Console.Write("\nCheck-in date (dd/MM/yyyy):  ");
                entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                saida = DateTime.Parse(Console.ReadLine());

                reserva.AtualizaDatas(entrada, saida);

                Console.WriteLine(reserva);
            }
            catch(DominioException e) //Execeção personalizada que criamos.
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch(FormatException e) //Execeção de formato.
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch(Exception e) //Execeção generica.
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
    }
}
