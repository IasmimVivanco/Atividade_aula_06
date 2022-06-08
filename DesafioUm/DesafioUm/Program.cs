using System;

Console.WriteLine("Digite o seu nome: ");
string nomeDoUsuario = Console.ReadLine();
Console.WriteLine("Digite a sua idade: ");
int idadeDoUsuario = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o ano atual: ");
int anoAtual = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Olá {nomeDoUsuario}, você nasceu em {anoAtual - idadeDoUsuario}");
