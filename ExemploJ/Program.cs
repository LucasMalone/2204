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
            Pessoa p = new Pessoa("Kastel",1100);
            //p.Nome = "Kastel";
            Console.WriteLine("nome: {0}", p.Nome);
            p.Salario = 1001;
            p.Salario = 900;
            p.Salario = 1101;
            Console.WriteLine("salario {0}", p.Salario);
            Console.ReadKey();
        }
    }
}
