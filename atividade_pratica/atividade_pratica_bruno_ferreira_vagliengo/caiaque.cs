using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class caiaque : embarcacao
    {
        public override void locomover()
        {
            Console.WriteLine("A remo");
        }
        public override void abastecer()
        {
            Console.WriteLine("Depende da força do remador");
        }

        public override string ToString()
        {
            return "Caiaque {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Casco = " + corCasco + '}';
        }
    }
}
