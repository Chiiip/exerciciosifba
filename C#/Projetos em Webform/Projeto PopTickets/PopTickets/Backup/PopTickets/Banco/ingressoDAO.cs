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
    public class ingressoDAO
    {

        static string con;
        static MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;
        // construtor
        public ingressoDAO()
        {
            con = ConfigurationManager.AppSettings["PopTickets"];
        }


        public int CadastrarUsuario(Usuario usuario)
        {
            conexao = new MySqlConnection(con);
            String incluir = "insert into usuario (CPF, nome, datadenascimento, email, senha, tipousuario, endereco) values (?pCPF, ?pNome, ?pDatadenascimento, ?pEmail, ?pSenha, ?pTipousuario, ?pEndereco)";

            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pCPF", usuario.GetCPF());
            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pNome", usuario.GetNome());
            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pDatadenascimento", usuario.GetDatadenascimento());
            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pEmail", usuario.GetEmail());
            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pSenha", usuario.GetSenha());
            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pTipoUsuario", 1);
            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pEndereco", usuario.GetEndereco());
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

        public int DeletarUsuario(Usuario usuario)
        {
            conexao = new MySqlConnection(con);
            String deletar = "delete from usuario where CPF = ?pCPF";
            comando = new MySqlCommand(deletar, conexao);
            comando.Parameters.AddWithValue("pCPF", usuario.GetCPF());
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

        public int AtualizarUsuario(Usuario usuario)
        {

            String atualizar = "update empresa set nome = ?pNome, telefone = ?pTelefone, endereco = ?pEndereco where CNPJ = ?pCNPJ";
            comando = new MySqlCommand(atualizar, conexao);
            comando.Parameters.AddWithValue("pNome", usuario.GetNome());
            comando.Parameters.AddWithValue("pTelefone", usuario.GetSenha());
            comando.Parameters.AddWithValue("pEndereco", usuario.GetEndereco());
            comando.Parameters.AddWithValue("pCNPJ", usuario.GetCPF());

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


        public DataSet ListarEvento()
        {
            conexao = new MySqlConnection(con);
            String sql = "select * from setor";

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
    }
}