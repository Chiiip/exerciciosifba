using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Evento
    {

 	private int codevento;
    private String nome;
    private DateTime dataevento;
    private Empresa empresa = new Empresa();
    private Local local = new Local();
    private String tipoevento;

        public Evento(int codevento, string nome, DateTime dataevento, Empresa empresa, Local local, string tipoevento)
        {
            this.codevento = codevento;
            this.nome = nome;
            this.dataevento = dataevento;
            this.empresa = empresa;
            this.local = local;
            this.tipoevento = tipoevento;

        }

        public Evento()
        {

        }

        //gets e sets

        public String GetTipoEvento()
        {
            return tipoevento;
        }

        public void SetTipoEvento(String tipoevento)
        {
            this.tipoevento = tipoevento;
        }

        public int GetCodevento() {
        return codevento;
    }

    public void SetCodevento(int codevento) {
        this.codevento = codevento;
    }

    public String GetNome() {
        return nome;
    }

    public void SetNome(String nome) {
        this.nome = nome;
    }

    public DateTime GetDataevento() {
        return dataevento;
    }

    public void SetDataevento(DateTime dataevento) {
        this.dataevento = dataevento;
    }

    public Empresa GetEmpresa() {
        return empresa;
    }

    public void SetEmpresa(Empresa empresa) {
        this.empresa = empresa;
    }

    public Local GetLocal() {
        return local;
    }

    public void SetLocal(Local local) {
        this.local = local;
    }
     
    }
}