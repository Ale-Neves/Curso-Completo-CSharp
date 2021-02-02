using System;

namespace _8_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            double imposto = 0.0;

            if(salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if( salario > 2000.00 && salario <=3000.00)
            {
                salario = salario - 2000.00;
                imposto = salario * 0.08;
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                salario = salario - 2000.00;

                double aux = salario - 1000;
                imposto = (1000.00 * 0.08) + (aux * 0.18);
            }
            else if (salario > 4500.00 )
            {
                salario = salario - 2000.00;
                double aux = salario - 2500.00;
                imposto = (1000.00 * 0.08) + (1500.00 * 0.18)+ (aux * 0.28);
            }

            Console.WriteLine("R$ {0:f2}", imposto);
        }

        /*
         double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0) {
                imposto = 0.0;
            }
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
         */
    }
}
