/*
 *
 * Arrays
 * 
 * Possuem tamanho fixo
 * 
 * Não pode aumentar ou diminuir o tamanho após a sua declaração
 * 
 */

/*
 * 
 * Array unidimensional
 * 
 */

//Declaração de um array unidimensional
using System.Globalization;

int[] numeros1 = { 200, 50, 100, 200, 250, 450, 500, 200, 5 };

//Substitui o valor do indice 7 (200) por 1000
numeros1[7] = 1000;

//Erro em tempo de execução.
//numeros1[8] = 5;

Console.WriteLine("Valores do array numeros1");

Console.WriteLine();

for(int i = 0; i < numeros1.Length; i++)
{

    Console.Write($" {numeros1[i]} ");

}

//Declaração de um array unidimensional (forma alternativa)
int[] numeros2 = new int[8];

//Atribuição de valores ao array unidimensional
numeros2[0] = 0;
numeros2[1] = 100;
numeros2[2] = 200;
numeros2[3] = 300;
numeros2[4] = 400;

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Valores do array numeros2");

Console.WriteLine();

for(int j = 0; j < numeros2.Length; j++)
{

    Console.Write($" {numeros2[j]} ");

}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Sexto elemento do array numeros1: {numeros1[5]}");

Console.WriteLine();

/*
 * 
 * Array Bidimensional
 * 
 */

//Declaração de um array bidimensional
int[,] notas = { {17, 22, 12, 44, 34 }, { 23, 33, 12, 31, 45 }, {2, 45, 35, 1, 22 } };

int linhas = notas.GetLength(0);

int colunas = notas.GetLength(1);

Console.WriteLine();

Console.WriteLine("Valores do array bidimensional");

Console.WriteLine();

for(int i = 0; i < linhas; i++)
{

    for(int j = 0; j < colunas; j++)
    {

        Console.Write($" {notas[i, j]} ");

    }

    Console.WriteLine("\n");

}

Console.WriteLine();

Console.WriteLine($"Elemento linha 2 e coluna 3: {notas[1,2]}");

Console.ReadKey();