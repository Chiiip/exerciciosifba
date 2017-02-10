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
    public class setorDAO
    {
        static string con;
        static MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;
        // construtor
        public setorDAO()
        {
            con = ConfigurationManager.AppSettings["PopTickets"];
        }


        public int CadastrarSetor(Setor setor)
        {
            conexao = new MySqlConnection(con);
            String incluir = "insert into setor (nome, lotacao, valor, evento_idevento) values (?pNome, ?pValor, ?pLotacao, ?pEvento)";

            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pNome", setor.GetNome());
            comando.Parameters.AddWithValue("pLotacao", setor.GetLotacao());
            comando.Parameters.AddWithValue("pValor", setor.GetValor());
            comando.Parameters.AddWithValue("pEvento", setor.GetEvento().GetCodevento());
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

        public int DeletarSetor(Setor setor)
        {
            conexao = new MySqlConnection(con);
            String deletar = "delete from setor where idSetor = ?pidSetor";
            comando = new MySqlCommand(deletar, conexao);
            comando.Parameters.AddWithValue("pidSetor", setor.GetCodSetor());
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


        public int AtualizarSetor(Setor setor)
        {//nome, lotacao, valor, evento_idevento, local_idlocal

            String atualizar = "update setor set nome = ?pNome, lotacao = ?pLotacao, valor = ?pValor, evento_idevento = ?pEvento where idSetor = ?pidSetor";
            comando = new MySqlCommand(atualizar, conexao);
            comando.Parameters.AddWithValue("pNome", setor.GetNome());
            comando.Parameters.AddWithValue("pLotacao", setor.GetLotacao());
            comando.Parameters.AddWithValue("pValor", setor.GetValor());
            comando.Parameters.AddWithValue("pEvento", setor.GetEvento().GetCodevento());
            comando.Parameters.AddWithValue("pidSetor", setor.GetCodSetor());
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

        public DataSet ListarSetor()
        {
            conexao = new MySqlConnection(con);
            String sql = "select idsetor, setor.nome as 'Nome do Setor', lotacao as 'Lotação do Setor', valor as 'Preço do Setor (R$)', evento.nome as 'Nome do Evento' from setor"
                        +" inner join evento on evento.idevento = setor.evento_idevento";

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