using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.Cliente = "Atilio";
            //c.Saldo = 100;

            //Operações 
            double valorDeposito = 100;
            c.Depositar(valorDeposito);

            double valorSaque = 50;
            c.Sacar(valorSaque);

            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);
            Console.ReadKey();

        }
    }
}
