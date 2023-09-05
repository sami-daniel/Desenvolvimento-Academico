using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Pag27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 número: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2 número: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite 1 para somar \n" +
                "Digite 2 para subtrair \n" +
                "Digite 3 para multiplicar \n" +
                "Digite 4 para dividir");
            string operacao = Console.ReadLine().ToString();
            while (operacao == null || operacao == string.Empty)
            {
                Console.WriteLine("Digite 1 para somar \n" +
                "Digite 2 para subtrair \n" +
                "Digite 3 para multiplicar \n" +
                "Digite 4 para dividir");
                 operacao = Console.ReadLine().ToString();
                Console.Clear();
            }
            switch (operacao)
            {
                case "1":
                    Console.WriteLine("A soma é: " + (a + b));
                    break;
                case "2":
                    Console.WriteLine("A subtração é: " + (a - b));
                    break;
                case "3":
                    Console.WriteLine("A multiplicação é: " + (a * b));
                    break;
                    case "4":
                    Console.WriteLine("A divisão é: " + (a / b));
                    

                    break;
                    default: Console.WriteLine("Erro!");
                    break;
            }
            while (true)
            {
                Console.WriteLine("Digite 1 para somar \n" +
                 "Digite 2 para subtrair \n" +
                 "Digite 3 para multiplicar \n" +
                 "Digite 4 para dividir");
                operacao = Console.ReadLine().ToString();
                Console.Clear();
                switch (operacao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("A soma é: " + (a + b));
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("A subtração é: " + (a - b));
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("A multiplicação é: " + (a * b));
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("A divisão é: " + (a / b));
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Erro!");
                        break;
                    
                }
                
            }
        }
    }
}
