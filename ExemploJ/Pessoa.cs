using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploJ
{
    class Pessoa
    {
             private string nome;
        private double salario;

        public double Salario
        {
            get
            {
                return this.salario;
            }
            set
            {
                if (this.salario > value)
                {
                    Console.WriteLine("Salario atual maior que o informado");
                }
                else
                {
                    this.salario = value;
                    Console.WriteLine("Salario Atualizado");
                }
            }
        }
        public Pessoa()
        {

        }
        public Pessoa(string nome, double salario)
        {
            this.nome = nome;
        }

        public string Nome
        {
            get
            {
                return this.nome.ToUpper();
            }
            set
            {
                this.nome = value;
            }
        }

        public string Email { get; set; }
    }
}
