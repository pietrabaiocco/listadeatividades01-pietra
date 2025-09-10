// See https://aka.ms/new-console-template for more information
double salario;
string nome;
double novo;
Console.WriteLine("Digite seu nome.");
nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}! Digite seu salário para calcular o reajuste.");
salario = double.Parse(Console.ReadLine());
novo = salario + (salario * 0.10);
Console.WriteLine($"Seu novo salário, com reajuste de 15%, é no valor de ${novo}.");