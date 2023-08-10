public class Pilha: IPilha, IUmaCoisa, IOutraCoisa{
    //=================================================================
    // --> Interface
    void IUmaCoisa.metodo(){
        Console.WriteLine("Um metodo da interface UmaCoisa;");
    }

    void IOutraCoisa.metodo(){
        Console.WriteLine("Outra coisa do método;");
    }

    //=================================================================
    private List<object> minhaListaDeObjetos;
    private int nElementos;

    public Pilha(){
        minhaListaDeObjetos = new List<object>();
        nElementos=0;
    }

    //=================================================================
    // --> Métodos da Interface IPilha
    public void Empilha(object parametro){
        minhaListaDeObjetos.Add(parametro);
        nElementos++;
    }

    public object? Desempilha(){
        if(nElementos>0){
            object aux = minhaListaDeObjetos[nElementos-1];
            minhaListaDeObjetos.RemoveAt(nElementos-1);
            nElementos--;
            return aux;
        }
        else
            return null;
    }

    public object? Topo{
        get{
            if(nElementos>0)
                return minhaListaDeObjetos[nElementos-1];
            else
                return null;
        }
    }

    //=================================================================
    public int QtdeElementos{
        get{return minhaListaDeObjetos.Count;}
    }
}