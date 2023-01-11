using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metodos simples
            Metodos m = new Metodos();
            //m.Cumprimentar();
            //m.Somar(5, 5);
            //m.Apresentar("Atilio", 24);
            #endregion

            #region Metodos com parametros
            //int valor1 = 20;
            //int valor2 = 20;

            //m.AumentarValor(valor1);
            //Console.WriteLine(valor1);

            //m.AumentarValor(ref valor2);
            //Console.WriteLine(valor2);
            #endregion

            #region Metodos com retorno de valores
            //string nomeCompleto = m.MontaNome("Atilio", "Correia");
            //int codigoChar = m.CodigoChar('a');
            //double pi = m.ValorPI();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);
            #endregion

            #region Sobrecarga de metodos
            //m.Cumprimentar();
            //m.Cumprimentar("Atilio", "Correia");
            //m.Cumprimentar("Atilio", "Correia", 18);

            //bool res1 = m.Comparar(100, 50 * 2);
            //bool res2 = m.Comparar("Atilio", "atilio");

            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            #endregion



            Console.ReadKey();
        }
    }
}
