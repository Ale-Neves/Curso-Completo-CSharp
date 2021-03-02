using System;
using System.IO;

namespace _1_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoOrigem = @"c:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\arquivo.txt";
            string caminhoDestino = @"C:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\arquivo2.txt";

            try
            {
                FileInfo chamaArquivo = new FileInfo(caminhoOrigem);
                chamaArquivo.CopyTo(caminhoDestino);

                string[] linhas= File.ReadAllLines(caminhoOrigem);
                foreach(string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
