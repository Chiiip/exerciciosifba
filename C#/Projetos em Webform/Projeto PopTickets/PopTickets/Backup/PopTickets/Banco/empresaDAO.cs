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
    public class EmpresaBD
    {

	static string con;
        static MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;
        // construtor
        public EmpresaBD()
        {
            con = ConfigurationManager.AppSettings			["PopTickets"];
        }	

	
	public int CadastrarEmpresa(Empresa empresa){
	conexao = new MySqlConnection(con);
	String incluir = "insert into empresa (CNPJ, nome, telefone, endereco) values (?pCNPJ, ?pNome, ?pTelefone, ?pEndereco)";

comando = new MySqlCommand(incluir,conexao);
            comando.Parameters.AddWithValue("pCNPJ",empresa.GetCNPJ());
comando = new MySqlCommand(incluir,conexao);
            comando.Parameters.AddWithValue("pNome",empresa.GetNome());
comando = new MySqlCommand(incluir,conexao);
            comando.Parameters.AddWithValue("pTelefone",empresa.GetTelefone());
comando = new MySqlCommand(incluir,conexao);
            comando.Parameters.AddWithValue("pEndereco",empresa.GetEndereco());
            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery();
                return quant;
            }
            catch(MySqlException e)
            {
                throw e;
            }

    }

    public int DeletarEmpresa(Empresa empresa){
    conexao = new MySqlConnection(con);
    String deletar = "delete from empresa where CNPJ = ?pCNPJ";
    comando = new MySqlCommand(deletar,conexao);
            comando.Parameters.AddWithValue("pCNPJ",empresa.GetCNPJ());
            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery();
                return quant;
            }
            catch(MySqlException e)
            {
                throw e;
            }

    }

    public int AtualizarEmpresa(Empresa empresa){

    String atualizar = "update empresa set nome = ?pNome, telefone = ?pTelefone, endereco = ?pEndereco where CNPJ = ?pCNPJ";
    comando = new MySqlCommand(atualizar, conexao);
    comando.Parameters.AddWithValue("pNome", empresa.GetNome());
    comando.Parameters.AddWithValue("pTelefone", empresa.GetTelefone());
    comando.Parameters.AddWithValue("pEndereco", empresa.GetEndereco());
    comando.Parameters.AddWithValue("pCNPJ", empresa.GetCNPJ());

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


    public DataSet ListarEmpresa(){
conexao = new MySqlConnection(con);
    String sql = "select * from empresa";

comando = new MySqlCommand(sql,conexao);
            try
            {
                da = new MySqlDataAdapter(comando);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch(MySqlException e)
            {
                throw e;
            }
    }

}
}