// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("Digite um número.");
num = int.Parse(Console.ReadLine());
if (num > 10)
	Console.WriteLine("Esse número é maior que 10.");
else if (num < 10)
	Console.WriteLine("Esse número é menor que 10.");