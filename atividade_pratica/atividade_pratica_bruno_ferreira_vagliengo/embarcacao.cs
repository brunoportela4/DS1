using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class embarcacao : veiculo
    {
        public string corCasco;


        public string getCorCasco()
        {
            return corCasco;
        }
        public void setCorCasco(string corCasco)
        {
            this.corCasco = corCasco;
        }

        public virtual void ancorar()
        {
            Console.WriteLine("A embarcação está sendo ancorada!");
        }

        public override string ToString()
        {
            return "Embarcação {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Casco = " + corCasco + '}';
        }
    }
}
