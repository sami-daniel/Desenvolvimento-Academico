using System;

namespace Ex11Pag62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Insira o valor a achar os divisores: ");
                double num = double.Parse(Console.ReadLine());
                if (num == -1)
                    break;
                for (int i = 0; i <= num; i++)
                {
                    if (num % i == 0)
                        Console.WriteLine($"Divisor de {num}: {i}");
                }
            }
        }
    }
}
