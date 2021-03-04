using System;
using System.IO;

namespace _6_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasta = @"C:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\arquivo.txt";


            //Pega o todo o caminho do arquivo. 
            Console.WriteLine("\nGetFullPath: " + Path.GetFullPath(pasta));

            //Pega o soomente o caminho correspondente a pasta. 
            Console.WriteLine("\nGetDirectoryName: " + Path.GetDirectoryName(pasta));

            //Pega somente o nome do arquivo e a extensão.
            Console.WriteLine("\nGetFileName: " + Path.GetFileName(pasta));

            // Pega somente o nome do arquivo.
            Console.WriteLine("\nGetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(pasta));

            // Pega somente a extensão do arquivo.
            Console.WriteLine("\nGetExtension: " + Path.GetExtension(pasta));

            //Localiza o caracter utilizado para separação.
            Console.WriteLine("\nDirectorySeparatorChar: " + Path.DirectorySeparatorChar);

            //Localiza o caracter utilizado para separar pastas diferentes.
            Console.WriteLine("\nPathSeparator: " + Path.PathSeparator);

            //Mostra a pasta temporaria do sistema.
            Console.WriteLine("\nGetTempPath: " + Path.GetTempPath());


        }
    }
}
