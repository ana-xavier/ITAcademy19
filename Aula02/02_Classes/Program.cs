namespace _02_Classes;
class Program
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        Console.WriteLine(c);

        // --> Acessando uma constante
        //Console.WriteLine(c.tipo);  -> Não é possível acessar uma constante atráves de uma instância
        Console.WriteLine(Cliente.tipo);
        
        //=================================================================================================
        // --> Acessando um método público da classe cliente
        c.saudacao(); 
        //Cliente.saudacao(); -> Só é possível acessar o método se tiver um objeto

        //=================================================================================================
        //  --> Acessando o método para manipulação do limite
        Console.WriteLine("O limite de crédito é: " + c.consultarLimite());
        Console.WriteLine("Adicionando R$50,00 de limite ");
        c.AumentarLimite(50);
        Console.WriteLine("O limite de crédito é: " + c.consultarLimite());

        //=================================================================================================
        // + Trabalhando com out e ref
        int a = 10;
        int b;

        /* <!!> 
        Este trecho não irá funcionar pois a variável B não foi inicializada
        
        Console.WriteLine("Valores antes da chamada de método");
        Console.WriteLine("O valor de a é: " + a);
        c.MetodoNormal(a, b);
        Console.WriteLine("Valores depois da chamada de método");
        Console.WriteLine("O valor de a é: " + a);
        Console.WriteLine("O valor de b é: " + b);
        */

        // --> Método com parametro out
        Console.WriteLine("Valores antes da chamada de método com out");
        Console.WriteLine("O valor de a é: " + a);
        c.MetodoOut(a, out b);
        Console.WriteLine("Valores depois da chamada de método com out");
        Console.WriteLine("O valor de a é: " + a);
        Console.WriteLine("O valor de b é: " + b);

        // --> Método com parametro ref
        Console.WriteLine("Valores antes da chamada de método com ref");
        Console.WriteLine("O valor de a é: " + a);
        c.MetodoRef(a, ref b);
        Console.WriteLine("Valores depois da chamada de método com ref");
        Console.WriteLine("O valor de a é: " + a);
        Console.WriteLine("O valor de b é: " + b);

        //=================================================================================================
        // --> Método com numero dinamico de parametros
        Console.WriteLine("Método com número dinamico de parametros");
        Console.WriteLine("  Uma lista de fato:");
        int [] minhaLista = new int[4] {1,2,3,4};
        c.MetodoParam(minhaLista);

        Console.WriteLine("  Chamada n parametros:");
        c.MetodoParam(5,6,7,8,9,10);

        //=================================================================================================
        // --> Manipulação de propriedade
        Console.WriteLine("Nome do cliente é: " + c.Nome);
        c.Nome = "Ana Xavier";
        Console.WriteLine("Nome do cliente é: " + c.Nome);
    }
}
