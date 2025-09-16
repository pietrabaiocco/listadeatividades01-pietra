// See https://aka.ms/new-console-template for more information
int a, b, c;
double delta;
Console.WriteLine("Digite os valores de A, B e C da equação de segundo grau, respectivamente.");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
delta = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"O resultado de delta é {delta}");
