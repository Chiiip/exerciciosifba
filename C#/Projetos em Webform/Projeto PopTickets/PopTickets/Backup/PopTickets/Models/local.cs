using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Local
    {
     
    private int codlocal;
    private String nome;
    private String endereco;
    private String descricao;
    private int lotacao;


    //gets e sets

    public int GetCodlocal() {
        return codlocal;
    }

    public void SetCodlocal(int codlocal) {
        this.codlocal = codlocal;
    }

    public String GetNome() {
        return nome;
    }

    public void SetNome(String nome) {
        this.nome = nome;
    }

    public String GetEndereco() {
        return endereco;
    }

    public void SetEndereco(String endereco) {
        this.endereco = endereco;
    }

    public String GetDescricao() {
        return descricao;
    }

    public void SetDescricao(String descricao) {
        this.descricao = descricao;
    }

    public int GetLotacao() {
        return lotacao;
    }

    public void SetLotacao(int lotacao) {
        this.lotacao = lotacao;
    }

    }
}