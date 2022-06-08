
Console.WriteLine("Insira seu nome");
string nomeDeUsuario = Console.ReadLine(); 

Console.WriteLine("Insira sua idade");
int idadeDoUsuario = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o ano atual");
int anoAtual = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Olá {nomeDeUsuario}, você nasceu em {anoAtual - idadeDoUsuario}");

