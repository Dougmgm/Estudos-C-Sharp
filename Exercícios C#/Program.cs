using System.Globalization;
using Nova_pasta.Models;
using System.Collections.Generic;

// Triangulo x, y;

// Triangulo x = new Triangulo();
// Triangulo y = new Triangulo();

// Console.WriteLine("Entre com as medidas do triangulo X:");
// x.A = Convert.ToDouble(Console.ReadLine());
// x.B = Convert.ToDouble(Console.ReadLine());
// x.C = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Entre com as medidas do triangulo Y:");
// y.A = Convert.ToDouble(Console.ReadLine());
// y.B = Convert.ToDouble(Console.ReadLine());
// y.C = Convert.ToDouble(Console.ReadLine());

// double areaX = x.Area();
// double areaY = y.Area();

// Console.WriteLine($"A area do triangulo X é de {areaX} e a area do triangulo Y é de {areaY}");

//Exercício 1

// Pessoa p1 = new Pessoa();
// Pessoa p2 = new Pessoa();

// Console.WriteLine("Escreva o nome e idade da primeira pessoa");
// p1.Nome = Console.ReadLine();
// p1.Idade = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Escreva o nome e idade da segunda pessoa");
// p2.Nome = Console.ReadLine();;
// p2.Idade = Convert.ToInt32(Console.ReadLine());

// if(p1.Idade > p2.Idade){
//     Console.WriteLine($"{p1.Nome} é a pessoa mais velha");
// } else {
//     Console.WriteLine($"{p2.Nome} é a pessoa mais velha");
// }

//Exercício 2

// Pessoa p3 = new Pessoa();
// Pessoa p4 = new Pessoa();

// Console.WriteLine("Escreva o nome da primeira pessoa");
// p3.Nome = Console.ReadLine();

// Console.WriteLine("Escreva o salario da primeira pessoa");
// p3.Salario = Convert.ToDouble(Console.ReadLine());;

// Console.WriteLine("Escreva o nome da segunda pessoa");
// p4.Nome = Console.ReadLine();

// Console.WriteLine("Escreva o salario da segunda pessoa");
// p4.Salario = Convert.ToDouble(Console.ReadLine());;

// double media = (p3.Salario + p4.Salario) / 2;
// Console.WriteLine($"A média salarial é {media}");

//Exercicio 3

/*
Produto p = new Produto();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = Convert.ToDouble(Console.ReadLine());
Console.Write("Quantidade no estoque: ");
p.Quantidade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.WriteLine("Digite o número de produtos a ser adicionada no estoque: ");
int qtde = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qtde);

Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine("Digite o número de produtos a ser retirados no estoque: ");
qtde = int.Parse(Console.ReadLine());
p.RemoverProdutos(qtde);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);
*/

//Exercício de fixação 1

/*
Retangulo ret = new Retangulo();

Console.WriteLine("Entre a altura do retangulo");
ret.Altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre a largura do retangulo");
ret.Largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Area = " + ret.Area().ToString());
Console.WriteLine("Perimetro = "+ ret.Perimetro().ToString());
Console.WriteLine("Diagonal = " + ret.Diagonal().ToString());
*/

//Exercício de fixação 2

/*Funcionario func = new Funcionario();

Console.Write("Digite o nome: ");
func.Nome = Console.ReadLine();
Console.Write("Digite o salário bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine());
Console.Write("Digite o imposto: ");
func.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Funcionário: " + func);
Console.WriteLine();

Console.Write("Digite a porcentagem para aumentar o salário:" );
double porcent = double.Parse(Console.ReadLine());
func.AumentarSalario(porcent);
Console.WriteLine();

Console.WriteLine("Dados atualizados: "  + func);
*/

//Exercício de fixação 3

/*Aluno estudante = new Aluno();

Console.Write("Digite o nome do aluno: ");
estudante.Nome = Console.ReadLine();
Console.WriteLine("Digite as notas de cada trimestre");
estudante.Nota1 = double.Parse(Console.ReadLine());
estudante.Nota2 = double.Parse(Console.ReadLine());
estudante.Nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Nota final = " + estudante.Soma());
if(estudante.Soma() < 60){
    Console.WriteLine("Reprovado");
    Console.WriteLine("Faltaram " + estudante.Restante() + " pontos");
} else {
    Console.WriteLine("Aprovado");
}*/

//Exercicio 3 com contrutor 

// Produto p = new Produto("TV", 500.0, 10); // ---> Com o construtor é necessário passar os valores dentro do produto
/*
Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
string nome = Console.ReadLine(); // cria variavel auxiliar apenas para receber dados digitados
Console.Write("Preço: ");
double preco = Convert.ToDouble(Console.ReadLine()); // cria variavel auxiliar apenas para receber dados digitados
Console.Write("Quantidade no estoque: ");
int quantidade = Convert.ToInt32(Console.ReadLine()); // cria variavel auxiliar apenas para receber dados digitados

Produto p = new Produto(nome, preco, quantidade); //--->instancia o produto já informando os dados


Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.WriteLine("Digite o número de produtos a ser adicionada no estoque: ");
int qtde = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qtde);

Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine("Digite o número de produtos a ser retirados no estoque: ");
qtde = int.Parse(Console.ReadLine());
p.RemoverProdutos(qtde);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);
*/

/*
Produtos p = new Produtos("TV", 500, 10);

Console.WriteLine(p.GetNome()); // linha obtem dados de cima
p.SetNome("TV 4K");
Console.WriteLine(p.GetNome()); //linha obtem dados da função SetNome e chamada pela p.GetNome  
*/

//Auto-Property

// Produtos p = new Produtos("TV", 500, 10);

// Console.WriteLine(p.GetNome()); // linha obtem dados de cima
// p.SetNome("TV 4K");
// Console.WriteLine(p.GetNome()); //linha obtem dados da função SetNome e chamada pela p.GetNome  

//Exercício de fixação Construtores


// a

//Struct
/*
Point p;
// Console.WriteLine(p); // Irá dar erro pois é uma variável não atribuída (não foi inicializada)
p.X = 10;
p.Y = 20;
Console.WriteLine(p); // Não dará mais erro pois definiu X e Y
p = new Point();
Console.WriteLine(p); //Colocando o "new" ele acaba inicializando com valor 0
*/

//Garbage Collector : Automatiza gerenciamento de memória de RAM de um programa em execução 

//Vetores

/*Exercicio 1: Fazer um programa para ler um número inteiro N e a altura de N pessoas.
Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
pessoas.*/

/*
Console.Write("Escreva a quantidade alturas: ");
int qtd = int.Parse(Console.ReadLine());

double[] vetor = new double [qtd]; //Colchetes indica vetor

for (int i = 0; i < qtd; i++){
    vetor[i] = double.Parse(Console.ReadLine());
}

double soma = 0;
for(int i = 0; i < qtd; i++){
    soma = soma + vetor[i];
}

double media = soma / qtd;

Console.Write("A média das alturas é de: " + media.ToString("F2"));
*/

/*Exercício 2: Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos. Armazene os N produtos em um vetor. 
Em seguida, mostrar o preço médio dos produtos.*/

/*
int qtd = int.Parse(Console.ReadLine());
Product[] vetor = new Product[qtd];

Console.WriteLine("Escreva os nomes e preços dos produtos");

for (int i = 0; i < qtd; i++){
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine());
    vetor[i] = new Product {Name = name, Price = price }; //Cria o objeto usando o vetor para receber as variaveis na classe para criar na memomoria esses dados
}

double soma = 0;
for(int i = 0; i < qtd; i++){
    soma +=vetor[i].Price; //O vetor na posição "i" irá buscar todos os dados naquelas posição, logo para considerar apenas o preço deve escrever ele
}
double media = soma / qtd;
Console.WriteLine("Preço medio igual a " + media.ToString("F2"));
*/

//Exercício de fixação vetores

                                /*      A dona de um pensionato possui dez quartos para alugar para estudantes,
                                        sendo esses quartos identificados pelos números 0 a 9.
                                        Quando um estudante deseja alugar um quarto, deve-se registrar o nome
                                        e email deste estudante.
                                        Fazer um programa que inicie com todos os dez quartos vazios, e depois
                                        leia uma quantidade N representando o número de estudantes que vão
                                        alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
                                        N estudantes. Para cada registro de aluguel, informar o nome e email do
                                        estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
                                        que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
                                        um relatório de todas ocupações do pensionato, por ordem de quarto,
                                        conforme exemplo                                                            */

// Exemplo de vetor: Classe[] nome = new Classe[posição];
// Vetor instanciado dentro do loop: nome[posição] = new Classe {nomeObjeto = nomeVariavel; nomeObjeto2 = nomeVariavel, etc}


// Estudante[] vetor = new Estudante[10];

// Console.Write("Quantos quartos vão ser alugados: ");
// int qtde = int.Parse(Console.ReadLine());

// for (int i = 1; i <= qtde; i++){
//     Console.WriteLine($"Aluguel #{i}");
//     Console.Write("Nome: ");
//     string? nome = Console.ReadLine();
//     Console.Write("Email: ");
//     string? email = Console.ReadLine();
//     Console.Write("Quarto: ");
//     int quarto = int.Parse(Console.ReadLine());
//     vetor[quarto] = new Estudante(nome, email);
// }

// Console.WriteLine();
// Console.WriteLine("Quartos ocupados:");
// for (int i = 0; i < 10; i++) {
//     if (vetor[i] != null) {
//         Console.WriteLine(i + ": " + vetor[i]);
//     }
// }

// Estudante[] vetor = new Estudante[10];

// Console.Write("Quantos quartos vão ser alugados: ");
// int qtde = int.Parse(Console.ReadLine());

// for (int i = 1; i <= qtde; i++){
//     Console.WriteLine($"Aluguel #{i}");
//     Console.Write("Nome: ");
//     string? nome = Console.ReadLine();
//     Console.Write("Email: ");
//     string? email = Console.ReadLine();
//     Console.Write("Quarto: ");
//     int quarto = int.Parse(Console.ReadLine());
//     vetor[quarto] = new Estudante {Nome = nome, Email = email, Quarto = quarto};
// }

// Console.WriteLine();
// Console.WriteLine("Quartos ocupados:");
// for (int i = 0; i < 10; i++) {
//     if (vetor[i] != null) {
//         Console.WriteLine(i + ": " + vetor[i]);
//     }
// }


//Listas
/*
List<string> list = new List<string>(); //LISTA VAZIA, SÓ APÓS INSTANCIAR QUE PODERÁ ACRESCENTAR OS DADOS
List<string> list2 = new List<string>{"Douglas", "Juliana"}; //Dados já inseridos na lista
list.Add(new Classe()); //Adicionar com classe
*/

/*
List<string> list = new List<string>();
list.Add("Douglas");
list.Add("Juliana");
list.Add("Leonardo");
list.Insert(2, "Marco"); // Com insert você primeiro escolhe a posição (Ex: 2) e o valor que estará nela ("Marco")

foreach(string lista in list){
    Console.WriteLine(lista);
}

Console.WriteLine(list.Count); //Contagem do numero de elementos na lista

// Find na lista

string s1 = list.Find(x => x[0] == 'D'); //recebe predicado (função que pega um valor e retorna verdadeiro ou falso conforme a logica da função) como elemento //Expressão lambda
Console.WriteLine("Primeira letra 'D': " + s1);
*/

//Exercício de fixação listas

/*
                                                Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
                                                N funcionários. Não deve haver repetição de id.
                                                Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
                                                Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
                                                mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
                                                conforme exemplos.
                                                Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
                                                ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
                                                aumento por porcentagem dada.
*/



List<Empregados> lista = new List<Empregados>();

Console.Write("Quantos funcionários serão registrados? ");
int qtd = int.Parse(Console.ReadLine());

for (int i = 1; i <= qtd; i++){
    Console.WriteLine("Empregado #" + i);
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine());
    lista.Add(new Empregados(id, nome, salario));
}

Console.WriteLine();

Console.Write("Entre com o ID do funcionário que terá o salário aumentado: ");
int funcId = int.Parse(Console.ReadLine());

Empregados emp = lista.Find(x => x.Id == funcId);
if(emp != null){
    Console.Write("Entre a porcentagem: ");
    double porcentagem = double.Parse(Console.ReadLine());
    emp.AumentarSalario(porcentagem);
} else {
    Console.WriteLine("Esse ID não existe");
}

Console.WriteLine();
Console.WriteLine("Lista atualizada de funcionários");
foreach (Empregados funcionarios in lista) {
    Console.WriteLine(funcionarios.ToString());
}
