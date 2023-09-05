using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Digite o nome do funcionario: ");
            funcionario.nome = Console.ReadLine();

            Console.WriteLine("Digite a classe do funcionario: ");
            funcionario.classe = Console.ReadLine().ToUpper();
            while(funcionario.classe != "A" && funcionario.classe != "B" && funcionario.classe != "C")
            {
                Console.WriteLine("Digite a classe do funcionario: ");
                funcionario.classe = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Digite as horas trabalhadas do funcionario: ");
            funcionario.numerodehoras = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Funcionario: {funcionario.nome}\n");
            switch (funcionario.classe)
            {
                case "A":
                    Console.Write("Valor a ser pago: "+ (funcionario.numerodehoras * 8).ToString("C"));
                    break;
                case "B":
                    Console.Write("Valor a ser pago: " + (funcionario.numerodehoras * 12).ToString("C"));
                    break;
                case "C":
                    Console.Write("Valor a ser pago: " + (funcionario.numerodehoras * 17).ToString("C"));
                    break;
            }

            Console.ReadKey();
        }
        class Funcionario
        {
            public string nome { get; set; }
            public string classe { get; set;}
            public int numerodehoras { get; set;}
        }
    }
}
