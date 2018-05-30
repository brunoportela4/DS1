using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_heranca_bruno_ferreira_vagliengo
{
    class tucano : ave
    {
        public override string ToString()
        {
            return "Tucano {" + "peso = " + peso + ", idade = " + idade + ", membros = " + membros + ", corPena = " + corPena + '}';
        }
    }
}
