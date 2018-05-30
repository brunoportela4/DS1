using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_heranca_bruno_ferreira_vagliengo
{
    public class mamifero : animal
    {
        public string corPelo;
        public string raca;

        public override void locomover()
        {
            Console.WriteLine("O mamífero está andando!");
        }
        public override void alimentar()
        {
            Console.WriteLine("O mamífero está mamando!");
        }
        public override void emitirSom()
        {
            Console.WriteLine("O mamífero está emitindo sons!");
        }

        public string getCorPelo()
        {
            return corPelo;
        }
        public void setCorPelo(string corPelo)
        {
            this.corPelo = corPelo;
        }

        public string getRaca()
        {
            return raca;
        }
        public void setRaca(string raca)
        {
            this.raca = raca;
        }


        public override string ToString()
        {
            return "Mamífero {" + "peso = " + peso + ", idade = " + idade + ", membros = " + membros + ", raça = " + raca + ", corPelo = " + corPelo + '}';
        }
    }

}
