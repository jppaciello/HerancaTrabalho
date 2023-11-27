// See https://aka.ms/new-console-template for more information
using HerançaTrabalho;
using System;

Roupa roupa = new Roupa();
var PrecoRoupa = roupa.GetPrecoCamisa();
Console.WriteLine($"O preço da camisa é {PrecoRoupa} reais");