using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Herança
{
    class Aluno : Pessoa
    {
        // Atributos
        private int Matricula;
        private string Curso;

        //Construtor
        public Aluno(string Nome, int Idade, string Sexo, int Matricula, string Curso)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Sexo = Sexo;
            this.Matricula = Matricula;
            this.Curso = Curso;

            mensagemPessoa();
            mensagemAluno();
        }

        // Método

        protected void mensagemAluno()
        {
            Console.WriteLine("Matricula: " + Matricula);
            Console.WriteLine("Curso: " + Curso);
        }

    }
}
