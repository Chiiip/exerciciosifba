using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using PopTickets.Banco;

namespace WebApplication5
{
    public partial class WebFormPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["logado"] == null)
            {
                Response.Redirect("~/Telas/WebFormLogin.aspx");
            }

            Usuario user = new Usuario();
            user = (Usuario)HttpContext.Current.Session["logado"];

            if (user.GetTipousuario() == "Administrador")
            {
                Response.Redirect("~/Telas/WebFormAdmin.aspx");
            }

            lblNome.Text = "Seja bem-vindo, " + user.GetNome() + "!";

            ingressoDAO ingresso = new ingressoDAO();
            dgIngresso.DataSource = ingresso.ListarIngressosUsuario(user);
            dgIngresso.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Abandon();
            Response.Redirect("~/Telas/WebFormLogin.aspx");
        }

        protected void btnCarrinho_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Telas/WebFormCarrinho.aspx");
        }

        protected void btnDados_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Telas/WebFormDados.aspx");
        }
    }
}