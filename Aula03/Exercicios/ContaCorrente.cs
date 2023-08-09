using System;

class ContaCorrente{
    private decimal saldo;
    private DateTime dataCriacao;
    private string nomeTitular;


    private decimal acumulador;
    private int contador;

    public ContaCorrente(decimal val, string nome){
        saldo = val;
        nomeTitular = nome;
        dataCriacao = DateTime.Now;
    }
    
    // --> (1) getters
    public decimal Saldo{
        get{ return saldo; }
    }

    public DateTime Data{
        get{ return dataCriacao; }
    }

    public string Titular{
        get{ return nomeTitular; }
    }

    public decimal SaldoMedio{
        get{ return (contador == 0)? 0 : acumulador/contador;}
    }

    //======================================================

    public void Depositar(decimal val){
        if(val >= 0){
            saldo = saldo + val;
            acumulador += saldo;
            contador++;
        }else{
            Console.WriteLine("Não é possível depositar um valor negativo");
        }
    }

    public void Sacar(decimal val){
        if(val <= saldo){
            saldo = saldo - val;
            acumulador += saldo;
            contador++;
        }else{
            Console.WriteLine("Saldo Insuficiente");
        }
    }

    //======================================================

    public string printSaldoMedio(){
        return " = Saldo médio da conta: " + SaldoMedio;
    }
    public string toString(){
        return " = Nome: " + nomeTitular + " | Saldo: R$" + saldo + " | Data de criação: " + dataCriacao;
    }
}