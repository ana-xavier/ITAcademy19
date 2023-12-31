﻿// Exercicios para conhecer a linguagem

//=============================================================
// -> Trabalhando com tipos-valor fundamentais byte, int e long
// Trabalhando com byte
byte b;
b = byte.MaxValue;
Console.WriteLine("Valor maximo de byte: " + b);

// Trabalhando com int
int i;
i = int.MaxValue;
Console.WriteLine("Valor maximo de int: " + i);

// Trabalhando com long
long l;
l = long.MaxValue;
Console.WriteLine("Valor maximo de long: " + l);

//=============================================================
// -> Trabalhando com strings

string strPrimeira = "Alo";
string strSegunda = "Mundo";

string strTerceira = strPrimeira + strSegunda;
Console.WriteLine(strTerceira);

int cchTamanho = strTerceira.Length;

string strQuarta = "Tamanho = " + cchTamanho.ToString();
Console.WriteLine(strQuarta);

Console.WriteLine(strTerceira.Substring(0, 5));

//=============================================================
// -> Trabalhando com objetos do Framework

DateTime dt = new DateTime(2015, 04, 23);

string strQuinta = dt.ToString();
Console.WriteLine(strQuinta);

//=============================================================



