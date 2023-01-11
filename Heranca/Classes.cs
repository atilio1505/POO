using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }

    class Pessoas : Humano
    {
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoas.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoas.Cabelos");
        }
    }

    class Homem : Pessoas
    {
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }
    }
}
