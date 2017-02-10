using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace SiteNoticias
{
    public class CategoriaBD
    {
        static string conn;
        static MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;

        public CategoriaBD() {
            conn = ConfigurationManager.AppSettings["banquinho"];
            
        }

        public DataSet TabelaCategoria()
        {
            conexao = new MySqlConnection(conn);
            string sql = "select * from categorias";
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

        public DataTable ListaCategoria()
        {
            conexao = new MySqlConnection(conn);
            string sql = "select * from categorias";
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

        public int IncluiCategoria(Categorias categorias)
        {
            conexao = new MySqlConnection(conn);
            string incluir = "insert into categorias(nomecategoria) values(?pNomeCategoria)";
            comando = new MySqlCommand(incluir, conexao);
            comando.Parameters.AddWithValue("pNomeCategoria", categorias.GetNomeCategoria());

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

        private MySqlCommand MySqlCommand(string sql, MySqlConnection conexao)
        {
            throw new NotImplementedException();
        }

    }
}