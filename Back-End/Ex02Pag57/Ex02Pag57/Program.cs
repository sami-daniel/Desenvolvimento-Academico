using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num;
            double media;
            int numAsomar = 0;
            int counter = 0;
            while (true)
            {
                Console.WriteLine("Insira um número: ");
                numAsomar += int.Parse(Console.ReadLine());
                counter++;
                Console.WriteLine("Digite 1 para sair: ");
                num = Console.ReadLine();
                if(num == "1")
                {
                    break;
                }
                Console.Clear();
            }
            Console.Clear();
            media = numAsomar / counter;
            Console.WriteLine($"Media: {media}({numAsomar}/{counter})");
            Console.ReadKey();
        }
    }
}
