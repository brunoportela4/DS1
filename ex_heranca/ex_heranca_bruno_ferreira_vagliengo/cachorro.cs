using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_heranca_bruno_ferreira_vagliengo
{
    public class cachorro : mamifero
    {

        public void enterrarOsso()
        {
            Console.WriteLine("O cachorro está enterrando um osso!");
        }
        public void abanarRabo()
        {
            Console.WriteLine("O cachorro está abanando seu rabo!");
        }

        public override string ToString()
        {
            return "Cachorro {" + "peso = " + peso + ", idade = " + idade + ", membros = " + membros + ", raça = " + raca + ", corPelo = " + corPelo + '}';
        }

        public void reagir(string atitude)
        {
            if (atitude == "brincar" || atitude == "acariciar")
            {
                Console.WriteLine("O cachorro está abanando o rabo!");
            }
            else
            {
                Console.WriteLine("O cachorro está rosnando!");
            }
        }
        public void reagir(int hora)
        {
            if (hora < 12)
            {
                Console.WriteLine("O cachorro está abanando o rabo e latindo!");
            }
            else if(hora>=18)
            {
                Console.WriteLine("O cachorro não está ligando para o dono!");
            }
            else
            {
                Console.WriteLine("O cachorro está abanando o rabo!");
            }
        }
        public void reagir(bool dono)
        {
            if (dono == true)
            {
                Console.WriteLine("O cachorro está abanando o rabo e brincando!");
            }
            else
            {
                Console.WriteLine("O cachorro está avançando e rosnando!");
            }
        }
    }

}