﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classe estaticas
            //Matematica.taxa = 10;
            //int valor1 = Matematica.Adicionar(200);
            //int valor2 = Matematica.Diminuir(200);
            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);
            #endregion

            #region Membro Estaticos
            Pessoa.maiorIdade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Atilio";
            p1.idade = Pessoa.CalcularIdade(1998);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maiorIdade);

            #endregion
            Console.ReadKey();
        }
    }
}
