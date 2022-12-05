using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_pasta.Models
{
    public class Estudante
    {
        public string? Nome;
        public string? Email;
        public int Quarto;

        public Estudante(string nome, string email){             //Fazer teste posteriormente
            Nome = nome;
            Email = email;
        }

        // public override string ToString()                    //Fazer teste posteriormente
        // {
        //     return Quarto + ": " + Nome + ", " + Email;
        // }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}