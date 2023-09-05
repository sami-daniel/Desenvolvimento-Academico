using System;

namespace Ex10Pag62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o fatorial: ");
            double num = double.Parse(Console.ReadLine());
            double auxNum = num;
            double aux;

            if (num == 0 || num == 1)
            {
                aux = 1;
            }
            else
            {
                aux = num * --num;
                for (int i = (int)num - 1; i > 0; i--)
                {
                    aux *= --num;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Fatorial(!{auxNum}):{aux}");
        }
    }
}
