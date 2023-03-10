using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06_OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Operadores Lógicos
             * 
             * O resultado será um valor booleano (true ou false)
             * 
             * && : E. O resultado SOMENTE será TRUE se ambas expressões também forem TRUE
             * 
             * || : OU. O resultado SOMENTE será FALSE se ambas expressões também forem FALSE
             * 
             * !  : NÃO. É um negação, ou seja, inverte a ordem lógica de uma expressão
             * 
             */

            int a = 30;
            int b = 40;
            int c = 50;
            int d = 60;

            Console.WriteLine("Operador OU (||)");

            Console.WriteLine(new string('-',50));

            Console.WriteLine($"a < b || c == 50: {a < b || c == 50}");
            Console.WriteLine($"a < b || c == d: {a < b || c == d}");
            Console.WriteLine($"a > b || c == 50: {a > b || c == 50}");
            Console.WriteLine($"a > b || c == d: {a > b || c == d}");

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Operador E (&&)");

            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"a < b && c == 50: {a < b && c == 50}");
            Console.WriteLine($"a < b && c == d: {a < b && c == d}");
            Console.WriteLine($"a > b && c == 50: {a > b && c == 50}");
            Console.WriteLine($"a > b && c == d: {a > b && c == d}");

            bool testeRealizado = true;

            Console.WriteLine($"Negação da variável testeRealizado: {!testeRealizado}");

            Console.ReadKey();

        }
    }
}
