using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {
        //definição de campos
        private string nome;
        public string SobreNome { get; } = "Correia";
        private int idade;

        //definição de uma propriedade
        public string Nome 
        { 
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set 
            { 
                if(value < 18)
                {
                    Console.WriteLine("Idade não permitida");
                }
                else
                {
                    idade = value;
                }
            }
        }

        public void Apresentar()
        {
            if (nome != "")
                Console.WriteLine("Bem vindo " + nome);
        }
    }
}
