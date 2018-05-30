using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_heranca_bruno_ferreira_vagliengo
{
    class Program
    {
        static void Main(string[] args)
        {
            animal animal1 = new animal();
            mamifero animal2 = new mamifero();
            reptil animal3 = new reptil();
            ave animal4 = new ave();
            canguru animal5 = new canguru();
            cachorro animal6 = new cachorro();
            tartaruga animal7 = new tartaruga();
            tucano animal8 = new tucano();
            
            animal1.setPeso(23);
            animal1.setIdade(12);
            animal1.setMembros(4);
            animal2.setPeso(20);
            animal2.setIdade(5);
            animal2.setMembros(4);
            animal2.setCorPelo("Marrom");
            animal2.setRaca("Pastor Alemão");
            animal3.setPeso(19);
            animal3.setIdade(12);
            animal3.setMembros(0);
            animal3.setCorEscama("Verde");
            animal4.setPeso(15);
            animal4.setIdade(10);
            animal4.setMembros(2);
            animal4.setCorPena("Branco");
            animal5.setPeso(6);
            animal5.setIdade(1);
            animal5.setMembros(2);
            animal5.setCorPelo("Bege");
            animal5.setRaca("Neo-zelandês");
            animal6.setPeso(15);
            animal6.setIdade(30);
            animal6.setMembros(4);
            animal6.setCorPelo("Dourado");
            animal6.setRaca("Labrador");
            animal7.setPeso(100);
            animal7.setIdade(120);
            animal7.setMembros(4);
            animal7.setCorEscama("Não tem escamas!");
            animal8.setPeso(2);
            animal8.setIdade(40);
            animal8.setMembros(2);
            animal8.setCorPena("Preto");

            Console.WriteLine(animal1.ToString());
            animal1.locomover();
            animal1.alimentar();
            animal1.emitirSom();
            Console.WriteLine(animal2.ToString());
            animal2.locomover();
            animal2.alimentar();
            animal2.emitirSom();
            Console.WriteLine(animal3.ToString());
            animal3.locomover();
            animal3.alimentar();
            animal3.emitirSom();
            Console.WriteLine(animal4.ToString());
            animal4.locomover();
            animal4.alimentar();
            animal4.emitirSom();
            animal4.fazerNinho();
            Console.WriteLine(animal5.ToString());
            animal5.locomover();
            animal5.alimentar();
            animal5.emitirSom();
            animal5.usarBolsa();
            Console.WriteLine(animal6.ToString());
            animal6.locomover();
            animal6.alimentar();
            animal6.emitirSom();
            animal6.enterrarOsso();
            animal6.abanarRabo();
            animal6.reagir("brincar");
            animal6.reagir("acariciar");
            animal6.reagir("chutar");
            animal6.reagir(10);
            animal6.reagir(14);
            animal6.reagir(23);
            animal6.reagir(true);
            animal6.reagir(false);
            Console.WriteLine(animal7.ToString());
            animal7.locomover();
            animal7.alimentar();
            animal7.emitirSom();
            Console.WriteLine(animal8.ToString());
            animal8.locomover();
            animal8.alimentar();
            animal8.emitirSom();

            Console.ReadKey();
        }
    }
}
