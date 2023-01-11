using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Nome = "Atilio";
            t.Idade = 24;

            Console.WriteLine(t.Nome + " " + t.SobreNome);
            Console.WriteLine(t.Idade);
            Console.ReadKey();
        }
    }
}
