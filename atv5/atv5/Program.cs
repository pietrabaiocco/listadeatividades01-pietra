// See https://aka.ms/new-console-template for more information
int eleitores;
int n1;
int n2;
int n3;
Console.WriteLine("Digite a quantidade total de eleitores do seu município.");
eleitores = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade total de votos brancos do seu município.");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade total de votos nulos do seu município.");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade total de votos válidos do seu município.");
n3 = int.Parse(Console.ReadLine());
double brancos = ((double)n1 / eleitores) * 100;
double nulos = ((double)n2 / eleitores) * 100;
double validos = ((double)n3 / eleitores) * 100;
Console.WriteLine($"A quantidade de votos brancos equivale a {brancos}%. A quantidade de votos nulos equivale a {nulos}%. A quantidade de votos válidos equivale a {validos}%.");
