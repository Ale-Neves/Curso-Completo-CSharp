using System;
using System.Globalization;

namespace _1_ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("{0}, cujo preço é $ {1:f2}\n",produto1, preco1);
            Console.WriteLine("{0}, cujo preço é $ {1:f2}\n", produto2, preco2);

            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}\n", idade, codigo, genero);

            Console.WriteLine("Medida com oito casas decimais: {0:f8}\n", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:f3}\n", medida);
            Console.WriteLine("Separador decimal invariant culture: {0}\n", medida.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
