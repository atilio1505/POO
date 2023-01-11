using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carro c = new Carro();
            //Bicicleta b = new Bicicleta();
            //c.Acelerar();
            //b.Acelerar();

            Humano a = new Humano();
            Pessoas b = new Pessoas();
            Homem c = new Homem();

            a.Olhos();
            a.Cabelos();
            Console.WriteLine();
            b.Olhos();
            b.Cabelos();
            Console.WriteLine();
            c.Olhos();
            c.Cabelos();

            Console.ReadKey();
        }
    }
}
