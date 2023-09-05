using System;
using System.Globalization;

namespace Ex08Pag58
{
    internal class Program
    {
        internal class Numeros
        {
            public double Numero;

            public double ValorTotal;

            public double MaiorValor = double.MinValue;

            public double MenorValor = double.MaxValue;

            private int Counter;

            public int Counter0;

            public int CounterNegativo;

            public void AdicionaNumero(double num)
            {
                Numero = num;
                ValorTotal += Numero;
                VerificaNumeroMaior();
                VerificaNumeroMenor();
                Counter++;
                if (num == 0)
                {
                    Counter0++;
                }
                if (num < 0)
                {
                    CounterNegativo++;
                }
            }
            public double SomaDeTodosOsNumeros()
            {
                return ValorTotal;
            }

            private void VerificaNumeroMaior()
            {
                if (Numero > MaiorValor)
                {
                    MaiorValor = Numero;
                }
            }

            private void VerificaNumeroMenor()
            {
                if (Numero < MenorValor)
                {
                    MenorValor = Numero;
                }
            }

            public double RetornaMedia()
            {
                return ValorTotal / Counter;
            }

            public double RetornaPorcentagemDeZero()
            {
                return (Counter0 * 100) / Counter;
            }
        }

        //Logica dos números

        static void Main(string[] args)
        {
            Numeros classNum = new Numeros();

            while (true)
            {
                Console.Write("Insira o valor númerico (Digite -1 para sair): ");
                double flag = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (flag == -1)
                {
                    break;
                }
                else
                {
                    classNum.AdicionaNumero(flag);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Soma de todos os números: {classNum.SomaDeTodosOsNumeros().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"O valor do maior número: {classNum.MaiorValor.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"O valor do menor número: {classNum.MenorValor.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"Média: {classNum.RetornaMedia().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"Vezes que o 0 foi digitado: {classNum.Counter0}");
            Console.WriteLine();
            Console.WriteLine($"Percentual de zeros digitados: {classNum.RetornaPorcentagemDeZero().ToString("F2", CultureInfo.InvariantCulture)}%");
            Console.WriteLine();
            Console.WriteLine($"Números negativos inseridos: {classNum.CounterNegativo}");
            Console.WriteLine();
        }
    }

}
