using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class picapes10 : carro
    {
        public override void locomover()
        {
            Console.WriteLine("Tração 4 rodas");
        }
        public override void abastecer()
        {
            Console.WriteLine("Diesel");
        }

        public override string ToString()
        {
            return "Picape S10 {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Carro = " + corCarro + '}';
        }
    }
}
