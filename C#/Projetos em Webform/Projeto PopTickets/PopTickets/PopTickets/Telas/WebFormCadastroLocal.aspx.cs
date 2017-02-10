using Models;
using PopTickets.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PopTickets.Telas
{
    public partial class WebFormCadastroLocal : System.Web.UI.Page
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

            AtualizaLocal();
        }

        localDAO localDAO = new localDAO();


        public void AtualizaLocal()
        {

            dgLocaisCadastrados.DataSource = localDAO.ListarLocal();
            dgLocaisCadastrados.DataBind();


        }



        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            localDAO localDAO = new localDAO();


            if (btnCadastrar.Text == "Enviar")
            {

                localDAO cadastrarlocal = new localDAO();
                Local local = new Local();

                local.SetNome(txtNomeLocal.Text);
                local.SetEndereco(txtEnderecoLocal.Text);
                local.SetDescricao(txtDescricaoLocal.Text);
                local.SetLotacao(Convert.ToInt32(txtLotacao.Text));

                cadastrarlocal.CadastrarLocal(local);
                AtualizaLocal();
                txtDescricaoLocal.Text = "";
                txtEnderecoLocal.Text = "";
                txtLotacao.Text = "";
                txtNomeLocal.Text = "";
                
            }

            else if (btnCadastrar.Text == "Atualizar")
            {

                localDAO atualizarlocal = new localDAO();
                string cof = dgLocaisCadastrados.SelectedItem.Cells[2].Text;
                Local local = new Local(Convert.ToInt32(cof), txtNomeLocal.Text, txtEnderecoLocal.Text, txtDescricaoLocal.Text, Convert.ToInt32(txtLotacao.Text));
                atualizarlocal.AtualizarLocal(local);
                AtualizaLocal();
                txtDescricaoLocal.Text = "";
                txtEnderecoLocal.Text = "";
                txtLotacao.Text = "";
                txtNomeLocal.Text = "";
                btnCadastrar.Text = "Enviar";
            }

        }

        protected void dgLocaisCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeLocal.Text = dgLocaisCadastrados.SelectedItem.Cells[3].Text;
            txtEnderecoLocal.Text = dgLocaisCadastrados.SelectedItem.Cells[4].Text;
            txtDescricaoLocal.Text = dgLocaisCadastrados.SelectedItem.Cells[5].Text;
            txtLotacao.Text = dgLocaisCadastrados.SelectedItem.Cells[6].Text;
            btnCadastrar.Text = "Atualizar";
        }

        protected void dgLocaisCadastrados_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            localDAO excluirlocal = new localDAO();
            string cof = dgLocaisCadastrados.SelectedItem.Cells[2].Text;
            Local local = new Local(Convert.ToInt32(cof), txtNomeLocal.Text, txtEnderecoLocal.Text, txtDescricaoLocal.Text, Convert.ToInt32(txtLotacao.Text));
            excluirlocal.DeletarLocal(local);
            AtualizaLocal();
            txtDescricaoLocal.Text = "";
            txtEnderecoLocal.Text = "";
            txtLotacao.Text = "";
            txtNomeLocal.Text = "";
            btnCadastrar.Text = "Enviar";

        }
    }
}