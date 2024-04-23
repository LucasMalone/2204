using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            double[] decimais = new double[10];
            string[] nomes = new string[10];
            

            numeros[0] = 1;
            numeros[1] = 2;
            int indice = 0;
            for (indice = 0; indice < 10; indice++)
            {
                nomes[indice] = "nomes";
                Console.WriteLine("Nomes [0]", nomes[indice]);

            }

            Pessoa p = new Pessoa("Kastel",1100);
            //p.Nome = "Kastel";
            Console.WriteLine("nome: {0}", p.Nome);
            p.Salario = 1001;
            p.Salario = 900;
            p.Salario = 1101;
            Console.WriteLine("salario {0}", p.Salario);

            Console.WriteLine("Vetor convidados\n");
            nomes[0] = "Kastel";
            Console.WriteLine("Nomes[0]:{0}", nomes[0]);
            numeros[0] = 1;
            Console.WriteLine("Numeros[0]:{0}", numeros[0]);
            decimais[0]  = 2.4;
            Console.WriteLine("Decimais[0]:{0}", decimais[0]);
            Pessoa[] convidados = new Pessoa[10];
            Pessoa funcionario = new Pessoa();
            for(int i = 0; i < convidados.Length; i++)
            convidados[0] = funcionario;
            convidados[0] = funcionario;
            convidados[0].Nome = "Kastel";
            Console.WriteLine("Objeto Pessoal:{0}", convidados);
            Console.ReadKey();
        }
    }
}
