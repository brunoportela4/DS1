﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace escola
{
    public class Professor : Pessoa
    {
        private string especialidade;
        private float salario;

        public void receberAumento(float aum)
        {
            this.salario += aum;
        }
        public string getEspecialidade()
        {
            return especialidade;
        }
        public void setEspecialidade(string especialidade)
        {
            this.especialidade = especialidade;
        }
        public float getSalario()
        {
            return salario;
        }
        public void setSalario(float salario)
        {
            this.salario = salario;
        }
        public override string ToString()
        {
            return "Professor{" + "especialidade=" + especialidade + ",salario=" + salario + ",nome=" + nome + ",idade=" + idade + ",sexo=" + sexo + '}';
        }
    }
}

