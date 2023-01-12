using System.Globalization;

/*
 * Quando utilizamos o comando if, apenas expressões com resultados booleanos (true ou false) podem ser avaliados
 * 
 */

Console.WriteLine("Exemplo 1");

int a = 20;
int b = 100;

//Como a condição é verdadeira, o texto será exibido
if (a < b)
{

    Console.WriteLine($"{a} é menor que {b}");

}

Console.WriteLine(new string('-', 40));

Console.WriteLine("Exemplo 2 - Bloco não executado");

int c = 20;
int d = 10;

//Como a condição é falsa, o texto NÃO será exibido
if (c < d)
{

    Console.WriteLine($"{c} é menor que {d}");

}

Console.WriteLine(new string('-', 40));

Console.WriteLine("Exemplo 3");

//Como a condição é falsa, será exibido o texto do else
if (c < d)
{

    Console.WriteLine($"{c} é menor que {d}");

}
else
{

    Console.WriteLine($"{c} é maior que {d}");

}

Console.WriteLine(new string('-', 40));

Console.WriteLine("Exemplo 4 - erro lógico");

int e = 20;
int f = 20;

//Como a condição é falsa, será exibido o texto do else
//que, nesse caso, será um erro

if (e < f)
{

    Console.WriteLine($"{e} é menor que {f}");

}
else
{

    Console.WriteLine($"{e} é maior que {f}");

}

Console.WriteLine(new string('-', 40));

Console.WriteLine("Exemplo 4");

//Para corrigir esta decisão
//precisaremos de mais uma comparação

if (e < f)
{

    Console.WriteLine($"{e} é menor que {f}");

}
else if (e > f)
{

    Console.WriteLine($"{e} é maior que {f}");

}
else
{

    Console.WriteLine($"{e} é igual a {f}");

}

Console.WriteLine(new string('-', 40));

//If aninhado
Console.WriteLine("Exemplo 5 - If aninhado");

int g = 60;
int h = 40;

if (g != h)
{

    if (g < h)
    {

        Console.WriteLine($"{g} é menor que {h}");

    }
    else
    {

        Console.WriteLine($"{g} é maior que {h}");

    }

}
else
{

    Console.WriteLine($"{g} é igual a {h}");

}

Console.ReadKey();