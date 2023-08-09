public class Pessoa{
    public string nome;
    public int idade{get; private set;}

    public int anoDeNascimento{
        get{
            DateTime hoje = DateTime.Now;
            return hoje.Year - this.idade;
        }
        // --> "value" é uma propriedade (no caso, o ano de nascimento)
        set{
            this.idade = DateTime.Now.Year - value;
        }
    }

    //public Pessoa(): this("Ana Xavier", 21){}

    public Pessoa(string nome, int idade){
        this.nome = nome;
        this.idade = idade;
    }

    public string humor(){
        Random r = new Random();

        switch(r.Next(3)){
            case 0: return "Alegre";
            case 2: return "Feliz";
            case 3: return "Contente";
            default: return "Apático";
        }
    }

    // --> Sobreescrita do método para a classe Pessoa
    //     - O ponto de interrogação informa que pode ser anulável
    public override string? ToString(){
        string texto;
        texto = "| ========================= |";
        texto += $"\n =  Nome:       {this.nome}";
        texto += $"\n =  Idade:      {this.idade}";
        texto += $"\n =  Nascimento: {this.anoDeNascimento}";
        texto += "\n| ========================= |";
        return texto;
    }
}