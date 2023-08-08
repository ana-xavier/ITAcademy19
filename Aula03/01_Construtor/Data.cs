public class Data{
    private int dia,mes,ano;

    // --> Membros estáticos
    private static string informacao = "Um objeto que armazena um dado";
    public static void imprimeAlgo(){
        Console.WriteLine(informacao);
    }

    // --> Método construtor
    public Data(int _dia, int _mes, int _ano){
        ano = _ano;
        mes = _mes;
        dia = _dia;
    }

    // --> Sobrecarga do construtor (overloading)
        //     - Reduz código
    public Data(): this(1,1,1){}

    // --> Trabalha encima do construtor do objeto
    public Data(Data d): this(d.dia, d.mes, d.ano){}

    public Data(int _dia, int _mes): this(_dia, _mes, 2023){}

    /*
    <!!> Aqui há |conflito| de construtor,
               não há sobrecarga.

    public Data(int _ano, int _mes, int _dia){
        ano = _ano;
        mes = _mes;
        dia = _dia;
    }
    */

    /*
     Aqui não há |conflito| de construtor,
            há sobrecarga.
     --> Não é aceito que o construtor tenha a mesma quantidade de parametros
         e que esses parametros tenham o mesmo tipo. Há a necessidade de que
         os parametros tenham |tipos| diferentes
    */

    public Data(int _dia, int _mes, string _ano){
        ano = Int32.Parse(_ano);
        mes = _mes;
        dia = _dia;
    }

    // --> Implementação de sobrecarga de operações, o método precisa ser estático
    //     - "operator" devide a operação que será realizada
    //     - operação binária, com dois elementos
    public static Data operator+ (Data d1, Data d2){
        int d = (d1.dia > d2.dia)? d1.dia : d2.dia;
        int m = (d1.mes > d2.mes)? d1.mes : d2.mes;
        int a = (d1.ano > d2.ano)? d1.ano : d2.ano;
        // ^ funciona exatamente como if/else

        return new Data(d,m,a);
    }

    public static Data operator+ (Data dt, int valor){
        return new Data(dt.dia+valor, dt.mes, dt.ano);
    }
    
    public void print(){
        Console.WriteLine("dia " + dia + " / mês " + mes + " / ano " + ano);
    }
}