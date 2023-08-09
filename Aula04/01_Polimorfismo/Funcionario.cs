class Funcionario: Pessoa{
    public decimal salario{get;}
    private const decimal SALARIO_MINIMO = 1300.25M;

    // --> Caso não seja informado as informações necessárias para Pessoa,
    //     então, é chamado o construtor padrão da classe pessoa
    public Funcionario(string nome, int idade, decimal vSalario)
        :base(nome, idade)
    {
        this.salario = vSalario;
    }

    // --> Quando foi instanciar um funcionario com apenas um parametro, chama
    //     o outro construtor de Funcionario, que referencia o construtor de Pessoa.
    public Funcionario(decimal vSalario):this("João Ninguém", -1, vSalario){}

    public string satisfacaoSalarial(){
        Random r = new Random();
        if(r.Next()%10 < 3)
            return "Insatisfeito";
        else
            return "Satrisfeito";
    }

    public override string? ToString(){
        string texto;
        // --> Compõe com o toString de Pessoa
        texto = base.ToString();
        texto += $"\n =  Salário:    R$ {this.salario}";
        return texto;
    }
}