using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PopTickets.Banco;

namespace WebApplication5
{
    public partial class WebFormCarnaval : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            eventoDAO pesquisa = new eventoDAO();
            dgResultado.DataSource = pesquisa.EventoCarnaval();

            HyperLinkColumn linkColumn = new HyperLinkColumn();

            linkColumn.Text = "Comprar";
            linkColumn.DataTextFormatString = "{0}";
            linkColumn.DataNavigateUrlField = "idevento";
            linkColumn.DataNavigateUrlFormatString = "~/Telas/WebFormComprarIngresso.aspx?id={0}";

            dgResultado.Columns.Add(linkColumn);
            dgResultado.DataBind();
        }
    }
}