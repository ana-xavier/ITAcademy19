// A classe abstrata vai funcionar como um contrato.

public abstract class Animal{
    private decimal peso;
    private decimal altura;

    public Animal(){
        this.peso = -1;
        this.altura = -1;
        Console.WriteLine("Construtura da classe animal");
    }

    public abstract void EmitirSom();

    public override string? ToString(){
        return $"peso({this.peso}); altura({this.altura})";
    }
}