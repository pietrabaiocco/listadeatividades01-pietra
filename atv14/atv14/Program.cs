// See https://aka.ms/new-console-template for more information
int num, contador;
Console.WriteLine("Digite um número maior que zero.");
num = int.Parse(Console.ReadLine());
contador = 0;
while (contador <= num)
{
    Console.WriteLine(contador);
    contador++;
}