// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

int n1;
int n2;
Console.WriteLine("Digite a nota da primeira prova.");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da segunda prova.");
n2 = int.Parse(Console.ReadLine());
double media = (n1 + n2) / 2;
if (media >= 6)
{
	Console.WriteLine($"Sua média foi de {media}, você foi aprovado!");
}
else
{
	Console.WriteLine($"Sua média foi de {media}, você foi reprovado.");
}
