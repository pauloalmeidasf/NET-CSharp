using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Opera de atribuição '='

            int a = 2; //a recebe o valor 2 ou valor 2 é atribuído a 'a'

            int b = a; //b recebe o valor a

            a = 5;

            //Exibe o valor de b
            Console.WriteLine("Valor de b: " + b);

            // Exibe o valor de a
            Console.WriteLine("Valor de a: " + a);

            //Operadores Aritméticos

            /*
             * + -> soma
             * - -> subtrai
             * * -> multiplicação
             * / -> divisão
             * % -> módulo (resto de uma divisão)
             * 
             */

            double c = 9;
            double d = 2;

            //Soma
            double soma = c + d;

            //Subtração
            double subtracao = c - d;

            //Multiplicação
            double multiplicacao = c * d;

            //Divisao
            double divisao = c / d;

            //Módulo
            double modulo = c % d;

            //Exibe a soma
            Console.WriteLine($"Soma entre {c} e {d}: {soma}");

            //Exibe a subtração
            Console.WriteLine($"Subtração entre {c} e {d}: {subtracao}");

            //Exibe a multiplicação
            Console.WriteLine($"Multiplicação entre {c} e {d}: {multiplicacao}");

            //Exibe a divisão
            Console.WriteLine($"Divisão entre {c} e {d}: {divisao}");

            //Exibe o módulo
            Console.WriteLine($"Módulo entre {c} e {d}: {modulo}");

            //Infinity

            int numerador = 5;
            double denominador = 0;

            Console.WriteLine("Resultado de 5.0/0.0: " + numerador/denominador);

            //NaN - Not a Number

            int numerador2 = 0;
            double denominador2 = 0;

            Console.WriteLine("Resultado de 0 / 0: " + numerador2/denominador2);

            Console.ReadKey();

        }
    }
}
