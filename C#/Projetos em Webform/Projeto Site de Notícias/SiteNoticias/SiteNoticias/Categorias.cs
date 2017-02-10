using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteNoticias
{
    public class Categorias
    {
        private String nomeCategoria;

        public String GetNomeCategoria() {
            return nomeCategoria;
        }

        public void SetNomeCategoria(string nomecategoria){
        this.nomeCategoria = nomecategoria;
        }

        public Categorias() { }

        public Categorias(string nomecategoria){
        this.nomeCategoria = nomecategoria;
        }
    


    }
}