// See https://aka.ms/new-console-template for more information
int v1, v2, v3;
Console.WriteLine("Digite o primeiro número.");
v1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número.");
v2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro número.");
v3 = int.Parse(Console.ReadLine());
int menor, meio, maior;
if (v1 <= v2 && v1 <= v3)
{
	menor = v1;
	if (v2 <= v3)
	{
		meio = v2;
		maior = v3;
	}
	else
	{
		meio = v3;
		maior = v2;
	}
}
else if (v2 <= v1 && v2 <= v3)
{
	menor = v2;
	if (v1 <= v2)
	{
		meio = v1;
		maior = v3;
	}
	else
	{
		meio = v3;
		maior = v1;
	}
}
else
{
	menor = v3;
	if (v3 <= v1 && v3 <= v2)
	{
		meio = v3;
		maior = v2;
	}
	else
	{
		meio = v2;
		maior = v3;
	}
}
Console.WriteLine($"A sequência crescente é: {menor}, {meio} e {maior}.");