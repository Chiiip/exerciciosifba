using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteNoticias
{
    public class Noticias
    {
        private String titulo;
        private DateTime datanoticia;
        private int codigocategoria;
        private String noticia;

        //gets e sets

        public String GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public DateTime GetDataNoticia()
        {
            return datanoticia;
        }

        public void SetDataNoticia(DateTime datanoticia)
        {
            this.datanoticia = datanoticia;
        }

        public int GetCodigoCategoria()
        {
            return codigocategoria;
        }

        public void SetCodigoCategoria(int codigocategoria)
        {
            this.codigocategoria = codigocategoria;
        }

        public String GetNoticia()
        {
            return noticia;
        }

        public void SetNoticia(string noticia)
        {
            this.noticia = noticia;
        }


        //construtores
        public Noticias() { }

        public Noticias(string titulo, DateTime datanoticia, int codigocategoria, string noticia)
        {
            this.titulo = titulo;
            this.datanoticia = datanoticia;
            this.codigocategoria = codigocategoria;
            this.noticia = noticia;
        }



    }
}