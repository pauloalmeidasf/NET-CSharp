using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto01_BancoDados.Class.Banco;
using Dapper;

namespace Projeto01_BancoDados.Class.Categoria
{

    /*
     * 
     * Realizar instruções SQL com Dapper
     * 
     * Incluir Categoria
     * Lista Categoria
     * Atualizar Categoria
     * Remover Categoria
     * 
     */

    internal class CategoriaRepositorio
    {

        //Cadastrar Categoria
        public static void CadastrarCategoria(string categoria)
        {

            try
            {

                using (var conexao = new SqlConnection(DB.stringConexao))
                {

                    conexao.Execute("INSERT INTO TBCategorias(Descricao) VALUES(@Descricao)", new { Descricao = categoria });

                }

                Console.WriteLine();

                Console.WriteLine("Categoria cadastrada com sucesso.");

                Console.WriteLine(new string('-', 60));

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                
            }

        }

        //Listar Categorias
        public static void ListarCategorias()
        {

            Console.WriteLine("Lista das categorias: \n");

            try
            {

                using (var conexao = new SqlConnection(DB.stringConexao))
                {

                    IEnumerable<Categoria> categorias = conexao.Query<Categoria>("SELECT * FROM TBCategorias");

                    foreach (var item in categorias)
                    {

                        Console.WriteLine($"Id: {item.Id}. Descrição: {item.Descricao}");

                    }

                }

                Console.WriteLine();

                Console.WriteLine(new string('-', 60));

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                
            }

        }

        //Atualizar Categoria
        public static void AtualizarCategoria()
        {

            Console.Write("Informe o código da categoria: ");

            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o novo nome da categoria: ");

            string novoNomeCategoria = Console.ReadLine();

            try
            {

                using(var conexao = new SqlConnection(DB.stringConexao))
                {

                    conexao.Execute("UPDATE TBCategorias SET Descricao = @Descricao WHERE Id = @Id", 
                        new {Descricao = novoNomeCategoria, Id = codigo});

                }

                Console.WriteLine();

                Console.WriteLine("Categoria atualizada com sucesso.");

                Console.WriteLine(new string('-', 60));

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }

        }

        //Remover Categoria
        public static void RemoverCategoria()
        {

            Console.Write("Informe o código da categoria: ");

            int codigo = Convert.ToInt32(Console.ReadLine());

            try
            {

                using(var conexao = new SqlConnection(DB.stringConexao))
                {

                    conexao.Execute("DELETE FROM TBCategorias WHERE Id = @Id", new { Id = codigo });

                }

                Console.WriteLine();

                Console.WriteLine("Categoria removida com sucesso.");

                Console.WriteLine(new string('-',60));

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                
            }

        }

    }

}
