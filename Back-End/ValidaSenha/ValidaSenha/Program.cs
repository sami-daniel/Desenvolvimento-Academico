using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;
            Console.WriteLine("Digite a senha: "); senha = Convert.ToInt32(Console.ReadLine());
            while(senha != 1234)
            {
                Console.WriteLine("Acesso negado");
                Console.WriteLine("Digite a senha: "); 
                senha = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
            Console.ReadKey();
        }
    }
}
