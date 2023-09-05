using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04Pag08
{

    internal class Program
    {
        
        static void Main(string[] args)
        {

            double H, Area, Base = 0;
            Console.WriteLine("Indique o valor da base do quadrado: ");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora indique o valor da altura do quadrado: ");
            H = double.Parse(Console.ReadLine());
            Area = Base * H;
            Console.WriteLine("A área do triangulo é igual a: " + Area);
            Console.ReadLine();
        }
    }
}
