using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        // Atributos ou campos
        public string nome;
        public string sobreNome;
        public int anoNascimento;

        //Metodos simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, eu sou " + this.nome + " " + this.sobreNome);
        }
    }
}
