using System;
using System.IO;

namespace _4_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivoOrigem = @"C:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\arquivo.txt";
            string arquivoDestino = @"C:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\arquivo3.txt";

            try
            {
                //Lendo as linhas e guardando no array.
                string[] linhas = File.ReadAllLines(arquivoOrigem);

                using (StreamWriter sw = File.AppendText(arquivoDestino))
                {
                    foreach(string linha in linhas)
                    {
                        sw.WriteLine(linha.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
