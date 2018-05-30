using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class cb200 : motocicleta
    {
        public override void locomover()
        {
            Console.WriteLine("Tração roda traseira");
        }
        public override void abastecer()
        {
            Console.WriteLine("Álcool");
        }

        public override string ToString()
        {
            return "CB200 {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Motocicleta = " + corMotocicleta + '}';
        }
    }
}
