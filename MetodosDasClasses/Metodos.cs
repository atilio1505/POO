using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        // Métodos simples
        public void Cumprimentar()
        {
            Console.WriteLine("olá, seja bem vindo");
        }

        // Métodos com parametros
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos");
        }

        // Passagem de parametro com valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final é " + valor);
        }

        // Passagem de parametro com referencia
        public void AumentarValor(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final com ref é " + valor);
        }

        // Métodos com retorno de valores
        public string MontaNome(string nome, string sobreNome)
        {
            return nome + " " + sobreNome;
        }

        public int CodigoChar(char caractere)
        {
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }

        // Sobrecarga de metodos
        public void Cumprimentar(string nome, string sobreNome)
        {
            Console.WriteLine("olá, seja bem vindo" + nome + " " + sobreNome);
        }

        public void Cumprimentar(string nome, string sobreNome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia " + nome + " " + sobreNome : "Boa tarde " + nome + " " + sobreNome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Comparar(string texto1, string texto2)
        {
            return texto1 == texto2;
        }
    }
}
