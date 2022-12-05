using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_pasta.Models
{
    public class Empregados
    {
        public int Id;
        public string Nome;
        public double Salario;

        public Empregados(int id, string nome, double salario){
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public double AumentarSalario(double porcentagem){
            return Salario += Salario * porcentagem / 100;
        }
        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario;
        }
    }
}