using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class fusca : carro
    {
        public override void locomover()
        {
            Console.WriteLine("Tração 2 rodas");
        }
        public override void abastecer()
        {
            Console.WriteLine("Gasolina");
        }

        public override string ToString()
        {
            return "Fusca {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Carro = " + corCarro + '}';
        }
    }
}
