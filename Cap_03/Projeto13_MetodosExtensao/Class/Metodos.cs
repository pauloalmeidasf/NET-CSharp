using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto13_MetodosExtensao.Class
{

    /*
     * Ao se utilizar um método de extensão, é possível ampliar uma classe ou um estrutura já existente com métodos
     * estáticos adicionais
     * 
     * 
     */

    internal static class Metodos
    {

        public static string RetirarAcentos(this string texto)
        {

            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {

                texto = texto.Replace(comAcentos[i], semAcentos[i]);

            }

            return texto;

        }

    }
}
