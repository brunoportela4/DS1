using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_heranca_bruno_ferreira_vagliengo
{
    public class reptil : animal
    {
        public string corEscama;

        public override void locomover()
        {
            Console.WriteLine("O réptil está se locomovendo!");
        }
        public override void alimentar()
        {
            Console.WriteLine("O réptil está se alimentando!");
        }
        public override void emitirSom()
        {
            Console.WriteLine("O réptil está fazendo barulhos!");
        }

        public string getCorEscama()
        {
            return corEscama;
        }
        public void setCorEscama (string corEscama)
        {
            this.corEscama = corEscama;
        }

  
        public override string ToString()
        {
            return "Réptil {" + "peso = " + peso + ", idade = " + idade + ", membros = " + membros + ", corEscama = " + corEscama + '}';
        }
    }
}
