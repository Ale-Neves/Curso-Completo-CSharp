using System;
using System.IO;

namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"C:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\arquivo.txt";
            
            //Declarando Objetos
            FileStream fs = null;
            StreamReader sr = null; 

            try
            {   
                //Instanciando os Objetos
                fs = new FileStream(caminhoArquivo, FileMode.Open);
                sr = new StreamReader(fs);

                while(!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    Console.WriteLine(linha);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
