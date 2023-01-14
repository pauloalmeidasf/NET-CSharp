using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_PropriedadesExpressoes.Class
{
    internal class Funcionario
    {

        /*
         * Propriedades Expressões
         * 
         */

        private string _nome;

        public string Nome {

            get => _nome;
            set => _nome = value;

        }

        private decimal _salario;

        public decimal Salario
        {

            get => _salario;
            set => _salario = value;

        }

        public decimal Irpf
        {

            get => Salario * 0.10m;

        }

    }
}
