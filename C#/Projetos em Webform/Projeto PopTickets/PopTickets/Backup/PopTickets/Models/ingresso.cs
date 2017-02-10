using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Ingresso
    {
     
    private int codingresso;
    private int assento;
    private bool validade;
    private int mododevenda;
    private Setor setor = new Setor();
    private Usuario usuario = new Usuario();

    //gets e sets

    public int GetCodingresso() {
        return codingresso;
    }

    public void SetCodingresso(int codingresso) {
        this.codingresso = codingresso;
    }

    public int GetAssento() {
        return assento;
    }

    public void SetAssento(int assento) {
        this.assento = assento;
    }

    public bool isValidade() {
        return validade;
    }

    public void SetValidade(bool validade) {
        this.validade = validade;
    }

    public int GetMododevenda() {
        return mododevenda;
    }

    public void SetMododevenda(int mododevenda) {
        this.mododevenda = mododevenda;
    }

    public Setor GetSetor() {
        return setor;
    }

    public void SetSetor(Setor Setor) {
        this.setor = Setor;
    }

    public Usuario GetUsuario() {
        return usuario;
    }

    public void SetUsuario(Usuario usuario) {
        this.usuario = usuario;
    }

    }
}