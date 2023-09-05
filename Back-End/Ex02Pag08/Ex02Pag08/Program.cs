using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag08
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double litro = 4.96;
            Console.WriteLine("Por favor indique o valor de gasolina desejado: ");
            string input = Console.ReadLine();
            Double.Parse(input);
            Console.Write(litro * Double.Parse(input));
            Console.WriteLine(".");

        }
    }
}
