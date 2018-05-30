using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_heranca_bruno_ferreira_vagliengo
{
    public class ave : animal
    {
        public string corPena;

        public override void locomover()
        {
            Console.WriteLine("A ave está voando!");
        }
        public override void alimentar()
        {
            Console.WriteLine("A ave está comendo!");
        }
        public override void emitirSom()
        {
            Console.WriteLine("A ave está emitindo sons!");
        }

        public void fazerNinho()
        {
            Console.WriteLine("A ave está fazendo ninho!");
        }


        public string getCorPena()
        {
            return corPena;
        }
        public void setCorPena(string corPena)
        {
            this.corPena = corPena;
        }


        public override string ToString()
        {
            return "Ave {" + "peso = " + peso + ", idade = " + idade + ", membros = " + membros + ", corPena = " + corPena + '}';
        }
    }
}
