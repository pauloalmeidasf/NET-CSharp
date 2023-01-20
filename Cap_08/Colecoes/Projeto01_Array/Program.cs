/*
 *
 * Arrays
 * 
 * Possuem tamanho fixo
 * 
 * Não pode aumentar ou diminuir o tamanho após a sua declaração
 * 
 */

//Array unidimensional

//Declaração de um array unidimensional
int[] numeros1 = { 200, 50, 100, 200, 250, 450, 500, 200 };

//Substitui o valor do indice 7 (200) por 1000
numeros1[7] = 1000;

//Erro em tempo de execução.
//numeros1[8] = 5;

//Declaração de um array unidimensional (forma alternativa)
int[] numeros2 = new int[8];

//Atribuição de valores ao array unidimensional
numeros2[0] = 0;
numeros2[1] = 100;
numeros2[2] = 200;
numeros2[3] = 300;
numeros2[4] = 400;


for(int i = 0; i < numeros1.Length; i++)
{

    Console.Write($" {numeros1[i]} ");

}

Console.WriteLine();

for (int i = 0; i < numeros2.Length; i++)
{

    Console.Write($" {numeros2[i]} ");

}

Console.ReadKey();