public class Cliente
{
    public const string tipo = "Pessoa";
    private string nome;
    private decimal limiteCredito;
    private uint clienteID;

    public string Nome{
        get{ return nome;}
        set{ nome = value;}
    }

    public void saudacao(){
        Console.WriteLine("Olá");
    }

    public void AumentarLimite(decimal valor){
        limiteCredito += valor;
    }

    public decimal consultarLimite(){
        return limiteCredito;
    }

    public void MetodoNormal(int a, int b){
        b = 2*a;
    }
    
    public void MetodoOut(int a, out int b){
        b = a*200;
    }  

    public void MetodoRef(int a, ref int b){
        b += a;
    }

    public void MetodoParam(params int [] listaDeParametros){
        for(int i = 0; i < listaDeParametros.Length; i++){
            Console.WriteLine("  param["+i+"]: " + listaDeParametros[i]);
        }
    }    
}
