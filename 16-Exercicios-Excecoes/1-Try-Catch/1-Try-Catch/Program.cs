using System;

namespace _1_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Não é permitido divisão por zero!");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
