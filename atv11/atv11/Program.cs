// See https://aka.ms/new-console-template for more information
int idade;
Console.WriteLine("Digite o ano que estamos.");
int anot = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano que você nasceu.");
int anon = int.Parse(Console.ReadLine());
idade = anot - anon;
if (idade < 16)
{
	Console.WriteLine($"Sua idade é {idade}, você não pode votar.");
}
else if ((idade >= 16 && idade <= 18 || idade >= 70))
{
	Console.WriteLine($"Sua idade é {idade}, seu voto é facultativo.");
}
else
{
	Console.WriteLine($"Sua idade é {idade}, seu voto é obrigatório.");
}