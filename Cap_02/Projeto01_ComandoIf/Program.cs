using System.Globalization;

/*
 * Quando utilizamos o comando if, apenas expressões com resultados booleanos (true ou false) podem ser avaliados
 * 
 */

int a = 20;
int b = 100;

//Exemplo 1

if (a < b)
{

    Console.WriteLine($"{a} é menor que {b}");

}

a = 30;
b = 10;

//Exemplo 2

if (a < b)
{

    Console.WriteLine($"{a} é menor que {b}");

}

a = 20;
b = 10;

//Exemplo 3

if (a < b)
{

    Console.WriteLine($"{a} é menor que {b}");

}
else
{

    Console.WriteLine($"{a} é maior que {b}");

}

//Exemplo 4

a = 20;
b = 20;

if (a < b)
{

    Console.WriteLine($"{a} é menor que {b}");

}
else if(a > b)
{

    Console.WriteLine($"{a} é maior que {b}");

}
else
{

    Console.WriteLine($"{a} é igual {b}");

}

//Exemplo 5

int d = 30;
int e = 30;

if(d != e)
{

    Console.WriteLine($"'d' e 'e' são diferentes");

}
else
{

    Console.WriteLine($"'d' e 'e' são iguais");

}

Console.ReadKey();