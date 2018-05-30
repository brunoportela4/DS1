using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace escola
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Aluno pessoa2 = new Aluno();
            Professor pessoa3 = new Professor();
            Funcionario pessoa4 = new Funcionario();
            Professor pessoa5 = new Professor();
            Professor pessoa6 = new Professor();

            pessoa1.setNome("Luis");
            pessoa1.setIdade(30);
            pessoa2.setNome("Maria");
            pessoa2.setCurso("TI");
            pessoa2.setNome("Luisa");
            pessoa3.setSalario(3000.50f);
            pessoa4.setNome("João");
            pessoa4.setTrabalhando(false);
            pessoa5.setIdade(35);
            pessoa5.setSexo("Masculino");
            pessoa5.setEspecialidade("Word");
            pessoa5.setSalario(2500.68f);
            pessoa6.setNome("Roberto");
            pessoa6.setIdade(55);
            pessoa6.setSexo("Masculino");
            pessoa6.setEspecialidade("Redes");
            pessoa6.setSalario(954);
            pessoa6.receberAumento(50f);
            pessoa6.fazerAniversario();

            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine(pessoa2.ToString());
            Console.WriteLine(pessoa3.ToString());
            Console.WriteLine(pessoa4.ToString());
            Console.WriteLine(pessoa5.ToString());
            Console.WriteLine(pessoa6.ToString());


            

            Console.ReadKey();
        }
    }
}
