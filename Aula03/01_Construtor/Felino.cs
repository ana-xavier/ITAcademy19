public class Felino: Animal{
    private string raca;

    public Felino(string _raca): base("Bichano", 1970, 20, 10){
        raca = _raca;
    }

    public void EmiteSom(){
        Console.WriteLine("Ronronar");
    }

    public override string toString(){
        return base.toString() + "\nA raça do gato: " + raca;
    }
}