public class Animal{
    private int anoDeNascimento;
    private decimal altura, peso;
    private string nome;

    public Animal(): this("Sem nome", -1, -1, -1){}

    public Animal(string _nome, int _anoNascimento, decimal _altura, decimal _peso){
        anoDeNascimento = _anoNascimento;
        altura = _altura;
        peso = _peso;
        nome = _nome;
    }

    public void EmiteSom(){
        Console.WriteLine("Som do animal!");
    }

    public virtual string toString(){
        return " \n == Nome: " + nome + " \nNascimento: " + anoDeNascimento + " \nPeso: " + peso + " \nAltura: " + altura;
    }
}