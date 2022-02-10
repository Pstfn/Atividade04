using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, valorA, fatorial = 0;
            Console.WriteLine("digite o valor A: ");
            valorA = Convert.ToInt32(Console.ReadLine());
            fatorial = valorA;
            for (i = valorA - 1; i >= 1; i--) 
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine($"\nFatorial de {valorA} é {fatorial} ");
            Console.ReadLine();
        }
    }
}
