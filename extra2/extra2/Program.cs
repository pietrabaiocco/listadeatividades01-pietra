// See https://aka.ms/new-console-template for more information
int largura, altura;
Console.WriteLine("Digite a largura da parede a ser pintada.");
largura = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura da parede a ser pintada.");
altura = int.Parse(Console.ReadLine());
double area = largura * altura;
double tinta = area / 2;
Console.WriteLine($"Você precisará de {tinta} latas de 2l de tinta para pintar {area}m² de parede.");