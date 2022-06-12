//Atividade

string nomeDoUsuario;
int idadeDoUsuario;
int anoAtual = 2022;
int calcularAnoNascimento;


Console.WriteLine("Digite o seu nome:");
nomeDoUsuario = Console.ReadLine();

Console.WriteLine($"Olá, {nomeDoUsuario}! Seja bem-vindo ao cálculo do seu ano de nascimento!");

Console.WriteLine("Agora, digite a sua idade para prosseguirmos:");
idadeDoUsuario = Convert.ToInt32(Console.ReadLine()); //o ReadLine quando usado para capturar números você deve realizar a conversão.

calcularAnoNascimento = anoAtual
    - idadeDoUsuario; //cálculo básico para determinar ano de nascimento, subtraindo o ano atual pela idade do usuário.

Console.WriteLine($"Você nasceu em: {calcularAnoNascimento}");

//Desafio

var quilometrosPercorridosPeloVeiculo = 80000;
var milhasPorKm = 0.6214;
var milhasPercorridasPeloCarro = quilometrosPercorridosPeloVeiculo * milhasPorKm;
Console.WriteLine($"Seu veículo percorreu um total de {milhasPercorridasPeloCarro} milhas.");



