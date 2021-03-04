using System;
using System.IO;

namespace _5_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\5-Exerc\MyFolder";

            try
            {
                //Lista as pastas a partir de uma pasta informada
                var pastas = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas: ");
                foreach(string s in pastas)
                {
                    Console.WriteLine(s);
                }

                //Listando os arquivos a partir de uma pasta informada
                var arquivos = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nArquivos: ");
                foreach (string s in arquivos)
                {
                    Console.WriteLine(s);
                }

                //Criando partas dentro da pasta informada
                Directory.CreateDirectory(path + @"\novaPasta");

            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
