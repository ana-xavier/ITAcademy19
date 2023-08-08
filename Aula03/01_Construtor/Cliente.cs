public class Cliente
{
    public const string tipo = "Pessoa";
    private string nome;
    private decimal limiteCredito;
    private uint clienteID;

    // --> Método construtor
    public Cliente(){
        nome = "Ana Xavier";
        limiteCredito = -1;
        clienteID = 1;
    }
    
    public string Nome{
        get{ return nome;}
        set{ nome = value;}
    }

    public void AumentarLimite(decimal valor){
        limiteCredito += valor;
    }

    public decimal consultarLimite(){
        return limiteCredito;
    }

    public decimal consultarID(){
        return clienteID;
    }
}