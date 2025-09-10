// See https://aka.ms/new-console-template for more information
int a = 10;
int b = 20;
int aux;
Console.WriteLine($"A variável 'A' armazena o valor {a}, enquanto a variável 'B' armazena o valor de {b}.");
aux = a;
a = b;
b = aux;
Console.WriteLine($"A variável 'A' armazena o valor {a}, enquanto a variável 'B' armazena o valor de {b}.");