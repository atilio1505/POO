using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            MinhaClasse mClasse = new MinhaClasse();
            OutraClasse outraClasse = new OutraClasse();
            OutraClasse outraClasse2 = outraClasse;
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Gabriel";
            p1.sobreNome = "Artigas";
            p1.anoNascimento = 1985;

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                sobreNome = "Maciel",
                anoNascimento = 1999
            };

            Console.WriteLine(p1.nome + " " + p1.sobreNome + " - " + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine(p2.nome + " " + p2.sobreNome + " - " + p2.anoNascimento);
            p2.Cumprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse
    {
        
    }
}
