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


        public int CadastrarIngresso(Ingresso ingresso)
        {
            conexao = new MySqlConnection(con);
            String incluir = "insert into ingresso (assento, mododevenda, setor_idsetor, usuario_idusuario) values (?pAssento, ?pMododevenda, ?pSetoridsetor, ?pUsuarioidusuario)";

            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pAssento", ingresso.GetAssento());
            comando.Parameters.AddWithValue("pMododevenda", ingresso.GetMododevenda());
            comando.Parameters.AddWithValue("pSetoridsetor", ingresso.GetSetor().GetCodSetor());
            comando.Parameters.AddWithValue("pUsuarioidusuario", ingresso.GetUsuario().GetIdUsuario());

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

        public DataSet ListarIngressosUsuario(Usuario usuario)
        {
            conexao = new MySqlConnection(con);
            String sql = "select idingresso, setor.nome as 'Nome do Setor', evento.nome as 'Nome do Evento', assento as 'Número do assento', mododevenda as 'Modo de venda' from ingresso"
                        +" inner join setor on setor.idSetor = ingresso.setor_idsetor"
                        +" inner join evento on setor.evento_idevento = evento.idevento"
                        +" where usuario_idusuario = ?pIdusuario";

            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("pIdusuario", usuario.GetIdUsuario());
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