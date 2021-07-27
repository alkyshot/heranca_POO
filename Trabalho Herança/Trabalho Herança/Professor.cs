using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Herança
{
    class Professor : Pessoa
    {
        //Atributos
        private string Disciplina;
        private double Salario;

        //Construtor
        public Professor(string Nome, int Idade, string Sexo, string Disciplina, double Salario)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Sexo = Sexo;
            this.Disciplina = Disciplina;
            this.Salario = Salario;

            mensagemPessoa();
            mensagemProfessor();
        }

        //Métodos
        protected void mensagemProfessor()
        {
            Console.WriteLine("Diciplina: "+Disciplina);
            Console.WriteLine("Salario: "+Salario);
        }
    }
}
