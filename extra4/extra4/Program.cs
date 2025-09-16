// See https://aka.ms/new-console-template for more information
int prod;
Console.WriteLine("Digite o valor do produto que deseja saber o valor promocional.");
prod = int.Parse(Console.ReadLine());
double valor = prod - (prod * 0.05);
Console.WriteLine($"O valor promocional é de R${valor}.");