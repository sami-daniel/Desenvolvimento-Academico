using System;

namespace Ex02Pag73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] vet = new int[20];

            for (int i = 0; i < vet.Length; i++)
                vet[i] = random.Next(1,100);

            foreach (int i in vet)
            {
                if (i > 50)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
