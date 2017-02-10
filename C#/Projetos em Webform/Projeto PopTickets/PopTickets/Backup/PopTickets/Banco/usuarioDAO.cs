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
    public class usuarioDAO
    {

        static string con;
        static MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;
        // construtor
        public usuarioDAO()
        {
            con = ConfigurationManager.AppSettings["PopTickets"];
        }


        public int CadastrarUsuario(Usuario usuario)
        {
            conexao = new MySqlConnection(con);
            String incluir = "insert into usuario (CPF, nome, email, senha, tipousuario, endereco) values (?pCpf, ?pNome, ?pEmail, ?pSenha, ?pTipousuario, ?pEndereco)";

            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pCpf", usuario.GetCPF());
            comando.Parameters.AddWithValue("pNome", usuario.GetNome());
            //comando = new MySqlCommand(incluir, conexao);
            //comando.Parameters.AddWithValue("pDatadenascimento", "01/03/2008 07:00:00");
            comando.Parameters.AddWithValue("pEmail", usuario.GetEmail());
            comando.Parameters.AddWithValue("pSenha", usuario.GetSenha());
            comando.Parameters.AddWithValue("pTipoUsuario", "Usuário");
            comando.Parameters.AddWithValue("pEndereco", usuario.GetEndereco());
            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery();
                return quant;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ErrorCode);
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


        public DataSet ListarEmpresa()
        {
            conexao = new MySqlConnection(con);
            String sql = "select * from usuario";

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