using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PopTickets.Banco;

namespace WebApplication5
{
    public partial class WebFormResultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            eventoDAO pesquisa = new eventoDAO();
            dgResultado.DataSource = pesquisa.PesquisarEvento(WebFormHome.pesquisa);
            dgResultado.DataBind();

        }
    }
}