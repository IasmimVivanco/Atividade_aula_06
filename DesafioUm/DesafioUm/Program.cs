using System;

Console.WriteLine("Digite o seu nome: ");
string nomeDoUsuario = Console.ReadLine();
Console.WriteLine("Digite a sua idade: ");
int idadeDoUsuario = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o ano atual: ");
int anoAtual = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Olá {nomeDoUsuario}, você nasceu em {anoAtual - idadeDoUsuario}");


//DESAFIO PROFESSOR
Console.WriteLine("Digite o número em km que deseja fazer a conversão para milhas: ");
double km = Convert.ToDouble(Console.ReadLine());
double conversaoMilha = 0.62d;
double milhas = km * conversaoMilha;

Console.WriteLine($"Seu veículo percorreu um total de {milhas} milhas");
