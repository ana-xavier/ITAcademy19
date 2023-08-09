using System;

class ContaCorrente{
    private decimal saldo;

    public ContaCorrente(decimal val){
        saldo = val;
    }
    
    public decimal Saldo{
        get{ return saldo; }
    }
    public void Depositar(decimal val){
        saldo = saldo + val;
    }

    public void Sacar(decimal val){
        saldo = saldo - val;
    }
}