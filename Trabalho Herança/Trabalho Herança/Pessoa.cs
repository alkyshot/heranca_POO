using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Herança
{
    class Pessoa
    {
        //Atributos
        protected string Nome;
        protected int Idade;
        protected string Sexo;


        //Métodos
        protected void mensagemPessoa()
        {
            Console.WriteLine("Nome: " +Nome);
            Console.WriteLine("Idade: " +Idade);
            Console.WriteLine("Sexo:" +Sexo);
        }


    }
}
