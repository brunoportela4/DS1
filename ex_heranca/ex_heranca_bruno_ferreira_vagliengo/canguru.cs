using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_heranca_bruno_ferreira_vagliengo
{
    public class canguru : mamifero
    {

        public override void locomover()
        {
            Console.WriteLine("O canguru está pulando!");
        }

        public void usarBolsa()
        {
            Console.WriteLine("O canguru está usando sua bolsa!");
        }

        public override string ToString()
        {
            return "Canguru {" + "peso = " + peso + ", idade = " + idade + ", membros = " + membros + ", raça = " + raca + ", corPelo = " + corPelo + '}';
        }
    }

}
