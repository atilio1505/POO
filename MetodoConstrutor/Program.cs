using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Atilio", "Correia", 1998);
            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobreNome);
            Console.WriteLine(p1.anoNascimento);
            Console.WriteLine(p1.idade);

            Console.WriteLine();

            Pessoa p2 = new Pessoa("Lucas", "Silva");
            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.sobreNome);
            Console.WriteLine(p2.anoNascimento);
            Console.ReadKey();
        }
    }
}
