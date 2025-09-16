// See https://aka.ms/new-console-template for more information
Console.WriteLine("Números entre 1000 e 2000 que deixam resto 5 ao serem divididos por 11:");
for (int numero = 1000; numero <= 2000; numero++)
{
    if (numero % 11 == 5)
    {
        Console.WriteLine(numero);
    }
}
