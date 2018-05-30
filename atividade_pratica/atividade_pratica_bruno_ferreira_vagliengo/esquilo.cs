using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class esquilo : aeronave
    {
        public override void locomover()
        {
            Console.WriteLine("Hélice");
        }
        public override void abastecer()
        {
            Console.WriteLine("Diesel");
        }

        public override string ToString()
        {
            return "Esquilo {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Fuselagem = " + corFuselagem + '}';
        }
    
    }
}
