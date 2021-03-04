using System;
using System.Collections.Generic;
using System.IO;

namespace _7_Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string arquivoOrigin = @"C:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\7-Exercicio-Fixacao\Arquivos Origem\Origin\arquivoOriginal.csv";
                string arquivoDestino = @"C:\Users\alexa\Desktop\Curso de c# Completo\18-Arquivos\7-Exercicio-Fixacao\Arquivos Origem\Out\summary.csv";
                
                     
                string[] objProduto = File.ReadAllLines(arquivoOrigin);

                using (StreamWriter sw = File.AppendText(arquivoDestino))
                {
                    for (int i = 0; i < objProduto.Length; i++)
                    {
                        string[] produto = objProduto[i].Split(',');

                        string nome = produto[0];
                        double valor = double.Parse(produto[1]);
                        int quantidade = int.Parse(produto[2]);


                        Produto p = new Produto(nome, valor, quantidade);

                        sw.WriteLine(p.Nome + ", " + p.ValorTotal());
                    }
                }
                
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }


        /***** SOLUÇÃO DO PROFESSOR 

        tatic void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }*/
    }
}
