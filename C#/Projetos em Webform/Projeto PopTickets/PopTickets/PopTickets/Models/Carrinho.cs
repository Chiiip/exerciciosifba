using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopTickets.Models
{
    public class Carrinho
    {
        private ArrayList listaingressos = new ArrayList();

        public ArrayList GetListaIngressos()
        {
            return listaingressos;
        }

        public void LimparListaIngressos() {
            listaingressos.Clear();
        }

        public void adicionarIngresso(Ingresso ingresso)
        {
            listaingressos.Add(ingresso);
        }
    }
}