/*
 * Métodos
 * 
 * Definem as ações dos objetos
 * 
 * Quando um método não retornar um valor, ele deve ser declarado como VOID.
 * 
 * Se o método retornar um valor, este será para a rotina que fez a chamada do método. Para isso, o comando RETURN
 * deverá ser utilizado
 * 
 * modificador_acesso tipo NomeMetodo(parâmetros)
 * {
 * 
 *      intruções;
 *      return valor;
 * 
 * }
 * 
 */

//Método que retorna um inteiro (int)
using System.Net.NetworkInformation;

static int Multiplicar(int valor1, int valor2)
{

    int multiplicacao = valor1 * valor2;

    return multiplicacao;

}

//Método sem retorno
static void Mensagem()
{

    Console.WriteLine("Multiplicação entre 2 números");

    Console.WriteLine();

}

Mensagem();

int valor1 = 10;
int valor2 = 15;

int resultado = Multiplicar(valor1, valor2);

Console.WriteLine($"Multiplicação entre {valor1} e {valor2}: {resultado}");

Console.ReadKey();