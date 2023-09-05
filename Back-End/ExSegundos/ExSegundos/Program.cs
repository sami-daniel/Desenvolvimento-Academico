using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSegundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas,tempo,resto, minutos;
            int segundos;
            Console.WriteLine("Digite o número de segundos");
            tempo = int.Parse(Console.ReadLine());
            horas = tempo / 3600; resto = tempo % 3600; minutos = resto / 60;segundos = resto % 60;
            Console.WriteLine("As horas são igual a: " + horas + "h " + minutos + "min " + segundos + "seg");
            Console.ReadLine();
        }
    }
}
