using System;

namespace Ex01Pag73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];

            for (int i = 0; i < vet.Length; i++)
                vet[i] = int.Parse(Console.ReadLine());
            foreach(int i in vet)
                Console.WriteLine(i);
        }
    }
}
