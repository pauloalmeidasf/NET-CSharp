using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto09_ModificadorStatic
{
    internal class Automovel
    {

        public static string? Fabricante { get; set; }

        public static string? Modelo { get; set; }

        public string ExibirDados()
        {

            return $"Fabricante: {Fabricante}\nModelo: {Modelo}";

        }

    }
}
