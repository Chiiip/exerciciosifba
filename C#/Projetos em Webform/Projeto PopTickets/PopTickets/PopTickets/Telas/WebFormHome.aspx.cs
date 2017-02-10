using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PopTickets.Banco;

namespace WebApplication5
{
    public partial class WebFormHome : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            eventoDAO pesquisa = new eventoDAO();

            dgResultado.DataSource = pesquisa.EventosRecentes();
            HyperLinkColumn linkColumn = new HyperLinkColumn();

            linkColumn.Text = "Comprar";
            linkColumn.DataTextFormatString = "{0}";
            linkColumn.DataNavigateUrlField = "idevento";
            linkColumn.DataNavigateUrlFormatString = "~/Telas/WebFormComprarIngresso.aspx?id={0}";

            dgResultado.Columns.Add(linkColumn);
            dgResultado.DataBind();
        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            String pesquisa = txtPesquisa.Text;
            Response.Redirect("WebFormResultado.aspx?nome="+pesquisa);  
        }
    }
}