using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using Models;

namespace PopTickets.Banco
{
    public class localDAO
    {
        static string con;
        static MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;
        // construtor

        public localDAO()
        {
            con = ConfigurationManager.AppSettings["PopTickets"];
        }

        public int CadastrarLocal(Local local)
        { 
            conexao = new MySqlConnection(con);
            String incluir = "insert into locale (nome, endereco, descricao, lotacao) values (?pNome, ?pEndereco, ?pDescricao, ?pLotacao)";

            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pNome", local.GetNome());
            comando.Parameters.AddWithValue("pEndereco", local.GetEndereco());
            comando.Parameters.AddWithValue("pDescricao", local.GetDescricao());
            comando.Parameters.AddWithValue("pLotacao", local.GetLotacao());

            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery();
                return quant;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }

        public int DeletarLocal(Local local)
        {
            conexao = new MySqlConnection(con);
            String deletar = "delete from locale where idLocal = ?pidLocal";
            comando = new MySqlCommand(deletar, conexao);
            comando.Parameters.AddWithValue("pidLocal", local.GetCodlocal());
            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery();
                return quant;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }


        public int AtualizarLocal(Local local)
        {

            String atualizar = "update locale set nome = ?pNome, endereco = ?pEndereco, descricao = ?pDescricao, lotacao = ?pLotacao where idLocal = ?pidLocal";
            comando = new MySqlCommand(atualizar, conexao);
            comando.Parameters.AddWithValue("pNome", local.GetNome());
            comando.Parameters.AddWithValue("pEndereco", local.GetEndereco());
            comando.Parameters.AddWithValue("pDescricao", local.GetDescricao());
            comando.Parameters.AddWithValue("pLotacao", local.GetLotacao());
            comando.Parameters.AddWithValue("pidLocal", local.GetCodlocal());

            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery();
                return quant;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataSet ListarLocal()
        {
            conexao = new MySqlConnection(con);
            String sql = "select idlocal, nome as 'Nome do Local', endereco as 'Endereço do Local', descricao as 'Descrição', lotacao as 'Lotação Máxima' from locale";

            comando = new MySqlCommand(sql, conexao);
            try
            {
                da = new MySqlDataAdapter(comando);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable ListaLocal()
        {
            conexao = new MySqlConnection(con);
            string sql = "select idlocal, nome as 'Nome do Local', endereco as 'Endereço do Local', descricao as 'Descrição', lotacao as 'Lotação Máxima' from locale";
            comando = new MySqlCommand(sql, conexao);
            try
            {
                da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }


    }
}