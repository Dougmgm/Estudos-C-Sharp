using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_pasta.Models
{
    public class ContaBancaria
    {
        // public int Numero {get; private set;}
        // public string? Titular;
        // public double Saldo {get; private set;}

        // public ContaBancaria (int numero, string titular, double saldo){
        //     Numero = numero;
        //     Titular = titular;
        //     Saldo = saldo;
        // }

        // public void Deposito(double quantia){
        //     Saldo = Saldo + quantia;
        // }

        // public void Saque(double quantia){
        //     Saldo = Saldo - quantia - 5;
        // }

        // public override string ToString()
        // {
        //     return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString();
        // }


        public int Numero { get; private set; }
        public string? Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular){ // Construtor
        Numero = numero;
        Titular = titular;
        }

        public ContaBancaria (int numero, string titular, double saldo) : this(numero, titular) { // This para repassar o construtor de dois argumentos
            Saldo = saldo;
        }


        public void Deposito(double quantia) {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia){
            Saldo = Saldo - quantia - 5.00;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", " + "Titular: " + Titular + ", " + "Saldo: R$ " + Saldo.ToString("F2");
        }

    }
}