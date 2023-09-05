using System;

namespace Ex03Pag73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue;
            Random r = new Random();

            int[] vet = new int[50];

            for (int i = 0; i < vet.Length; i++)
                vet[i] = r.Next();
            foreach(int i in vet)
            {
                if(i > maior)
                    maior = i;
            }
            Console.WriteLine(maior);
            Console.ReadKey();
        }
    }
}
