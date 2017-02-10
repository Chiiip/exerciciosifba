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
    private double valor;
    private Evento evento = new Evento();

        public Setor(int codSetor, string nome, Evento evento, int lotacao, double valor)
        {
            this.codSetor = codSetor;
            this.nome = nome;
            this.evento = evento;
            this.lotacao = lotacao;
            this.valor = valor;

        }

        public Setor()
        {

        }


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

    public double GetValor() {
        return valor;
    }

    public void SetValor(double valor) {
        this.valor = valor;
    }

    public Evento GetEvento() {
        return evento;
    }

    public void SetEvento(Evento evento) {
        this.evento = evento;
    }

    }
}