using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PopTickets.Banco;
using Models;
using System.Data;

namespace PopTickets.Telas
{
    public partial class WebFormDados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (HttpContext.Current.Session["logado"] == null)
            {
                Response.Redirect("~/Telas/WebFormLogin.aspx");
            }

            if (IsPostBack) return;

            

            Usuario user = new Usuario();
            user = (Usuario)HttpContext.Current.Session["logado"];
            // PEGAR OS DADOS DAQUELE MÉTODO PERFIL, E VERIFICAR SE ELE NÃO ESTÁ TENDO NENHUM ERRO, E SETAR OS TEXTBOXES
            

            usuarioDAO pesquisa = new usuarioDAO();
            DataSet ds = pesquisa.PerfilUsuario(user);

           // nome, senha, email, idusuario, datanascimento, CPF, endereco;
            txtNome.Text = ds.Tables[0].Rows[0]["nome"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            txtData.Text = ds.Tables[0].Rows[0]["datadenascimento"].ToString();
            txtCPF.Text = ds.Tables[0].Rows[0]["CPF"].ToString();
            txtEndereco.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtConfirma.Text == txtSenha.Text)
            {
                usuarioDAO usuarioinserir = new usuarioDAO();
                Usuario usuario = new Usuario();
                usuario = (Usuario) HttpContext.Current.Session["logado"];
                usuario.SetCPF(txtCPF.Text);
                usuario.SetDatadenascimento(Convert.ToDateTime(txtData.Text));
                usuario.SetEmail(txtEmail.Text);
                usuario.SetEndereco(txtEndereco.Text);
                usuario.SetNome(txtNome.Text);
                usuario.SetSenha(txtSenha.Text);

                

                int valor = usuarioinserir.AtualizarUsuario(usuario);
                if (valor == 1)
                {
                    Response.Redirect("~/Telas/WebFormPerfil.aspx");
                }
                else
                {
                    lblErro.Text = "A edição não foi possível de ser realizada!";
                }
            }
            else
            {
                lblErro.Text = "A senha e a confirmação não estão iguais!";
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Telas/WebFormPerfil.aspx");
        }


    }
}