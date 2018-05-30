using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_heranca_bruno_ferreira_vagliengo
{
    public class animal
    {
        public float peso;
        public int idade;
        public int membros;
        
        public virtual void locomover()
        {
            Console.WriteLine("O animal está se locomovendo!");
        }

        public virtual void alimentar()
        {
            Console.WriteLine("O animal está se alimentando!");
        }

        public virtual void emitirSom()
        {
            Console.WriteLine("O animal está emitindo som!");
        }
        
        public float getPeso()
        {
            return peso;
        }
        public void setPeso(int Peso)
        {
            this.peso = Peso;
        }
        
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int Idade)
        {
            this.idade = Idade;
        }
        
        public int getMembros()
        {
            return membros;
        }
        public void setMembros(int Membros)
        {
            this.membros = Membros;
        }

        public override string ToString()
        {
            return "Animal {" + "peso = " + peso + ", idade = " + idade + ", membros = " + membros + '}';
        }

    }
}
