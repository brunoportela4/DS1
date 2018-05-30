using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_heranca_bruno_ferreira_vagliengo
{
    public class tartaruga : reptil
    {
        public override void locomover()
        {
            Console.WriteLine("A tartaruga está se locomovendo lentamente!");
        }

        public override string ToString()
        {
            return "Tartaruga {" + "peso = " + peso + ", idade = " + idade + ", membros = " + membros + ", corEscama = " + corEscama + '}';
        }
    }

}