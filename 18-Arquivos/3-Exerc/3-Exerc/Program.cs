using System;
using System.IO;

namespace _3_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"C:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\arquivo.txt";

            try
            {
                using (FileStream fs = new FileStream(caminhoArquivo, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string linha = sr.ReadLine();
                            Console.WriteLine(linha);
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            //EXEMPLO 2 RESUMIDO
            try
            {
                using (StreamReader sr = File.OpenText(caminhoArquivo))
                {
                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
    }
}
