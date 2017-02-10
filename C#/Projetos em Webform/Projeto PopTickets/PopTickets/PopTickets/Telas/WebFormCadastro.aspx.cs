using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PopTickets.Banco;
using Models;

namespace PopTickets.Telas
{
    public partial class WebFormCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtConfirma.Text == txtSenha.Text)
            {
                usuarioDAO usuarioinserir = new usuarioDAO();
                Usuario usuario = new Usuario();
                usuario.SetCPF(txtCPF.Text);
                usuario.SetDatadenascimento(Convert.ToDateTime(txtData.Text));
                usuario.SetEmail(txtEmail.Text);
                usuario.SetEndereco(txtEndereco.Text);
                usuario.SetNome(txtNome.Text);
                usuario.SetSenha(txtSenha.Text);
                int valor = usuarioinserir.CadastrarUsuario(usuario);
                if (valor == 1)
                {
                    Response.Redirect("~/Telas/WebFormSucesso.aspx");
                }
                else
                {
                    lblErro.Text = "O cadastro não foi possível de ser efetuado!";
                }
            }
            else
            {
                lblErro.Text = "A senha e a confirmação não estão iguais!";
            }
        }
    }
}