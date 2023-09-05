using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Pag35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorParcela, juros;
            Console.Write("Bem Vindo!\n\n");
            Console.WriteLine("Digite o valor do veiculo adquirido: "); double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite qual plano é o seu: (A,B,C,D)"); string plan = Console.ReadLine().ToUpper(); 
            while(plan != "A" && plan != "B" && plan != "C" && plan != "D")
            {
                Console.WriteLine("Digite qual plano é o seu: (A,B,C,D "); 
                plan = Console.ReadLine().ToUpper();
            }
            switch (plan)
            {
                case "A":
                    valorParcela = valor / 24;
                    juros = valorParcela * (30.00 / 100.00);
                    Console.WriteLine($"O total de juros cobrados é de: {(juros * 24).ToString("C")}");
                    Console.WriteLine($"O total do financiamento é de: {((juros * 24) + valor).ToString("C")}");
                    Console.WriteLine($"O total de cada parcela é de:{(juros+valorParcela).ToString("C")}");
                    break;
                case "B":
                    valorParcela = valor / 36;
                    juros = valorParcela * (55.00 / 100.00);
                    Console.WriteLine($"O total de juros cobrados é de: {(juros * 36).ToString("C")}");
                    Console.WriteLine($"O total do financiamento é de: {((juros * 36) + valor).ToString("C")}");
                    Console.WriteLine($"O total de cada parcela é de:{(juros + valorParcela).ToString("C")}");
                    break;
                case "C":
                    valorParcela = valor / 48;
                    juros = valorParcela * (75.00 / 100.00);
                    Console.WriteLine($"O total de juros cobrados é de: {(juros * 48).ToString("C")}");
                    Console.WriteLine($"O total do financiamento é de: {((juros * 48) + valor).ToString("C")}");
                    Console.WriteLine($"O total de cada parcela é de:{(juros + valorParcela).ToString("C")}");
                    break;
                case "D":
                    valorParcela = valor / 60;
                    juros = valorParcela * (100.00 / 100.00);
                    Console.WriteLine($"O total de juros cobrados é de: {(juros * 60).ToString("C")}");
                    Console.WriteLine($"O total do financiamento é de: {((juros * 60) + valor).ToString("C")}");
                    Console.WriteLine($"O total de cada parcela é de:{(juros + valorParcela).ToString("C")}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
