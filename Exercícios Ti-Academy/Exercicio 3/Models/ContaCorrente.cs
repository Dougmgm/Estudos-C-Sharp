using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public class ContaCorrente
    {
        public string? NomeCorrentista { get; set; }
        private int NumeroConta { get; set; }
        private int NumeroAgencia { get; set; }
        private double Saldo { get; set; }
    }
}
