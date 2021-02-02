using System;

namespace _6_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            float a = float.Parse(vet[0]);
            float b = float.Parse(vet[1]);
            float c = float.Parse(vet[2]);

            float trianguloRetangulo = (a * c) / 2;
            double circulo = 3.14159 * Math.Pow(c, 2.0);
            float trapezio = ((a + b) * c) / 2;
            double quadrado = Math.Pow(b, 2.0);
            float retangulo = b * a;

            Console.WriteLine(" TRIANGULO: {0:f3}\n CIRCULO: {1:f3}\n TRAPEZIO: {2:f3}\n QUADRADO: {3:f3}\n RETANGULO: {4:f3}", trianguloRetangulo, circulo, trapezio, quadrado, retangulo);
        }
    }
}
