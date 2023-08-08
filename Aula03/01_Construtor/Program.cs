namespace _01_Construtor;
class Program
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        Console.WriteLine(c);

        Console.WriteLine(" == Nome do cliente: " + c.Nome);
        Console.WriteLine(" == Limite do cliente: " + c.consultarLimite());
        Console.WriteLine(" == ID do cliente: " + c.consultarID());

        // --> Explorando sobrecarga
        Data d1 = new(8,8,2023);
        // "Data d = new()" não é possível no contexto de haver um construtor.
        d1.print();

        // > Sobrecarga do construtor
        Data d2 = new();
        d2.print();

        // - Nova data a partir da data objeto "d1"
        d2 = new(d1);
        d2.print();

        d2 = new(8, 10, "1975");
        d2.print();

        Data.imprimeAlgo();

        // --> Irá manter o maior dado informado para cada atributo
        Data d3 = d1+d2;
        Console.Write(" == D1: ");
        d1.print();
        Console.Write(" == D2: ");
        d2.print();
        Console.Write(" == D3: ");
        d3.print();

        d3 = d1 + 2;
        d3.print();

        //===================================================================
        // --> Herança

        Animal animal = new Animal();
        Console.WriteLine(animal.toString());
        animal.EmiteSom();

        Felino gatinho = new Felino("Persa");
        Console.WriteLine(gatinho.toString());
        gatinho.EmiteSom();
    }
}
