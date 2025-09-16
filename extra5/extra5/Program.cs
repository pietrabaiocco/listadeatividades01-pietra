// See https://aka.ms/new-console-template for more information
int salario;
Console.WriteLine("Digite o valor do seu salário para calcular 15% de aumento.");
salario = int.Parse(Console.ReadLine());
double aumento = salario * 1.15;
Console.WriteLine($"Seu novo salário é no valor de R${aumento}");