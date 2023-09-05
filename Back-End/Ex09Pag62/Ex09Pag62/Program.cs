using System;

namespace Ex09Pag62
{
    internal class Program
    {   
        static void Main()
        {
            Aluno[] alunos = new Aluno[4];
            double maior = double.MinValue, maior2 = double.MinValue, nota;
            long maiorNumMatricula, maior2NumMatricula;


            //Notas: Nâo funcionara com 2 ou menos repetições:

            nota = maiorNumMatricula = maior2NumMatricula = 0;

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Write($"Insira o número de matricula do {i + 1}º aluno: ");
                long matriculaAluno = long.Parse(Console.ReadLine());
                Console.Write("Insira a nota do aluno: ");
                if (i == 0)
                {
                    maior = maior2 = nota = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                    maiorNumMatricula = maior2NumMatricula = matriculaAluno;
                }
                else
                {
                    nota = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                }
                Console.WriteLine("-----------------------------------------------------------------");
                if (nota > maior)
                {
                    maior2 = maior;
                    maior = nota;
                    maior2NumMatricula = maiorNumMatricula;
                    maiorNumMatricula = matriculaAluno;
                }
                else if (nota < maior && nota > maior2)
                {
                    maior2 = nota;
                    maior2NumMatricula = matriculaAluno;
                }

                alunos[i] = new Aluno(matriculaAluno, nota);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            foreach (Aluno aluno in alunos)
                Console.WriteLine(aluno);
            Console.WriteLine();
            Console.Write($"Maior nota: {maior} | Número de mátricula do aluno: {maiorNumMatricula}\nSegunda maior nota nota: {maior2} | Número de mátricula do aluno: {maior2NumMatricula}\n");
            Console.WriteLine();
        }
    }
}
