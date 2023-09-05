using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05Pag08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Peri,area,B,H;
            Console.Write("Digite o valor da base do retângulo: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do retângulo: ");
            H = double.Parse(Console.ReadLine());
            area = H * B;
            Peri = (H * 2) + (B * 2);
            Console.WriteLine("o valor da área do retângulo é de: " + area);
            Console.WriteLine("o valor do perímetro do retângulo é de: " + Peri);
            Console.Read();
        }
    }
}
