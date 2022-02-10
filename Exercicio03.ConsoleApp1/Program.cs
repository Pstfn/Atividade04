using System;

namespace Exercicio03.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            for (int i = 0; i < 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
