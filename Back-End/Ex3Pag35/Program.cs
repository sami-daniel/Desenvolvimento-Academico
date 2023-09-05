using System;

namespace Ex3Pag35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int quantidade;
                Console.Write("Digite o código do produto: ");
                char cod = Console.ReadLine()[0];
                cod = char.ToLower(cod);
                while (cod != 'a' && cod != 'm' && cod != 'b' && cod != 'k' && cod != 'w')
                {
                    Console.Clear();
                    Console.Write("Código invalido\n");
                    Console.Write("Digite o código do produto: ");
                    cod = Console.ReadLine()[0];
                }
                Console.Write("Digite a quantidade do produto: ");
                while (true)
                {
                    try
                    {
                        quantidade = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.Write("Número inválido.\nDigite um número inteiro: ");
                    }
                }
                switch (cod)
                {
                    case 'a':
                        Console.WriteLine($"Preço total: {(quantidade * 325).ToString("C")}");
                        break;
                    case 'm':
                        Console.WriteLine($"Preço total: {(quantidade * 102).ToString("C")}");
                        break;
                    case 'b':
                        Console.WriteLine($"Preço total: {(quantidade * 76).ToString("C")}");
                        break;
                    case 'k':
                        Console.WriteLine($"Preço total: {(quantidade * 176).ToString("C")}");
                        break;
                    case 'w':
                        Console.WriteLine($"Preço total: {(quantidade * 456).ToString("C")}");
                        break;
                    default:
                        throw new Exception("Erro");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
