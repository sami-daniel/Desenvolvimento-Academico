using System;
using System.Collections.Generic;
using Ex10PAg73.Entities;
using Ex10PAg73.Entities.Enums;

namespace Ex10PAg73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            while (true)
            {
                Console.WriteLine("Insira o nome do funcionario: ");
                string nomeFuncionario = Console.ReadLine();
                Console.WriteLine("Insira a classe do funcionario: ");
                string classe = Console.ReadLine();
                ClassedoFuncionario classedoFuncionario = (ClassedoFuncionario)Enum.Parse(typeof(ClassedoFuncionario), classe);
                funcionarios.Add(new Funcionario(nomeFuncionario, classedoFuncionario));
                Console.WriteLine();
                Console.WriteLine("Deseja sair (S/N)");
                string saida = Console.ReadLine().ToUpper();
                if (saida == "S") break;
            }

            int[] classeCont = new int[7];
            int maior = int.MinValue;
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine($"Nome do funcionario: {funcionario.Nome}");
                switch (funcionario.classedoFuncionario)
                {
                    case ClassedoFuncionario.classe1:
                        classeCont[0]++;
                        break;
                    case ClassedoFuncionario.classe2:
                        classeCont[1]++;
                        break;
                    case ClassedoFuncionario.classe3:
                        classeCont[2]++;
                        break;
                    case ClassedoFuncionario.classe4:
                        classeCont[3]++;
                        break;
                    case ClassedoFuncionario.classe5:
                        classeCont[4]++;
                        break;
                    case ClassedoFuncionario.classe6:
                        classeCont[5]++;
                        break;
                    case ClassedoFuncionario.classe7:
                        classeCont[6]++;
                        break;
                }
                int index = 0;
                for(int i = 0; i < classeCont.Length; i++)
                {
                    Console.WriteLine($"Funcionários de classe {i+1}: {classeCont[i]}");
                    if(classeCont[i] > maior) { 
                        maior = classeCont[i];
                        index = i;
                    }
                }
                Console.WriteLine($"Classe com mais funcionarios: classe {index + 1} com {maior} funcionarios");
            }
        }
    }
}
