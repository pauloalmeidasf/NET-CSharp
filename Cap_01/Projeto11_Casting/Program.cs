using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto11_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Type Casting Implícito - Conversão de tipo AUTOMÁTICO
             * 
             * Converte um TIPO MENOR para um TIPO MAIOR
             * 
             */

            int temperatura = 7;

            double temperaturaAtualizada = temperatura; // cast implícito (automático)

            /*
             * Type Casting Explícito - Conversão de tipo MANUAL
             * 
             * Converte um TIPO MAIOR para um TIPO MENOR
             * 
             */

            double valorNotaFiscal = 150.75;

            //O valorNotaFiscalAtualizada será 150
            int valorNotaFiscalAtualizada = (int)valorNotaFiscal; //cast explícito (manual)

            /*
             * Métodos para CONVERSÃO EXPLÍCITA
             * 
             */

            int numeroInteiro = 50;
            double numeroDecimal = 0.15;
            bool valorLogico = false;

            Console.WriteLine($"Converte int em string: {Convert.ToString(numeroInteiro)}");
            Console.WriteLine($"Converte int em double: {Convert.ToDouble(numeroInteiro)}");
            Console.WriteLine($"Converte double em int: {Convert.ToInt32(numeroDecimal)}");
            Console.WriteLine($"Converte bool em string: {Convert.ToString(valorLogico)}");
            Console.WriteLine($"Converte bool em int: {Convert.ToInt32(valorLogico)}");

            Console.ReadKey();

        }
    }
}
