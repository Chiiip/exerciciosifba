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

    private int CNPJ;
    private String nome;
    private String telefone;
    private String endereco;

    //gets e sets

    public void SetCNPJ (int CNPJ){
        this.CNPJ = CNPJ;
    }

    public int GetCNPJ(){
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