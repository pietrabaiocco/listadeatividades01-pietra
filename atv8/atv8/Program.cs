// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("Digite um número, exeto 0.");
num = int.Parse(Console.ReadLine());
if (num > 0)
	Console.WriteLine($"O número {num} é positivo.");
else if (num == 0)
	Console.WriteLine($"O número {num} é inválido.");
else
	Console.WriteLine($"O número {num} é negativo.");