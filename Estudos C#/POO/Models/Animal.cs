using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Animal
    {
        public string? raca { get; set; }
        public double tamanho { get; set; }
        public virtual void EmitirSom() 
        {
            Console.WriteLine("Som emitido do animal: ");
        }

        public void DadosAnimal(){
            Console.WriteLine($"Tem {tamanho}m de tamanho e é da raça {raca}");
        }
    }
}


