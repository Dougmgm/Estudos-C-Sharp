using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace Nova_pasta.Models
{
    public class Produtos //Para atributos privados!
    {
        private string? _nome;
        private double _preco;
        private int _quantidade; 

        //Com Auto-Property

        public double Preco { get; private set; } //Não permite outros arquivos a alterarem o valor do preço 
        public int Quantidade { get; private set ; } //Não permite outros arquivos a alterarem o valor da Quantidade


        public string? GetNome(){
            return _nome;
        }

        public void SetNome(string nome){ // vantagem é poder fazer if else
            if(nome != null && nome.Length > 1){
                _nome = nome;
            }
        }

        public Produtos(){

        }
        public Produtos (string nome, double preco, int quantidade){
            _nome = nome;
            _preco = Preco;
            _quantidade = Quantidade;
        }
                public double ValorTotalEstoque(){
           return Preco * Quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $"+ Preco.ToString("F2", CultureInfo.InvariantCulture)+", " + Quantidade + " unidades, Total: $" 
            + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos(int quantidade){ //Void pois não é necessário retornar valor de saída 
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade){
            Quantidade = Quantidade - quantidade;
        }


    }
}