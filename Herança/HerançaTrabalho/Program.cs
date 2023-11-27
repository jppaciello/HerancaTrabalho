// See https://aka.ms/new-console-template for more information
using HerançaTrabalho;
using System;

Roupa roupa = new Roupa();
var PrecoRoupa = roupa.GetPrecoCamisa();
var NomeRoupa = roupa._camisa;
Console.WriteLine($"O preço da {NomeRoupa} é {PrecoRoupa} reais");

Comida comida1 = new Comida();
var PrecoPizza = comida1.GetPrecoPizza();
var NomeComida = comida1._pizza;
Console.WriteLine($"O preço da {NomeComida} é {PrecoPizza} reais");

Comida comida2 = new Comida();
var PrecoFruta = comida2.GetPrecoFruta();
var NomeFruta = comida2._fruta;
Console.WriteLine($"O preço da {NomeFruta} é {PrecoFruta}");