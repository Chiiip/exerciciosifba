using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Usuario
    {

    private int idUsuario;
    private String CPF;
    private String nome;
    private DateTime datadenascimento;
    private String email;
    private String senha;
    private String tipousuario;
    private String endereco;

    //gets e sets

    public void SetCPF(String CPF) {
        this.CPF = CPF;
    }

    public String GetCPF() {
        return CPF;
    }

    public void SetIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    public int GetIdUsuario() {
        return idUsuario;
    }

    public void SetNome (String nome){
        this.nome = nome;
    }

    public String GetNome() {
        return nome;
    }

    public void SetDatadenascimento(DateTime datadenascimento) {
        this.datadenascimento = datadenascimento;
    }

    public DateTime GetDatadenascimento() {
        return datadenascimento;
    }

    public void SetEmail(String email) {
        this.email = email;
    }

    public String GetEmail() {
        return email;
    }

    public String GetSenha() {
        return senha;
    }

    public void SetSenha(String senha) {
        this.senha = senha;
    }

    public String GetTipousuario() {
        return tipousuario;
    }

    public void SetTipousuario(String tipousuario) {
        this.tipousuario = tipousuario;
    }

    public void SetEndereco (String endereco){
        this.endereco = endereco;
    }

    public String GetEndereco(){
        return endereco;
    }


    }
}