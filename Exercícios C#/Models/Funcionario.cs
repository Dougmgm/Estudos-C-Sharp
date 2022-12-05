using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_pasta.Models
{
    public class Funcionario
    {
        public string? Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(){
            double liquido = SalarioBruto - Imposto;
            return liquido;
        }

        public void AumentarSalario(double porcentagem){           
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return Nome + ", " + "$ " + SalarioLiquido().ToString();
        }
    }
}