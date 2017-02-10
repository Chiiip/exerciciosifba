using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using Models;

namespace PopTickets.Banco
{
    public class eventoDAO
    {
        static string con;
        static MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;
        // construtor
        public eventoDAO()
        {
            con = ConfigurationManager.AppSettings			["PopTickets"];
        }


        public DataSet PesquisarEvento(String nomeevento)
        {
            String nomeeventoantigo = nomeevento;
            nomeevento = "%" + nomeeventoantigo + "%";
            conexao = new MySqlConnection(con);
            String sql = "select evento.idevento, evento.nome as nomeevento, dataevento, empresa.nome as nomeempresa, empresa.telefone, locale.nome as nomelocal from evento"
                         + " inner join empresa on empresa.idempresa = evento.empresa_idempresa"
                         + " inner join locale on locale.idlocal = evento.local_idlocal where evento.nome like ?pNomeevento";

            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("pNomeevento", nomeevento);
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


        public DataSet EventoShow()
        {
            conexao = new MySqlConnection(con);
            String sql = "select evento.idevento, evento.nome as nomeevento, dataevento, empresa.nome as nomeempresa, empresa.telefone, locale.nome as nomelocal from evento"
                         + " inner join empresa on empresa.idempresa = evento.empresa_idempresa"
                         + " inner join locale on locale.idlocal = evento.local_idlocal where evento.tipoevento = 'Show'";
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

        public DataSet EventoTeatro()
        {
            conexao = new MySqlConnection(con);
            String sql = "select evento.idevento, evento.nome as nomeevento, dataevento, empresa.nome as nomeempresa, empresa.telefone, locale.nome as nomelocal from evento"
                         + " inner join empresa on empresa.idempresa = evento.empresa_idempresa"
                         + " inner join locale on locale.idlocal = evento.local_idlocal where evento.tipoevento = 'Teatro'";

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

        public DataSet EventoCarnaval()
        {
            conexao = new MySqlConnection(con);
            String sql = "select evento.idevento, evento.nome as nomeevento, dataevento, empresa.nome as nomeempresa, empresa.telefone, locale.nome as nomelocal from evento"
                         + " inner join empresa on empresa.idempresa = evento.empresa_idempresa"
                         + " inner join locale on locale.idlocal = evento.local_idlocal where evento.tipoevento = 'Carnaval'";

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

        public DataSet EventosRecentes()
        {
            conexao = new MySqlConnection(con);
            String sql = "select evento.idevento, evento.nome as nomeevento, dataevento, empresa.nome as nomeempresa, empresa.telefone, locale.nome as nomelocal from evento"
                         + " inner join empresa on empresa.idempresa = evento.empresa_idempresa"
                         + " inner join locale on locale.idlocal = evento.local_idlocal ORDER BY idevento DESC LIMIT 3";

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


        public DataSet ExibirEvento(int idevento)
        {

            conexao = new MySqlConnection(con);
            String sql = "select evento.nome, dataevento from evento where evento.idevento = ?pIdevento";

            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("pIdevento", idevento);
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



        public DataSet ListarSetores(int idevento)
        {
            conexao = new MySqlConnection(con);
            String sql = "select idsetor as 'Código do Setor', nome as 'Nome do Setor', lotacao as 'Lotação Máxima', valor as 'Preço do Setor' from setor where evento_idevento = ?pIdevento";

            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("pIdevento", idevento);
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

        public int CadastrarEvento(Evento evento)
        {
            conexao = new MySqlConnection(con);
            String incluir = "insert into evento (nome, dataevento, empresa_idempresa, local_idlocal, tipoevento) values (?pNome, ?pDataevento, ?pEmpresa, ?pLocal, ?ptipo)";

            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pNome", evento.GetNome());
            comando.Parameters.AddWithValue("pDataevento", evento.GetDataevento());
            comando.Parameters.AddWithValue("pEmpresa", evento.GetEmpresa().GetIdEmpresa());
            comando.Parameters.AddWithValue("pLocal", evento.GetLocal().GetCodlocal());
            comando.Parameters.AddWithValue("pTipo", evento.GetTipoEvento());
            comando.Parameters.AddWithValue("pidEvento", evento.GetCodevento());
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

        public int DeletarEvento(Evento evento)
        {
            conexao = new MySqlConnection(con);
            String deletar = "delete from evento where idEvento = ?pidEvento";
            comando = new MySqlCommand(deletar, conexao);
            comando.Parameters.AddWithValue("pidEvento", evento.GetCodevento());
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

        public int AtualizaEvento(Evento evento)
        {
            String atualizar = "update evento set nome = ?pNome, dataevento = ?pDataevento, empresa_idempresa=?pEmpresa, local_idlocal = ?pLocal, tipoevento=?ptipo where idEvento = ?pidEvento";
            comando = new MySqlCommand(atualizar, conexao);
            comando.Parameters.AddWithValue("pNome", evento.GetNome());
            comando.Parameters.AddWithValue("pDataevento", evento.GetDataevento());
            comando.Parameters.AddWithValue("pEmpresa", evento.GetEmpresa().GetIdEmpresa());
            comando.Parameters.AddWithValue("pLocal", evento.GetLocal().GetCodlocal());
            comando.Parameters.AddWithValue("pTipo", evento.GetTipoEvento());
            comando.Parameters.AddWithValue("pidEvento", evento.GetCodevento());
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
            String sql = "select idevento, evento.nome as 'Nome do Evento', dataevento as 'Data do Evento', empresa.nome as 'Empresa Promotora', locale.nome as 'Local do evento', tipoevento as 'Tipo do Evento' from evento"
                    + " inner join empresa on empresa.idempresa = evento.empresa_idempresa"
                    + " inner join locale on locale.idlocal = evento.local_idlocal";

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


        public DataTable ListaEvento()
        {
            conexao = new MySqlConnection(con);
            String sql = "select idevento, evento.nome as 'Nome do Evento', dataevento as 'Data do Evento', empresa.nome as 'Empresa Promotora', locale.nome as 'Local do evento', tipoevento as 'Tipo do Evento' from evento"
                    + " inner join empresa on empresa.idempresa = evento.empresa_idempresa"
                    + " inner join locale on locale.idlocal = evento.local_idlocal ";

            comando = new MySqlCommand(sql, conexao);
            try
            {
                da = new MySqlDataAdapter(comando);
                DataTable ds = new DataTable();
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
