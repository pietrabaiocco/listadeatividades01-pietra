// See https://aka.ms/new-console-template for more information
int ano;
int mes;
int dia;
int idade;
Console.WriteLine("Quantos anos você tem?");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos meses se passaram do seu aniversário?");
mes = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos dias se passaram da data do seu aniversário?");
dia = int.Parse(Console.ReadLine());
idade = (ano * 365) + (mes * 30) + dia;
Console.WriteLine($"Sua idade expressa em dias equivale a {idade} dias.");
