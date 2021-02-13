using System;
using System.Collections.Generic;
using System.Text;
using _2_Criando_Excecoes_Personalizadas.Entities.Exceptions;

namespace _2_Criando_Excecoes_Personalizadas.Entities
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reserva()
        { }
        public Reserva(int numerQuarto, DateTime entrada, DateTime saida)
        {
            if (saida <= entrada)
            {
                //Lançando uma exceção com esta frase. 
                throw new DominioException("Check-out date must be after check-in date");
            }

            NumeroQuarto = numerQuarto;
            Checkin = entrada;
            Checkout = saida;
        }

        public int Duracao()
        {
            TimeSpan duracao = Checkout.Subtract(Checkin);
            return (int)duracao.TotalDays;
        }
        public void AtualizaDatas(DateTime entrada, DateTime saida )
        {
            DateTime dataAtual = DateTime.Now;
            
            if(entrada < dataAtual || saida < dataAtual)
            {
                //Lançando uma exceção com esta frase. 
                throw new DominioException("Reservation dates for update must be future dates");
            }
            else if(saida <= entrada)
            {
                //Lançando uma exceção com esta frase. 
                throw new DominioException("Check-out date must be after check-in date");
            }

            //Realizando atualizações. 
            Checkin = entrada;
            Checkout = saida;
        }

        public override string ToString()
        {
            return "Reservation: Room "
                    + NumeroQuarto
                    + ", check-in: "
                    + Checkin.ToString("dd/MM/yyyy")
                    + ", check-out: "
                    + Checkout.ToString("dd/MM/yyyy")
                    + ", "
                    + Duracao()
                    + " nights";
        }

    }
}
