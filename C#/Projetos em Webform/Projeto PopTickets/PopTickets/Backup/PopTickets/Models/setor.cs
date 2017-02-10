using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Setor
    {
     
    private int codSetor;
    private String nome;
    private int lotacao;
    private float valor;
    private Evento evento;
    private Local local = new Local();

    //Gets e sets

    public int GetCodSetor() {
        return codSetor;
    }

    public void SetCodSetor(int codSetor) {
        this.codSetor = codSetor;
    }

    public String GetNome() {
        return nome;
    }

    public void SetNome(String nome) {
        this.nome = nome;
    }

    public int GetLotacao() {
        return lotacao;
    }

    public void SetLotacao(int lotacao) {
        this.lotacao = lotacao;
    }

    public float GetValor() {
        return valor;
    }

    public void SetValor(float valor) {
        this.valor = valor;
    }

    public Evento GetEvento() {
        return evento;
    }

    public void SetEvento(Evento evento) {
        this.evento = evento;
    }

    public Local GetLocal()
    {
        return local;
    }

    public void SetLocal(Local local)
    {
        this.local = local;
    }

    }
}