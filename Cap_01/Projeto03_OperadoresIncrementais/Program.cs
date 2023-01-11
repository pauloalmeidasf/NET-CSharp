using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_OperadoresIncrementais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Operadores Incrementais - Adiciona 1 unidade
             * 
             * Pré-incremental (++x)
             * Pós-incremental (x++)
             * 
             */

            Console.WriteLine("Pré-Incremental");
            Console.WriteLine(new string('-', 50));

            //pré-incremental
            int a = 2;

            Console.WriteLine("Valor de 'a': " + a);

            Console.WriteLine($"Valor de 'a' pré-incrementado: {++a}");

            Console.WriteLine(new string('-',50));

            Console.WriteLine("Pós-Incremental");
            Console.WriteLine(new string('-', 50));

            //pós-incremental
            int b = 3;

            Console.WriteLine($"Valor de 'b': {b}");

            Console.WriteLine($"Valor de 'b' pós-incrementado: {b++}");

            int c = b;

            Console.WriteLine($"Valor de 'c': {c}");

            Console.WriteLine(new string('-', 50));

            /*
             * Operadores Decrementais - Subtrai uma unidade
             * 
             * Pré-decrementais (--x)
             * Pós-decrementais (x--)
             * 
             */

            Console.WriteLine("Pré-Decremental");

            Console.WriteLine(new string('-',50));

            //pré-decremental
            int e = 4;

            Console.WriteLine($"Valor de 'e': {e}");

            Console.WriteLine($"Valor de 'e' pré-decrementado: {--e}");

            Console.WriteLine(new string('-',50));

            Console.WriteLine("Pós-Decremental");

            Console.WriteLine(new string('-',50));

            //pós-decremental
            int f = 5;

            Console.WriteLine($"Valor de 'f': {f}");

            Console.WriteLine($"Valor de 'f' pós-decrementado: {f--}");

            int g = f;

            Console.WriteLine($"Valor de 'g': {g}");

            Console.ReadKey();

        }
    }
}
