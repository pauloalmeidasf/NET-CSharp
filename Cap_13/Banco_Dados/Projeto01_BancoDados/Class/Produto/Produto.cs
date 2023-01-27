using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Projeto01_BancoDados.Class.Produto
{

    [Table("TBProdutos")] //Annotations

    internal class Produto
    {

        public int Id { get; set; }

        public int IdCategoria { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public Produto()
        {

        }

        //Construtor - Cadastro Produto
        public Produto(int idCategoria, string descricao, double preco)
        {

            IdCategoria = idCategoria;
            Descricao = descricao;
            Preco = preco;

        }

        //Construtor - Atualização
        public Produto(int id, int idCategoria, string descricao, double preco) : this(idCategoria, descricao, preco)
        {

            Id = id;

        }

    }
}
