// Exercicios para conhecer a linguagem

//=======================================================================================
// -> 1. Além de tipos inteiros, C# também suporta float, double, e decimal 
//    o qual garante uma boa precisão para trabalhos com valores monetários. 

// Escreva algum código para testar variáveis destes novos tipos e mostrar o 
// resultado na tela do console.

// Trabalhando com float
float f;
f = float.MaxValue;
Console.WriteLine(" = Valor maximo de float: " + f);

// Trabalhando com double
double d;
d = double.MaxValue;
Console.WriteLine(" = Valor maximo de double: " + d);

// Trabalhando com decimal
decimal dc;
dc = decimal.MaxValue;
Console.WriteLine(" = Valor maximo de decimal: " + dc);

//=======================================================================================
// -> 2. Busque na documentação da biblioteca de classes do .Net novas operações 
// da classe String. Faça experiências e mostre os resultados na tela.

// --> É necessário utilizar aspas simples
char[] chars = {'w', 'o', 'r', 'd'};

string string1 = new string(chars);
Console.WriteLine(string1);

// --> String repete 20 vezes
string string2 = new string('c', 20);
Console.WriteLine(string2);

//=======================================================================================
// 3. Busque na documentação da biblioteca de classe do .Net novas operações 
// da classe DateTime. Faça experiências e mostre os resultados na tela.

DateTime data1 = DateTime.Now;
DateTime data2 = DateTime.UtcNow;
DateTime data3 = DateTime.Today;

Console.WriteLine(data1);
Console.WriteLine(data2);
Console.WriteLine(data3);

//=======================================================================================
//4. Converter dados em C# se dá de forma implícita ou explícita. Digite o 
//seguinte exemplo e note que a conversão para um tipo “maior” é feita de 
//forma implícita e, para um tipo “menor” de forma explícita. 

int i = 10;
float ft = 0;

ft = i; //conversão implícita, sem perda de dados.
System.Console.WriteLine(f);

ft = 0.5F;
i = (int) f; //conversão explícita, com perda de dados.
System.Console.WriteLine(i);

//=======================================================================================
// 5. Além das conversões realizadas pela linguagem C#, podemos utilizar um 
// mecanismo fornecido pelo próprio Framework, que é independente da linguagem 
// utilizada. Este mecanismo é a classe System.Convert. 
 
string stringInteiro = "123456789";
int valorStringInteiro = Convert.ToInt32(stringInteiro);
Console.WriteLine(valorStringInteiro);

Int64 valorInt64 = 123456789;
int valorInt = Convert.ToInt32(valorInt64);
Console.WriteLine(valorInt);

//string stringInteiroGrande = "999999999999999999999999999999999999999999999";
//int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);
// ^ Não é possível fazer a conversão pois irá estourar a capacidade máxima de Int32

//=======================================================================================
// 6.Escreva um programa para testar o método TryParse. 

string sInteiro = "123456789";
int vInteiro;
bool conversao1 = Int32.TryParse(sInteiro, out vInteiro);
Console.WriteLine(" = Conversão efetuada:" + conversao1 + " Valor: " + vInteiro);

string sInteiroGrande = "999999999999999999999999999999999999999999999";
int vInteiroGrande;
bool conversao2 = Int32.TryParse(sInteiroGrande, out vInteiroGrande);
Console.WriteLine(" = Conversão efetuada:" + conversao2 + " Valor: " + vInteiroGrande);

string sLetras = "abc";
double vLetras;
bool conversao3 = Double.TryParse(sLetras, out vLetras);
Console.WriteLine(" = Conversão efetuada:" + conversao3 + " Valor: " + vLetras);

//=======================================================================================
// 7. Devemos ter muito cuidado com os métodos de conversão de valores, pois 
// arredondamentos são executados de formas diferentes. Verifique o comportamento 
// do seguinte trecho de código.

double valorFracionado = 4.7;
int valorInteiro1 = (int) valorFracionado;
int valorInteiro2 = Convert.ToInt32(valorFracionado);

Console.WriteLine(" = Conversao explicita = " + valorInteiro1);
Console.WriteLine(" = Conversao metodo Convert = " + valorInteiro2);

//=======================================================================================
// 8. O comando de saída em console tem uma sintaxe específica para a exibição 
// de valores de várias variáveis. 

int x = 10;
double y = 3.4;

// --> String composto para formatar a saída. "{0}" e "{1}" são marcadores de posição
//     Os valores "x" e "y" serão substituídos nos correspondentes marcadores 
Console.WriteLine("{0} {1}",x,y);

// --> Interpolação de string para formatar a saída. Permite que seja inserido diretamente
//     valores de variáveis em uma string.
Console.WriteLine($"{x} {y}");

//=======================================================================================