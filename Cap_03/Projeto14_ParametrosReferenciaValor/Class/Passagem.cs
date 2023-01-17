using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto14_ParametrosReferenciaValor.Class
{
    internal class Passagem
    {

        public static int Valor(int parametro)
        {

            return (parametro + 1);
      
        }

        public static void Incremento(ref int parametro)
        {

            parametro++;

        }

        public static void Referencia(Parametro objeto)
        {

            objeto.parametro = 25;

        }

    }
}
