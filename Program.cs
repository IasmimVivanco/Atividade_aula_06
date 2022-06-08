//Mesa de trabalho

Console.WriteLine("Qual o nome do usuário?");
string? nomeDoUsuário = Console.ReadLine();
Console.WriteLine("Qual a idade?");
int idade;
bool validacao = int.TryParse(Console.ReadLine(), out idade);
Console.WriteLine("Qual o ano atual?");
int anoAtual;
bool validacao2 = int.TryParse(Console.ReadLine(), out anoAtual);
int anoNascimento = anoAtual - idade;

Console.WriteLine($"Olá {nomeDoUsuário}, você nasceu em {anoNascimento}.");



//DESAFIO
Console.WriteLine("\nDigite os kms percorridos:");
bool validacao3 = double.TryParse(Console.ReadLine(), out double quilometrosPercorridosPeloVeiculo);
double conversaoMilhas = 0.62;
double milhasPercorridosPeloVeiculo = quilometrosPercorridosPeloVeiculo * conversaoMilhas;
Console.WriteLine(validacao3 ? $"Seu veículo percorreu um total de {milhasPercorridosPeloVeiculo} milhas." : "Número de kms digitado inválido! Tente novamente!");