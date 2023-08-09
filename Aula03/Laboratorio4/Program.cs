namespace _Laboratorio4;
class Program
{
    static void Main(string[] args)
    {
        /* --> (1) Manipulando o saldo
        ContaCorrente minhaConta = new ContaCorrente();
        minhaConta.Depositar(100);
        minhaConta.Sacar(50);
        */

        /* --> (2)
        ContaCorrente minhaConta = new ContaCorrente();
        Console.WriteLine(" = Saldo: " + minhaConta.Saldo);
        minhaConta.Depositar(100);
        Console.WriteLine(" = Saldo novo: " + minhaConta.Saldo);
        minhaConta.Sacar(50);
        Console.WriteLine(" = Saldo novo: " + minhaConta.Saldo);
        */

        // --> (3)
        ContaCorrente minhaConta = new ContaCorrente(340);
        Console.WriteLine(" = Saldo: " + minhaConta.Saldo);
        minhaConta.Depositar(100);
        Console.WriteLine(" = Saldo novo: " + minhaConta.Saldo);
        minhaConta.Sacar(50);
        Console.WriteLine(" = Saldo novo: " + minhaConta.Saldo);
        
    }
}