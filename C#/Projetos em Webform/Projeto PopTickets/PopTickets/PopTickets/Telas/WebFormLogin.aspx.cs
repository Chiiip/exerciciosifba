using Models;
using PopTickets.Banco;
using PopTickets.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopTickets.Telas
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["logado"] != null)
            {
                Response.Redirect("~/Telas/WebFormPerfil.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            usuarioDAO login = new usuarioDAO();
            Usuario usuario = new Usuario();
            usuario.SetEmail(txtEmail.Text);
            usuario.SetSenha(txtSenha.Text);
            DataSet data = login.LoginUsuario(usuario);
            if (data.Tables[0].Select("email is not null").Length != 0)
            {
                if (data.Tables[0].Rows[0]["email"].ToString() == usuario.GetEmail() && data.Tables[0].Rows[0]["senha"].ToString() == usuario.GetSenha())
                {
                    usuario.SetTipousuario(data.Tables[0].Rows[0]["tipousuario"].ToString());
                    usuario.SetIdUsuario(Convert.ToInt32(data.Tables[0].Rows[0]["idusuario"].ToString()));
                    usuario.SetNome(data.Tables[0].Rows[0]["nome"].ToString());
                    Session["logado"] = usuario;
                    Carrinho carrinho = new Carrinho();
                    Session["carrinho"] = carrinho;
                    Response.Redirect("~/Telas/WebFormPerfil.aspx");
                }
                else
                {
                    lblErro.Text = "Login ou senha incorretos!";
                }
            }
            else
            {
                lblErro.Text = "Login ou senha incorretos!";
            }
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Telas/WebFormCadastro.aspx");
        }
    }
}