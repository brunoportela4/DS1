using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class carro : veiculo
    {
        public string corCarro;


        public string getCorCarro()
        {
            return corCarro;
        }
        public void setCorCarro(string corCarro)
        {
            this.corCarro = corCarro;
        }


        public override string ToString()
        {
            return "Carro {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Carro = " + corCarro + '}';
        }
    }
}
