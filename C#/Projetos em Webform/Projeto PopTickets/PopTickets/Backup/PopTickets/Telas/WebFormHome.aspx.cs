using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebFormHome : System.Web.UI.Page
    {
        public static String pesquisa = "NADAAAAAAA";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            pesquisa = txtPesquisa.Text;
            Response.Redirect("WebFormResultado.aspx");  
        }
    }
}