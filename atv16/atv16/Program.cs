// See https://aka.ms/new-console-template for more information
Console.Write("Digite um número inteiro: ");
string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numero))
{
    if (numero < 0)
    {
        Console.WriteLine("Fatorial de número negativo não existe.");
    }
    else
    {
        long fatorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine($"{numero}! = {fatorial}");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
}
