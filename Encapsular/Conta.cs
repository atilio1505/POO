using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Conta
    {
        private string cliente;
        private double saldo;
        private double taxa = 10;

        public string Cliente
        { 
            get { return cliente; }
            set
            {
                if (value != "Atilio" && value != "Correia")
                {
                    cliente = "Visitante";
                    Saldo = 0;
                }
                else
                {
                    cliente = value;
                    Saldo = 100;
                }
            }
        }

        public double Saldo 
        {
            get { return saldo; }
            private set { saldo = value; }
        }

        public void Sacar(double valor)
        {
            valor += taxa;
            this.saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
    }
}
