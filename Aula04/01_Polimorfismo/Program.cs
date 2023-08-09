// --> Exemplos simples de herança
Pessoa p = new Pessoa("Gui", 20);
Console.WriteLine(p);

Funcionario f = new Funcionario(1500.40M);
Console.WriteLine(f);

f = new("Ana Xavier", 21, 2000);
Console.WriteLine(f);

//============================================================================================================
// --> Polimorfismo em ação B)
Pessoa paux;
paux = p;
Console.WriteLine("| ========================= |");
Console.WriteLine(" = Pessoa");
Console.WriteLine(paux);
Console.WriteLine(" = Qual o seu humor? " + paux.humor());
Console.WriteLine(" = Paux é Pessoa? " + (paux is Pessoa));
Console.WriteLine(" = Paux é Funcionario? " + (paux is Funcionario));

/* 
<!!> O uso do operador "is" verifica o tipo do objeto, retornando true ou false.
*/

paux = f;
Console.WriteLine("| ========================= |");
Console.WriteLine("  = Funcionario");
Console.WriteLine(paux);
Console.WriteLine(" = Qual o seu humor? " + paux.humor());
Console.WriteLine(" = Paux é Pessoa? " + (paux is Pessoa));
Console.WriteLine(" = Paux é Funcionario? " + (paux is Funcionario));
if(paux is Funcionario){
    Console.WriteLine(" = Está satisfeito com o salário? " + (paux as Funcionario).satisfacaoSalarial());
}

//============================================================================================================
object oaux;
oaux = p;
Console.WriteLine("| ========================= |");
Console.WriteLine("  = oPessoa");
Console.WriteLine(oaux);
Console.WriteLine(" = Qual o seu humor? " + (oaux as Pessoa).humor());

/* 
<!!> O uso do operador "as" converte explicitamente o objeto para uma
    referência ou anulável.
    --> Caso não for possível essa conversão, então retorna null
*/

oaux = f;
Console.WriteLine("| ========================= |");
Console.WriteLine("  = oFuncionario");
Console.WriteLine(oaux);
Console.WriteLine(" = Qual o seu humor? " + (oaux as Pessoa).humor());
Console.WriteLine(" = Qual o seu humor? " + (oaux as Funcionario).humor());
