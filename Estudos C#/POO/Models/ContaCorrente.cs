using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public decimal Saldo { get; private set; } //deixa como private para ninguem conseguir alterar graças ao encapsulamento 

        public ContaCorrente(decimal saldoInicial) //construtor: contrói classe com valores pré-definidos -> requisito
        {
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor){

            if(valor <= Saldo) {

                Saldo = Saldo - valor;

                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso");

            } else {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine($"Seu saldo é de R$ {Saldo}");
        }
    }
}