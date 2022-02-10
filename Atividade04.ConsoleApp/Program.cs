using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maiorAltura = 0, menorAltura = 99000;
            double[] alturas = new double[15];
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite sua altura: ");
                alturas[i] = Convert.ToDouble(Console.ReadLine()); 

                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                }
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
            }
            Console.WriteLine("maior altura: " + maiorAltura);
            Console.WriteLine("menor altura: " + menorAltura);
                
        }
    }
}
