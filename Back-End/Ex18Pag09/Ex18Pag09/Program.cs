using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18Pag09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, nNotas, resto = 0;
            
            //variaveis utilizadas
            Console.Write("Valor que deseja trocar: R$");

            resto = Convert.ToInt32(Console.ReadLine());
            //o resto é igual ao que for digitado       
            Console.WriteLine("Notas de troco: ");

            int[] nota = { 100, 50, 10, 5, 2, 1 };
            //cria uma lista que contem o valor respectivo de cada nota, com 7 posicoes

            for (int i = 0; i < 6; i++) { 
                //laco de repeticao
                nNotas = resto / nota[i];
                //o numero de notas passa a ser igual ao resto dividido pelo valor da nota na posicao i
                resto = resto%nota[i];
                //o resto passa a ser igual ao resto % nota na posicao i
                Console.WriteLine(nNotas + " nota(s) de R$" + nota[i] + ",00");
            }
            
            Console.ReadKey();
            //22201491
        }
    }
}
