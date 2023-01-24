using System;
namespace Projeto01_Delegates
{

    /*
     * 
     * Delegates: fazem referências a funções ou operações
     * 
     */

    /*
     * Expressão Lambda
     * 
     * Sintaxe
     * 
     * (parâmetros) => resultado; Leia-se: uma lista de parâmetros produz o resultado esperado
     * 
     */

    internal class Program
    {

        public delegate double Calcular(double x, double y);

        public delegate void Mensagem();

        static void Main(string[] args)
        {

            Calcular multiplicacao = new Calcular((x, y) => x * y);

            double resultado = multiplicacao(10, 5);

            Console.WriteLine($"Resultado da multiplicação: {resultado}");

            Console.ReadKey();  

        }
    }
}
