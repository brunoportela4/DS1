using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade_pratica_bruno_ferreira_vagliengo
{
    class Program
    {
        static void Main(string[] args)
        {

            veiculo veiculo1 = new veiculo();
            carro veiculo2 = new carro();
            motocicleta veiculo3 = new motocicleta();
            embarcacao veiculo4 = new embarcacao();
            aeronave veiculo5 = new aeronave();
            fusca veiculo6 = new fusca();
            picapes10 veiculo7 = new picapes10();
            cb200 veiculo8 = new cb200();
            caiaque veiculo9 = new caiaque();
            esquilo veiculo10 = new esquilo();
            legacy450 veiculo11 = new legacy450();


            veiculo1.setMarca("Fiat");
            veiculo1.setAno(2009);
            veiculo1.setPneu(4);
            veiculo2.setMarca("Chevrolet");
            veiculo2.setAno(2010);
            veiculo2.setPneu(5);
            veiculo2.setCorCarro("Verde");
            veiculo3.setMarca("Dafra");
            veiculo3.setAno(2015);
            veiculo3.setPneu(2);
            veiculo3.setCorMotocicleta("Rosa");
            veiculo4.setMarca("Sem marca");
            veiculo4.setAno(2010);
            veiculo4.setPneu(0);
            veiculo4.setCorCasco("Verde-água");
            veiculo5.setMarca("Sem marca");
            veiculo5.setAno(2017);
            veiculo5.setPneu(9);
            veiculo5.setCorFuselagem("Branco");
            veiculo6.setMarca("Volkswagen");
            veiculo6.setAno(1995);
            veiculo6.setPneu(4);
            veiculo6.setCorCarro("Azul");
            veiculo7.setMarca("Ford");
            veiculo7.setAno(2018);
            veiculo7.setPneu(6);
            veiculo7.setCorCarro("Prata");
            veiculo8.setMarca("Honda");
            veiculo8.setAno(2016);
            veiculo8.setPneu(2);
            veiculo8.setCorMotocicleta("Vermelha");
            veiculo9.setMarca("Overboard");
            veiculo9.setAno(2012);
            veiculo9.setPneu(0);
            veiculo9.setCorCasco("Laranja");
            veiculo10.setMarca("Sem marca");
            veiculo10.setAno(2007);
            veiculo10.setPneu(2);
            veiculo10.setCorFuselagem("Marrom");
            veiculo11.setMarca("Sem marca");
            veiculo11.setAno(2011);
            veiculo11.setPneu(4);
            veiculo11.setCorFuselagem("Dourado");
     

            Console.WriteLine(veiculo1.ToString());
            veiculo1.locomover();
            veiculo1.abastecer();
            Console.WriteLine(veiculo2.ToString());
            veiculo2.locomover();
            veiculo2.abastecer();
            Console.WriteLine(veiculo3.ToString());
            veiculo3.locomover();
            veiculo3.abastecer();
            Console.WriteLine(veiculo4.ToString());
            veiculo4.locomover();
            veiculo4.abastecer();
            veiculo4.ancorar();
            Console.WriteLine(veiculo5.ToString());
            veiculo5.locomover();
            veiculo5.abastecer();
            veiculo5.arremeter();
            Console.WriteLine(veiculo6.ToString());
            veiculo6.locomover();
            veiculo6.abastecer();
            Console.WriteLine(veiculo7.ToString());
            veiculo7.locomover();
            veiculo7.abastecer();
            Console.WriteLine(veiculo8.ToString());
            veiculo8.locomover();
            veiculo8.abastecer();
            Console.WriteLine(veiculo9.ToString());
            veiculo9.locomover();
            veiculo9.abastecer();
            veiculo9.ancorar();
            Console.WriteLine(veiculo10.ToString());
            veiculo10.locomover();
            veiculo10.abastecer();
            veiculo10.arremeter();
            Console.WriteLine(veiculo11.ToString());
            veiculo11.locomover();
            veiculo11.abastecer();
            veiculo11.arremeter();
            veiculo11.decolar("chuva e nublado");
            veiculo11.decolar("chuva");
            veiculo11.decolar("neve");
            veiculo11.decolar("sol");
            veiculo11.decolar(11);
            veiculo11.decolar(15);
            veiculo11.decolar(18);
            veiculo11.decolar(true);
            veiculo11.decolar(false);
            veiculo11.decolar(82.11f);
            veiculo11.decolar(70.52f);
            Console.ReadKey();
        }
    }
}
