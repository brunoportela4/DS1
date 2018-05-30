using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class aeronave : veiculo
    {
        public string corFuselagem;


        public string getCorFuselagem()
        {
            return corFuselagem;
        }
        public void setCorFuselagem(string corFuselagem)
        {
            this.corFuselagem = corFuselagem;
        }

        public virtual void arremeter()
        {
            Console.WriteLine("A aeronave está arremetendo!");
        }

        public override string ToString()
        {
            return "Aeronave {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Fuselagem = " + corFuselagem + '}';
        }
    }
}
