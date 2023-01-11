using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto10_Formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Formatação de Caracteres
             * 
             * c: monetário
             * e: notação científica
             * f: fixo - ponto flutuante
             * g: geral
             * p: percentual
             * x: hexadecimal
             * 
             */

            string produto = "Notebook";

            decimal preco = 9650.90m;

            /*
             * Formatação Monetária
             * 
             */

            Console.WriteLine($"Produto: {produto}\nPreço: {preco:c2}");

            //Forma alternativa
            //Console.WriteLine("Produto: {0}\nPreço: {1}", produto, preco);

            Console.WriteLine();

            /* 
             * CultureInfo
             * 
             * Altera as configurações regionais da aplicação
             * 
             */

            decimal valorMonitor = 1210.50m;

            string valorMonitorPersonalizado = valorMonitor.ToString("c4", new CultureInfo("en-US"));

            Console.WriteLine($"Valor do monitor em dólar: {valorMonitorPersonalizado}");

            Console.WriteLine();

            /*
             * Formatação de Data e Hora
             * 
             */

            DateTime dataAtual = DateTime.Now;

            Console.WriteLine($"Data Atual: {dataAtual:d}");
            Console.WriteLine($"Data Atual Completa: {dataAtual:D}");
            Console.WriteLine($"Data e Hora Atuais: {dataAtual:g}");
            Console.WriteLine($"Ano Atual: {dataAtual:yyyy}");
            Console.WriteLine($"Mês Atual: {dataAtual:MM}");
            Console.WriteLine($"Dia Atual: {dataAtual:dd}");
            Console.WriteLine($"Hora Atual Completa: {dataAtual:T}");
            Console.WriteLine($"Hora Atual: {dataAtual:HH}");
            Console.WriteLine($"Minuto Atual: {dataAtual:mm}");
            Console.WriteLine($"Segundo Atual: {dataAtual:ss}");

            Console.WriteLine();

            /*
             * Formatação Hexadecimal
             * 
             */

            int massaObjeto = 500;

            Console.WriteLine($"Massa do objeto em hexadecimal: {massaObjeto:x}");

            Console.WriteLine();

            /*
             * Formatação Científica
             * 
             */

            double velocidadeLuz = 299792.4; //km/s

            Console.WriteLine($"Velocidade da luz em notação científica: {velocidadeLuz:e2}");

            Console.WriteLine();

            /*
             * Formatação Percentual
             * 
             */

            double descontoCompra = 0.055;

            Console.WriteLine($"Deconto na compra: {descontoCompra:p2}");

            Console.WriteLine();

            float massaParticula = 0.00987654321f;

            Console.WriteLine($"Massa da partícula: {massaParticula:c5}");

            Console.ReadKey();

        }
    }
}
