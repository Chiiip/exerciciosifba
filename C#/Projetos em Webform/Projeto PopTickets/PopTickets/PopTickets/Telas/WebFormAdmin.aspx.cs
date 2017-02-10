using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopTickets.Telas
{
    public partial class WebFormAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["logado"] == null)
            {
                Response.Redirect("~/Telas/WebFormLogin.aspx");
            }

            Usuario user = new Usuario();
            user = (Usuario)HttpContext.Current.Session["logado"];

            if (user.GetTipousuario() != "Administrador")
            {
                Response.Redirect("~/Telas/WebFormPerfil.aspx");
            }
        }

        protected void btnEmpresa_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Telas/WebFormCadastroEmpresa.aspx");
        }

        protected void btnEvento_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Telas/WebFormCadastroEvento.aspx");
        }

        protected void btnSetor_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Telas/WebFormCadastroSetor.aspx");
        }

        protected void btnLocal_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Telas/WebFormCadastroLocal.aspx");
        }
    }
}