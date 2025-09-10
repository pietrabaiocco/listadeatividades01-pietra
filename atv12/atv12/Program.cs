// See https://aka.ms/new-console-template for more information
int v1;
int v2;
Console.WriteLine("Digite um número.");
v1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número diferente.");
v2 = int.Parse(Console.ReadLine());
if (v1 > v2)
{
	Console.WriteLine($"O maior número é {v1}.");
}
else
{
	Console.WriteLine($"O maior número é {v2}.");
}
