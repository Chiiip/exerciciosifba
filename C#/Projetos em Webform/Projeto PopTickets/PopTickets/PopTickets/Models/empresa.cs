using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Empresa
    {

    private int idEmpresa;
    private String CNPJ;
    private String nome;
    private String telefone;
    private String endereco;

        public Empresa(int idEmpresa, string CNPJ, string nome, string telefone, string endereco)
        {

            this.idEmpresa = idEmpresa;
            this.CNPJ = CNPJ;
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;

        }

        public Empresa()
        {

        }

        //gets e sets

        public void SetIdEmpresa (int idempresa){
        this.idEmpresa = idempresa;
    }

    public int GetIdEmpresa(){
        return idEmpresa;
    }

    public void SetCNPJ (String CNPJ){
        this.CNPJ = CNPJ;
    }

    public String GetCNPJ(){
        return CNPJ;
    }    

    public void SetNome (String nome){
        this.nome = nome;
    }

    public String GetNome(){
        return nome;
    }

    public void SetTelefone (String telefone){
        this.telefone = telefone;
    }

    public String GetTelefone(){
        return telefone;
    }

    public void SetEndereco (String endereco){
        this.endereco = endereco;
    }

    public String GetEndereco(){
        return endereco;
    }

    }
}