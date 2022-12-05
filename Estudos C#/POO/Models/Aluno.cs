using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Aluno : Pessoa // dois pontos serve para a classe Aluno herdar da classe Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar() //Polimorfismo para fazer a troca do que o código irá mostrar 
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade} e sou um aluno nota {Nota}");
        }
    }
}