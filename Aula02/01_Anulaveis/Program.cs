﻿// Exemplos dados em aula - 07/08/2023
namespace _01_Anulaveis;

class Program
{
    static void Main(string[] args)
    {
        // -> Exemplo
        string first = "xuxu";
        string second = string.Empty;
        int third = 3;
        // O uso do ponto de interrogação após o tipo, torna-o anulável
        DateTime? data = null;

        Console.WriteLine("Valores das variáveis");
        Console.WriteLine("  O valor de first é: " + first);
        Console.WriteLine("  O valor de second é: " + second);
        Console.WriteLine("  O valor de third é: " + third);
        Console.WriteLine("  O valor de data é: " + data);

        //================================================================
        // -> Utilizando valores anuláveis em inteiros
        int? v1 = 0;
        int? v2 = null;
        int? v3 = default;
        int? v4 = new();

        Console.WriteLine("Valores das variáveis v*");
        Console.WriteLine("  O valor de v1 é: " + v1);
        Console.WriteLine("  O valor de v2 é: " + v2);
        Console.WriteLine("  O valor de v3 é: " + v3);
        Console.WriteLine("  O valor de v4 é: " + v4);

        //================================================================
        // -> Utilizando valores anuláveis em DateTime
        DateTime? d1 = null;
        DateTime? d2 = default;
        DateTime? d3 = new();

        Console.WriteLine("Valores das variáveis d*");
        Console.WriteLine("  O valor de d1 é: " + d1);
        Console.WriteLine("  O valor de d2 é: " + d2);
        Console.WriteLine("  O valor de d3 é: " + d3);
        //================================================================
    }
}