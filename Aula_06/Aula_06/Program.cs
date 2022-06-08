// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite seu nome:");
string nomeDoUsuario = Console.ReadLine();

Console.WriteLine("Digite sua Idade:");
int idadeDoUsuario = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ano atual:");
int anoAtual = int.Parse(Console.ReadLine());

int anoDeNascimento = anoAtual - idadeDoUsuario;

Console.WriteLine($"Olá,{nomeDoUsuario} você nasceu em {anoDeNascimento}.");