// Desafio 1
string nomeDoUsuario;
int idadeDoUsuario;
int anoAtual = 2022;
int anoNascimento;

Console.WriteLine("Digite o seu nome:");
nomeDoUsuario = Console.ReadLine();

Console.WriteLine("Digite a sua idade:");
idadeDoUsuario = Convert.ToInt32(Console.ReadLine());

anoNascimento = anoAtual - idadeDoUsuario;

Console.WriteLine("Olá " + nomeDoUsuario + ", você nasceu em: " + anoNascimento);

// Desafio 2
int quilometrosPercorridosPeloVeiculo;
const float milhas = 0.62f;
float totalMilhas;

Console.WriteLine("Digite o seu quilometros Percorridos:");
quilometrosPercorridosPeloVeiculo = Convert.ToInt32(Console.ReadLine());


totalMilhas = quilometrosPercorridosPeloVeiculo * milhas;

Console.WriteLine("Seu veículo percorreu um total de " + totalMilhas  + " milhas.");
