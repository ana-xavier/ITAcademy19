// Exercicios sobre classes

namespace _Exercicios;
class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta = new ContaCorrente(400, "Ana Xavier");
        Console.WriteLine(conta.toString());

        // --> (3) Realizar série de operações e imprimir o saldo no final

        ContaCorrente conta1 = new ContaCorrente(600, "Amiguinho");
        conta1.Depositar(400);
        conta1.Sacar(790);
        conta1.Sacar(100);
        conta1.Depositar(290);
        conta1.Sacar(50);
        conta1.Depositar(80);

        Console.WriteLine(conta1.toString());
        Console.WriteLine(conta1.printSaldoMedio());
    }
}