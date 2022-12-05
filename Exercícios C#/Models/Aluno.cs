using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_pasta.Models
{
    public class Aluno
    {
        public string? Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Soma(){
            double total = Nota1 + Nota2 + Nota3;
            return total;
        }

        public double Restante(){
            return 60 - Soma();
        }

        // public double Conferencia(){
        //     if(Soma() < 60){
        //     Console.WriteLine("Reprovado");
        //     Console.WriteLine("Faltaram " + Restante() + " pontos");
        //     } else {
        //         Console.WriteLine("Aprovado");
        //     }
        //     return Conferencia();
        // }
    }
}