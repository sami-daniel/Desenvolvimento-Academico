using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07Pag27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do primeiro numero: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo numero: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Max(a, b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
