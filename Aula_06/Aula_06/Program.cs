string nomeDoUsuario;
int idadeDoUsuario;
int anoAtual = 2022;
int anoNascimento;

Console.WriteLine("Digite o seu nome:");
nomeDoUsuario = Console.ReadLine();

Console.WriteLine("Digite a sua idade:");
idadeDoUsuario = Convert.ToInt32(Console.ReadLine());

anoNascimento =  anoAtual - idadeDoUsuario;

Console.WriteLine("Olá " + nomeDoUsuario + ", você nasceu em: " + anoNascimento);
