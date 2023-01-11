using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto08_CoalescenciaNula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * O operador de COALESCENCIA NULA retornará o valor do operando da ESQUERDA se não for NULL
             * 
             * Caso contrário, ele retornará o valor da DIREITA
             * 
             */

            string nomeCurso = null;

            string avaliacao = nomeCurso ?? "Curso não informado.";

            Console.WriteLine($"Nome do Curso: {avaliacao}");

            Console.ReadKey();

        }
    }
}
