using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_pasta.Models
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double Area(){
            return Altura * Largura;
        }

        public double Perimetro(){
            return 2*(Largura + Altura);
        }

        public double Diagonal(){
            return Math.Sqrt((Largura*Largura) + (Altura * Altura));
        }
    }
}