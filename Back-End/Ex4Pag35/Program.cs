using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex4Pag35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            char cod;
            int ht_extras, ht;
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Insira o número de matrícula do funcionário:\n");
                        cod = Console.ReadLine()[0];
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.Write("Valor invalido\n");
                    }
                }
                while (cod != '1' && cod != '2' && cod != '3' && cod != '4' && cod != '5')
                {
                    Console.Write($"Código invalido. Digite novamente: \n");
                    while (true)
                    {
                        try
                        {
                            cod = Console.ReadLine()[0];
                        }
                        catch (Exception)
                        {
                            Console.Write($"Código invalido. Digite novamente: \n");
                        }
                    }
                }
                Console.WriteLine($"Trabalhador classe {cod}");
                while (true)
                {
                    try
                    {
                        Console.Write($"Insira o número de horas trabalhadas do funcionário: \n");
                        ht = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Write($"Valor inválido. Somente números inteiros. \n");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write($"Insira o número de horas extras trabalhadas do funcionário: \n");
                        ht_extras = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Write($"Valor inválido. Somente números inteiros. \n");
                    }
                }
                Console.Clear();
                switch (cod) 
                {
                    case '1':
                        Console.WriteLine($"Salário bruto: {(ht*(8)).ToString("C")}");
                        Console.WriteLine($"Adicional das horas extras: {(ht_extras * (8 + (0.5*8))).ToString("C")}");
                        Console.WriteLine($"Desconto do INSS: {(0.11*(ht*8)).ToString("C")}");
                        Console.WriteLine($"Renda liquida diária: {(((ht*8) + (ht_extras * (8 + (0.5 * 8))))- (0.11 * (ht * 8))).ToString("C")}");
                        break;
                    case '2':
                        Console.WriteLine($"Salário bruto: {(ht * (10)).ToString("C")}");
                        Console.WriteLine($"Adicional das horas extras: {(ht_extras * (10 + (0.5 * 10))).ToString("C")}");
                        Console.WriteLine($"Desconto do INSS: {(0.11 * (ht * 10)).ToString("C")}");
                        Console.WriteLine($"Renda liquida diária: {(((ht * 10) + (ht_extras * (10 + (0.5 * 10)))) - (0.11 * (ht * 10))).ToString("C")}");
                        break;
                    case '3':
                        Console.WriteLine($"Salário bruto: {(ht * (12)).ToString("C")}");
                        Console.WriteLine($"Adicional das horas extras: {(ht_extras * (12 + (0.5 * 12))).ToString("C")}");
                        Console.WriteLine($"Desconto do INSS: {(0.11 * (ht * 12)).ToString("C")}");
                        Console.WriteLine($"Renda liquida diária: {(((ht * 12) + (ht_extras * (12 + (0.5 * 12)))) - (0.11 * (ht * 12))).ToString("C")}");
                        break;
                    case '4':
                        Console.WriteLine($"Salário bruto: {(ht * (15)).ToString("C")}");
                        Console.WriteLine($"Adicional das horas extras: {(ht_extras * (15 + (0.5 * 15))).ToString("C")}");
                        Console.WriteLine($"Desconto do INSS: {(0.11 * (ht * 15)).ToString("C")}");
                        Console.WriteLine($"Renda liquida diária: {(((ht * 15) + (ht_extras * (15 + (0.5 * 15)))) - (0.11 * (ht * 15))).ToString("C")}");
                        break;
                    case '5':
                        Console.WriteLine($"Renda bruta diária: {(ht * (20)).ToString("C")}");
                        Console.WriteLine($"Adicional das horas extras: {(ht_extras * (20 + (0.5 * 20))).ToString("C")}");
                        Console.WriteLine($"Desconto do INSS: {(0.11 * (ht * 20)).ToString("C")}");
                        Console.WriteLine($"Renda liquida diária: {(((ht * 20) + (ht_extras * (20 + (0.5 * 20)))) - (0.11 * (ht * 20))).ToString("C")}");
                        break;
                }
            }
        }
    }
}