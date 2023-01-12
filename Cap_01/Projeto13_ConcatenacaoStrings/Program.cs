using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto13_ConcatenacaoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "Julio ";
            string sobrenome = "Cesar";

            string nomeCompleto = string.Concat(nome, sobrenome);

            Console.WriteLine($"Nome completo: {nomeCompleto}");

            string x = "50";
            string y = "60";

            Console.WriteLine();

            Console.WriteLine($"Valor de x: {x}");
            Console.WriteLine($"Valor de y: {y}");

            Console.WriteLine($"Valor de x + y = {x + y}");

            Console.ReadKey();

        }
    }
}
