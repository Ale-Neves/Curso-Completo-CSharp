using System;
using System.Collections.Generic;
using System.IO;

namespace _5_Interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\alexa\Desktop\Curso de c# Completo\19-Interfaces\5-Interface-IComparable\in.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while(!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    // Ordena a lista.
                    list.Sort();
                    
                    foreach(string str in list)
                    {
                        Console.WriteLine(str);
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
