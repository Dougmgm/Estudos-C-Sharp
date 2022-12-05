using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Nova_pasta.Models
{
    public class Produto
    {
        public string? Nome;
        public double Preco;
        public int Quantidade; // Private faz "Quantidade" não ser acessada por outra classe

        //Construtor = Permitir ou obrigar que o objeto receba dados / dependências no momento de sua instanciação (injeção de dependência) e Iniciar valores dos atributos 

        public Produto(string nome, double preco, int quantidade){ // Isso é um construtor
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // Não é necessário incluir a Quantidade pois se ignorar ela automaticamente irá ter valor 0    
        }

        public double ValorTotalEstoque(){
           return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $"+ Preco.ToString("F2", CultureInfo.InvariantCulture)+", " + Quantidade + " unidades, Total: $" 
            + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos(int quantidade){ //Void pois não é necessário retornar valor de saída 
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade){
            Quantidade = Quantidade - quantidade;
        }

        internal bool GetNome()
        {
            throw new NotImplementedException();
        }
    }
}