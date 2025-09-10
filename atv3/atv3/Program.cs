// See https://aka.ms/new-console-template for more information
int largura;
int altura;
int area;
Console.WriteLine("Digite o valor da largura do quadrilátero.");
largura = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da altura do quadrilátero.");
altura = int.Parse(Console.ReadLine());
area = largura * altura;
Console.WriteLine($"O valor da área do quadrilátero é de {area}.");