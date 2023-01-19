using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Heranca.Class
{

    /*
     * Herança
     * 
     * Por meio da herança, uma classe herda os atributos e métodos de outra classe
     * 
     * A classe que herda as características se chama classe filha ou subclasse ou classe derivada
     * 
     * A classe que fornece as características se chama classe mãe ou superclasse ou classe base
     * 
     */

    //Superclasse
    internal class Funcionario
    {

        public string? Nome { get; set; }

        public string? Cargo { get; set; }

        public decimal Salario { get; set; }

        

    }
}
