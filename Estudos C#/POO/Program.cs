using POO.Models;
using System.Collections.Generic;

// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "Douglas";
// pessoa.Idade = 24;

// pessoa.Apresentar();

// Pessoa pessoaNova = new Pessoa();

// pessoaNova.Nome = "Juliana";
// pessoaNova.Idade = 23;

// pessoaNova.Apresentar();

// ContaCorrente cc = new ContaCorrente(50);

// cc.Numero = 1234;
// // cc.Saldo = 50; //tem que apagar o saldo pois ele está encapsulado para não poder ser alterado por alguem fora da classe 
// cc.Sacar(30);
// cc.ExibirSaldo();

// Aluno a1 = new Aluno();

// a1.Nome = "Douglas"; //Aluno herda nome da classe Pessoa
// a1.Idade = 24;
// a1.Nota = 80; //Já nota vem da classe Aluno 
// a1.Apresentar();

//Exercício 1

public class Cachorro : Animal {
    public override void EmitirSom(){
        Console.WriteLine("O cachorro late");
    }
}

public class Gato : Animal {
    public override void EmitirSom(){
        Console.WriteLine("O gato mia");
    }
}

public class Passaro : Animal {
    public override void EmitirSom(){
        Console.WriteLine("O passaro faz piu-piu");
    }
}

class Programa{
    static void Main(string[] args){
        Animal Cachorro = new Cachorro();
        Animal Gato = new Gato();
        Animal Passaro = new Passaro();

        Cachorro.raca = "Vira Lata";
        Cachorro.tamanho = 1.50;

        Gato.raca = "Persa";
        Gato.tamanho = 0.60;

        Passaro.raca = "Calopsita";
        Passaro.tamanho = 0.30;

        Cachorro.EmitirSom();
        Cachorro.DadosAnimal();

        Gato.EmitirSom();
        Gato.DadosAnimal();

        Passaro.EmitirSom();
        Passaro.DadosAnimal();
    }
}

//Listas em C#

// List<int> grades = new List<int>(){5,10}; //--> valores dentro da lista
// grades.Add(15); //---> valores acrescentados na lista
// grades.Add(20); //---> valores acrescentados na lista
// grades.Insert(2, 17); //---> insere o valor na posição estabelecida e "empurra" os outros para frente 

// Console.WriteLine(grades [0]);


//Crie um algoritmo que verifique se um número informado é par ou impar

// Console.WriteLine("Escreva um número");
// int par = Convert.ToInt32(Console.ReadLine());

// int teste = par % 2;

// if(teste == 1){
//     Console.WriteLine("Seu número é impar");
// } else {
//     Console.WriteLine("Seu número é par");
// }

//Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.

// int qtde = 0;

// for(int i = 0; i < 10; i++){

//     Console.WriteLine("Informe a idade das pessoas");

//     int idade = Convert.ToInt32(Console.ReadLine());

//     if (idade >= 18){
//         qtde = qtde + 1;
//     }
// }

// Console.WriteLine($"A quantidade de pessoas acima de 18 anos é: {qtde}");

/*Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte 
regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.*/   

// double reajustado, salario = 0;

// for (int i = 0; i < 10; i++){

//     Console.Write("Escreva o salário dos funcionário: ");
//     salario = Convert.ToDouble(Console.ReadLine());

//     if(salario <= 300) {
//         reajustado = (salario * 0.5) + salario;
//         Console.WriteLine($"O valor do {i}° salário reajustado será de {reajustado}");
        
//         } else {
//         reajustado = (salario * 0.3) + salario;
//         Console.WriteLine($"O valor do {i}° salário reajustado será de {reajustado}");
//         }
//     }       


// Console.WriteLine(  "digite o salario dos funcionários" );

// double reajuste;

// for(int i = 1; i <= 10; i++){ 
//     Console.Write($"{i}°: ");
//     double salario = double.Parse(Console.ReadLine());
//     if(salario > 300.00){
//             reajuste = 0.5 * salario;
//             salario += reajuste;
//         }else{
//             reajuste = 0.3 * salario;
//             salario += reajuste;
//         }
//         Console.WriteLine($"O valor do {i}° salário reajustado será de {salario}");
// }

//Operadores matemáticos

// int x = -20;
// int y = 10;
// int z = 15;

// Console.WriteLine(Math.Max(y,z)); //Achar o máximo

// Console.WriteLine(Math.Min(y, z)); //Achar o mínimo

// Console.WriteLine(Math.Sqrt(z)); //Achar a raiz quadrada (Square Root)

// Console.WriteLine(Math.Abs(x)); //Número absoluto (Módulo)

