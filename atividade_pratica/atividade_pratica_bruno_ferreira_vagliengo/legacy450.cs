using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class legacy450 : aeronave
    {
        public override void locomover()
        {
            Console.WriteLine("Turbina");
        }
        public override void abastecer()
        {
            Console.WriteLine("Querosene");
        }


        public void decolar(string clima)
        {
            if (clima == "chuva e nublado")
            {
                Console.WriteLine("voo por instrumento");
            }
            else if (clima == "neve")
            {
                Console.WriteLine("sem vooz");
            }
            else
            {
                Console.WriteLine("voo normal");
            }
        }
        public void decolar(int hora)
        {
            if (hora < 12)
            {
                Console.WriteLine("altitude mais alta");
            }
            else if(hora>=18)
            {
                Console.WriteLine("altitude baixa");
            }
            else
            {
                Console.WriteLine("altitude média");
            }
        }
        public void decolar(bool passageiros)
        {
            if (passageiros == true)
            {
                Console.WriteLine("servir refeição");
            }
            else
            {
                Console.WriteLine("amarrar bem a carga");
            }
        }
        public void decolar(float gasolina)
        {
            if (gasolina >= 80)
                Console.WriteLine("Pode decolar, combustível suficiente!");
            }
            {
            else
            {
                Console.WriteLine("Não pode decolar, combustível insuficiente!"); 
            }
        }

        public override string ToString()
        {
            return "Legacy 450 {" + "marca = " + marca + ", pneu = " + pneu + ", ano = " + ano + ", cor Fuselagem = " + corFuselagem + '}';
        }
    }
}
