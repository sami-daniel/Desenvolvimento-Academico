﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemCrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, menor, maior, meio; ;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            n3 = double.Parse(Console.ReadLine());
            if (n1 < n2 && n1 < n3)
            {
                menor = n1;
                if (n2 < n3)
                {
                    meio = n2;
                    maior = n3;
                }
                else
                {
                    meio = n3;
                    maior = n2;
                }
            }
            else if (n2 < n1 && n2 < n3)
            {
                menor = n2;
                if (n1 < n3)
                {
                    meio = n1;
                    maior = n3;
                }
                else
                {
                    meio = n3;
                    maior = n1;
                }
            }
            else
            {
                menor = n3;
                if (n1 < n2)
                {
                    meio = n1;
                    maior = n2;
                }
                else
                {
                    meio = n2;
                    maior = n1;
                }
            }
            Console.WriteLine($"O menor número é {menor}, o segundo menor número é {meio} e o terceiro número menor é {maior}.");
            Console.ReadKey();
        }
    }
}
