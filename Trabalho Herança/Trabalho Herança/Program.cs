using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor("Everton", 40, "Masculino", "POO",10000);

            Aluno aluno = new Aluno("Rodrigo", 21, "Masculino", 2083140, "Ciencias da Computação");

            Console.ReadLine();
        }

    }
}
