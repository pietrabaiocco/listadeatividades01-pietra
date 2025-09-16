// See https://aka.ms/new-console-template for more information
int real;
double dolar;
Console.WriteLine("Digite a quantidade de dinheiro em R$.");
real = int.Parse(Console.ReadLine());
dolar = real / 3.45;
Console.WriteLine($"Você tem US${dolar}.");