using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06Pag08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o valor que deseja elevar ao cubo: ");
            double valor = Convert.ToInt32(Console.ReadLine());
            double VlAoCubo = Math.Pow(valor, 3);
            Console.WriteLine(VlAoCubo);
            Console.ReadLine();
        }
    }
}
