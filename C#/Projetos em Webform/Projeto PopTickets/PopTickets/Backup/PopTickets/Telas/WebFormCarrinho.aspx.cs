using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PopTickets.Banco;

namespace WebApplication5
{
    public partial class WebFormCarrinho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ingressoDAO ingressinho = new ingressoDAO();
            dgCarrinho.DataSource = ingressinho.ListarEvento();
            dgCarrinho.DataBind();
        }
    }
}