using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Pag20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c;
            if (a == b)
            {
                c = (a + b);
                Console.WriteLine("A soma de A + B é igual a: " + c);
            }
            else
            {
                c = (a * b);
                Console.WriteLine("A multiplicação de A & B é igual a: " + c);
            }
            Console.ReadKey();
        }
    }
}
