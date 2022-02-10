using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o valor de 1 a 10: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + n + " = " + i*n);   
            }
        }
    }
}
