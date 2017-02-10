using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace SiteNoticias
{
    public class NoticiasBD
    {
        static string conn;
        static MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;

        public NoticiasBD() {
            conn = ConfigurationManager.AppSettings["banquinho"];
            
        }

        public int IncluiNoticia(Noticias noticia)
        {
            conexao = new MySqlConnection(conn);
            string incluir = "insert into noticias(titulo, campodata, codigocategoria, noticia) values(?pTitulo, ?pCampoData, ?pCodigoCategoria, ?pNoticia)";
            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pTitulo", noticia.GetTitulo());
            comando.Parameters.AddWithValue("pCampoData", noticia.GetDataNoticia());
            comando.Parameters.AddWithValue("pCodigoCategoria", noticia.GetCodigoCategoria());
            comando.Parameters.AddWithValue("pNoticia", noticia.GetNoticia());
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

        public DataSet TabelaNoticia()
        {
            conexao = new MySqlConnection(conn);
            string sql = "select codigonoticia as Código, campodata as Data, titulo as Título, codigocategoria as 'Código da Categoria', noticia as 'Noticia' from noticias";
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

        private MySqlCommand MySqlCommand(string sql, MySqlConnection conexao)
        {
            throw new NotImplementedException();
        }
    }
}