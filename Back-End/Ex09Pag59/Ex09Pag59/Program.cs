using System;
using System.Globalization;

namespace Ex09Pag59
{
    internal class Program
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa();

            while (true)
            {
                Console.WriteLine("Insira o nome da pessoa: (Caso queira sair digite SAIR)");
                string nome = Console.ReadLine();
                if (nome == "SAIR")
                    break;
                else
                {
                    Console.WriteLine("Insira o sexo da pessoa: ");
                    pessoa.Sexo = Console.ReadLine()[0];
                    pessoa.Sexo = char.ToUpper(pessoa.Sexo);
                    Console.WriteLine("Insira a idade da pessoa: ");
                    int idade = int.Parse(Console.ReadLine());

                    if (pessoa.Sexo == 'F')
                        pessoa.ContadorDeMulheres++;
                    if (pessoa.Sexo == 'F' && idade > 18)
                        pessoa.ContadorDeMulheresComMaisDe18Anos++;
                    if (pessoa.Sexo == 'M')
                    {
                        pessoa.ContadorDeHomens++;
                        pessoa.SomaDeIdadeDosHomens += idade;
                        pessoa.MediaDeIdadeDosHomens = pessoa.SomaDeIdadeDosHomens / pessoa.ContadorDeHomens;
                    }
                    if (pessoa.Sexo == 'F' && idade >= 20 && idade <= 29)
                    {
                        pessoa.ContadorDeMulheresQueTemEntre20E29Anos++;
                        pessoa.PorcentagemDeMulheresQueTemEntre20E29Anos = (pessoa.ContadorDeMulheresQueTemEntre20E29Anos * 100) / pessoa.ContadorDeMulheres;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Numéro de mulheres com mais de 18 anos: {pessoa.ContadorDeMulheresComMaisDe18Anos}");
            Console.WriteLine();
            Console.WriteLine($"Media de idade do homens: {pessoa.MediaDeIdadeDosHomens.ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"Porcentagem de mulheres que têm entre 20 e 29 anos: {pessoa.PorcentagemDeMulheresQueTemEntre20E29Anos.ToString(CultureInfo.InvariantCulture)}%");
        }
    }
    internal class Pessoa
    {
        public char Sexo;
        public double PorcentagemDeMulheresQueTemEntre20E29Anos;
        public int ContadorDeMulheres;
        public int ContadorDeMulheresQueTemEntre20E29Anos;

        public double MediaDeIdadeDosHomens;
        public int SomaDeIdadeDosHomens;

        public int ContadorDeMulheresComMaisDe18Anos;

        public int ContadorDeHomens;
    }
}
