using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public class ContaCorrente
    {
        public string? NomeCorrentista { get; set; }
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        private double Saldo { get; set; }
    }
}