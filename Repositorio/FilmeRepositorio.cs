using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repositorio
{
    public class FilmeRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65970\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";
        /*
         * Método que irá retornar os dados dos filmes
         * filmes(List<Filme>) da tabela de filmes
         */
        public List<Filme> ObterTodos()
        {
            
            //Cria a conexão com o banco de dados e abre.
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaConexao;
            connection.Open();

            /*Cria o comando para ser executado no bd
            * e diz para este comando qual é a conexão que está
            * aberta
            */

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM filmes";

            /*
            * Cria uma tabela em memória para poder obter
            * os dados que são retornados do bd
            */
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            // Cria uma lista para adicionar os filmes do bd
            List<Filme> filmes = new List<Filme>();

            // Percorre todos os registros lidos do bd
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                // Cria um objeto com as informações obtidas do bd
                Filme filme = new Filme();
                filme.Id = Convert.ToInt32(row["id"]);
                filme.Nome = row["nome"].ToString();
                filme.Avaliacao = Convert.ToDecimal(row["avaliacao"]);
                filme.Duracao = Convert.ToDateTime(row["duracao"]);
                filme.Curtiu = Convert.ToBoolean(row["curtiu"]);
                filme.Categoria = row["categoria"].ToString();
                filme.TemSequencia = Convert.ToBoolean(row["tem_sequencia"]);
                // Adiciona o objeto que foi criado a lista de filmes
                filmes.Add(filme);
            }
            // Fecha a conexão do bd
            connection.Close();
            // retorna a lista de filmes
            return filmes;
        }
    }
}
