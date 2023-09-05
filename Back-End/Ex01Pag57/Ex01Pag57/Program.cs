using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Pag57
{
    internal class Program
    {
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public bool Presente { get; set; }
        public Program(string nome, char sexo, bool presente)
        {
            Nome = nome;
            Sexo = sexo;
            Presente = presente;
        }
        static void Main(string[] args)
        {
            char sexoT;
            string Name;
            int presença;
            bool Presente;
            List<Program> list = new List<Program>();
            while (true)
            {
                Console.Write("Insira o nome do aluno(a): ");
                Name = Console.ReadLine();
                Console.Write("\nInsira o sexo do aluno(a)(F ou M): ");
                while (true)
                {
                    try
                    {
                        sexoT = Console.ReadLine()[0];
                        sexoT = char.ToUpper(sexoT);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Write("\nInsira o sexo do aluno(a)(F ou M): ");
                    }
                }
                
                while(sexoT != 'F' && sexoT != 'M')
                {
                    Console.Write("\nInsira o sexo do aluno(a)(F ou M): ");
                }

                Console.WriteLine("\nO aluno está presente? Insira 0 para não 1 para sim");
                while (true)
                {
                    try
                    {
                        presença = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nO aluno está presente? Insira 0 para não 1 para sim");
                    }
                }
                while(presença != 0 & presença != 1)
                {
                    try
                    {
                        presença = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nO aluno está presente? Insira 0 para não 1 para sim(Caso nenhum\nValor seja detectado ou um valor diferente, sera computado a falta)");
                    }
                }
                switch (presença)
                {
                    case 0:
                        Presente = false;
                        break;
                        case 1:
                        Presente = true;
                        break;
                    default:
                        Presente = false;
                        break;
                }
                list.Add(new Program(Name, sexoT, Presente));
                Console.Clear();
                Console.WriteLine("Digite 2 para sair ou não: ");
                string Saida = Console.ReadLine();
                if (Saida == "2")
                {
                    Console.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"Aluno: {list[i].Nome}\nSexo: {list[i].Sexo}\nPresente:{list[i].Presente}");
                        Console.WriteLine("");
                    }
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }

        }
    }
    
}
