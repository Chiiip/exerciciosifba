using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PopTickets.Banco;
using System.Data;
using System.IO;

namespace WebApplication5
{
    public partial class WebFormResultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            eventoDAO pesquisa = new eventoDAO();
            
            dgResultado.DataSource = pesquisa.PesquisarEvento(Request.QueryString["nome"]);
            
            HyperLinkColumn linkColumn = new HyperLinkColumn();

            linkColumn.Text = "Comprar";
            linkColumn.DataTextFormatString = "{0}";
            linkColumn.DataNavigateUrlField = "idevento";
            linkColumn.DataNavigateUrlFormatString = "~/Telas/WebFormComprarIngresso.aspx?id={0}";

            dgResultado.Columns.Add(linkColumn);
            dgResultado.DataBind();

            /* 
            System.Data.DataSet resultado = new System.Data.DataSet();
            resultado = pesquisa.PesquisarEvento(WebFormHome.pesquisa);
            StringWriter stringWriter = new StringWriter();

             using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter))
             {

                 foreach (DataTable table in resultado.Tables)
                 {
                     foreach (DataRow row in table.Rows)
                     {
                         writer.AddAttribute(HtmlTextWriterAttribute.Class, "resultadoPesquisa");
                         writer.RenderBeginTag(HtmlTextWriterTag.Div);

                         writer.RenderBeginTag(HtmlTextWriterTag.A);
                         writer.Write(row[0].ToString());

                         writer.RenderEndTag(); // End #2
                         writer.RenderEndTag(); // End #1
                     }
                 }

                 stringWriter.ToString();

        }*/

        }
    }
}