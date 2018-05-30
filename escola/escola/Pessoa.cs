using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace escola
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string sexo;

        public void fazerAniversario()
        {
            this.idade++;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string Nome)
        {
            this.nome = Nome;
        }
        
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int Idade)
        {
            this.idade = Idade;
        }
        
        public string getSexo()
        {
            return sexo;
        }
        public void setSexo(string Sexo)
        {
            this.sexo = Sexo;
        }

        public override string ToString()
        {
            return "Pessoa{ " + " nome = " + nome +", idade = " + idade +", sexo = " + sexo + '}';
        }
    }
}
