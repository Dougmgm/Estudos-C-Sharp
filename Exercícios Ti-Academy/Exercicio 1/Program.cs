//Exercício 1

using POO.Models;

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

        Cachorro.Raca = "Vira Lata";
        Cachorro.Tamanho = 1.50;

        Gato.Raca = "Persa";
        Gato.Tamanho = 0.60;

        Passaro.Raca = "Calopsita";
        Passaro.Tamanho = 0.30;

        Cachorro.EmitirSom();
        Cachorro.DadosAnimal();

        Console.WriteLine("");

        Gato.EmitirSom();
        Gato.DadosAnimal();

        Console.WriteLine("");

        Passaro.EmitirSom();
        Passaro.DadosAnimal();
    }
}
