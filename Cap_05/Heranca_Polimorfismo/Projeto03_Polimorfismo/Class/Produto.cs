using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_Polimorfismo.Class
{

    /*
     * Polimorfismo
     * 
     * Permite um objeto se comportar de diferentes maneiras
     * 
     * Ocorre quando classes derivadas de uma única classe base são capazes de invocar métodos, com MESMA ASSINATURA,
     * que comportam-se de forma diferente
     * 
     * NÃO CONFUNDIR Polimorfismo (Sobrescrita) com Sobrecarga
     * 
     * Para permitir que um método seja SOBRESCRITO, deve-se usar a palavra-chave VIRTUAL
     * 
     */

    //Superclasse
    internal class Produto
    {

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public virtual string ExibirDados()
        {

            return $"Nome: {Nome}\nPreço: {Preco:c}";

        }

    }
}
