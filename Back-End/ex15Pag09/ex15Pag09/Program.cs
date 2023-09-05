using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15Pag09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qst,acertos;
            string erros;
            Console.Write("Questões da prova: ");
            qst = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de acertos: ");
            acertos = Convert.ToInt32(Console.ReadLine());
            erros = Convert.ToString(qst-acertos);
            Console.WriteLine("O números de questões que errou: "+ erros);
            Console.WriteLine("A porcentagem de acertos é igual a: "+((100*acertos)/qst)+"%");
            Console.WriteLine("A porcentagem de erros é igual a: "+(100*Convert.ToInt32(erros))/qst+"%");
            Console.ReadKey();
        }
    }
}
