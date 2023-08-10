public class Gato: Animal{
    public Gato(){
        Console.WriteLine("O construtor do gato");
    }

    public override void EmitirSom(){
        Console.WriteLine("miau");
    }
}