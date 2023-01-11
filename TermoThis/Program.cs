using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar acessar = new Acessar();

            if (acessar.Login("abc12345"))
            {
                Console.WriteLine("Acesso concedido");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }

            Console.ReadKey();

        }
    }
}
