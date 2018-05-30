using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class motocicleta : veiculo
    {
        public string corMotocicleta;


        public string getCorMotocicleta()
        {
            return corMotocicleta;
        }
        public void setCorMotocicleta(string corMotocicleta)
        {
            this.corMotocicleta = corMotocicleta;
        }


        public override string ToString()
        {
            return "Motocicleta {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Motocicleta = " + corMotocicleta + '}';
        }
    }
}
