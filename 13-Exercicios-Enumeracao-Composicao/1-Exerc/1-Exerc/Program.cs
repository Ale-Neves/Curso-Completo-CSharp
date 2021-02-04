using System;
using _1_Exerc.Entidades;
using _1_Exerc.Entidades.Enums;
namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string nomeDepartamento = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string nomeTrabalhador = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salarioBase = double.Parse(Console.ReadLine());

            //Instanciando classe departamento e atribuindo parameto.
            Departamento dep = new Departamento(nomeDepartamento);

            //Instanciando Classe trabalhador e atribuindo parametros.
            Trabalhador trabalhador = new Trabalhador(nomeTrabalhador,nivel,salarioBase,dep);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i =0; i<n; i++)
            {
                Console.WriteLine("Enter #{0} contract data:", (i+1));
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours):  ");
                int horas = int.Parse(Console.ReadLine());

                //Instanciando Classe contrato e atribuindo parametros.
                ContratoDeHora contrato = new ContratoDeHora(data, valorPorHora, horas);
                //Adicionando contrato ao trabalhador.
                trabalhador.AddContrato(contrato);
            }

            Console.Write("\n\nEnter month and year to calculate income (MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));
            Console.WriteLine("Name: " + trabalhador.Nome);
            Console.WriteLine("Department: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Income for " + mesEano + ": " + trabalhador.Ganho(ano,mes));
        }
    }
}
