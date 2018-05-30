using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class veiculo
    {
        
        public string marca;
        public int pneu;
        public int ano;


        public string getMarca()
        {
            return marca;
        }
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        
        public int getPneu()
        {
            return pneu;
        }
        public void setPneu(int pneu)
        {
            this.pneu = pneu;
        }
        
        public int getAno()
        {
            return ano;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }


        public virtual void locomover()
        {
            Console.WriteLine("O veículo está se locomovendo!");
        }

        public virtual void abastecer()
        {
            Console.WriteLine("O veículo está sendo abastecido!");
        }

        public override string ToString()
        {
            return "Veículo {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + '}';
        }
    }
}
