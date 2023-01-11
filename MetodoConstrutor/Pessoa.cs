using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int anoNascimento;
        public int idade;

        public Pessoa()
        {
            nome = "Desconhecido";
            sobreNome = "nenhum";
            anoNascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome, string sobreNome, int anoNascimento)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.anoNascimento = anoNascimento;
            idade = CalculoIdade();
        }

        public Pessoa(string nome, string sobreNome)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.anoNascimento = 2002;
        }
        private int CalculoIdade()
        {
            string anoAtual = DateTime.Now.ToString("yyyy");
            int resultado = int.Parse(anoAtual) - anoNascimento;
            return resultado;
        }
    }
}
