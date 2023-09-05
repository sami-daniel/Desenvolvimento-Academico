using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Pag57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flag = "";
            double salario;
            int empregadosSalarioMinimo = 0;
            double valorTotalFolhaPagamento = 0;
            double mediaSalarialEmpresa;
            int counterEmpregados = 0;
            int counterEmpregadosQueRecebemMaisDe1500 = 0;
            double porcentcounterEmpregadosQueRecebemMaisDe1500;
            while (flag != "-1")
            {
                counterEmpregados++;
                Console.WriteLine("Digite o salario dos empregados:");
                salario = double.Parse(Console.ReadLine());
                if(salario < 1300)
                {
                    empregadosSalarioMinimo++;
                }
                valorTotalFolhaPagamento += salario;
                if(salario > 1500 && salario < 3500)
                {
                    counterEmpregadosQueRecebemMaisDe1500++;
                }
                Console.WriteLine("Digite -1 para sair:");
                flag = Console.ReadLine();
                if(flag == "-1")
                {
                    break;
                }
            }
            Console.WriteLine($"Empregados que recebem salario minimo: {empregadosSalarioMinimo}");
            Console.WriteLine($"Valor gasto com salário: {valorTotalFolhaPagamento}");
            mediaSalarialEmpresa = valorTotalFolhaPagamento / counterEmpregados;
            porcentcounterEmpregadosQueRecebemMaisDe1500 = counterEmpregadosQueRecebemMaisDe1500 / counterEmpregados * 100;
            Console.WriteLine($"Media salarial: {mediaSalarialEmpresa}");
            Console.WriteLine($"Porcentagem de quem ganha +1500: {porcentcounterEmpregadosQueRecebemMaisDe1500}");
            Console.ReadLine();
        }
    }
}
