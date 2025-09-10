// See https://aka.ms/new-console-template for more information
int quant;
double valor;
Console.WriteLine("--- MAÇÃS DO BOSQUE ---");
Console.WriteLine("Digite a quantidade de maçãs adquiridas.");
quant = int.Parse(Console.ReadLine());
if (quant < 12)
{
	valor = quant * 1.30;
	Console.WriteLine($"A compra de {quant} maçãs resultou em ${valor}.");
}
else
{
	valor = quant * 1;
	Console.WriteLine($"A compra de {quant} maçãs resultou em ${valor}.");
}