using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using PopTickets.Banco;


namespace PopTickets.Telas
{
    public partial class WebFormCadastroEmpresa : System.Web.UI.Page
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
            AtualizaEmpresa();
        }
        empresaDAO empresaDAO = new empresaDAO();


        public void AtualizaEmpresa()
        {

            dgEmpresasCadastradas.DataSource = empresaDAO.ListarEmpresa();
            dgEmpresasCadastradas.DataBind();


        }

        protected void btnCadastrarEmpresa_Click(object sender, EventArgs e)
        {


            empresaDAO cadastroempresa = new empresaDAO();


            if (btnCadastrarEmpresa.Text == "Enviar")

            {

                empresaDAO cadastrarempresa = new empresaDAO();
                Empresa empresa = new Empresa();
                empresa.SetCNPJ(txtCNPJ.Text);
                empresa.SetNome(txtNomeEmpresa.Text);
                empresa.SetTelefone(txtTelefone.Text);
                empresa.SetEndereco(txtEnderecoEmpresa.Text);

                cadastrarempresa.CadastrarEmpresa(empresa);
                AtualizaEmpresa();
                txtCNPJ.Text = "";
                txtNomeEmpresa.Text = "";
                txtEnderecoEmpresa.Text = "";
                txtTelefone.Text = "";
            }

            else if (btnCadastrarEmpresa.Text == "Atualizar")
            {

                empresaDAO atualizarempresa = new empresaDAO();
                string cof = dgEmpresasCadastradas.SelectedItem.Cells[2].Text;
                Empresa empresa = new Empresa(Convert.ToInt32(cof), txtCNPJ.Text, txtNomeEmpresa.Text, txtTelefone.Text, txtEnderecoEmpresa.Text);
                atualizarempresa.AtualizarEmpresa(empresa);
                AtualizaEmpresa();
                txtCNPJ.Text = "";
                txtNomeEmpresa.Text = "";
                txtEnderecoEmpresa.Text = "";
                txtTelefone.Text = "";
                btnCadastrarEmpresa.Text = "Enviar";

            }




        }

        protected void dgEmpresasCadastradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeEmpresa.Text = dgEmpresasCadastradas.SelectedItem.Cells[4].Text;
            txtCNPJ.Text = dgEmpresasCadastradas.SelectedItem.Cells[3].Text;
            txtTelefone.Text = dgEmpresasCadastradas.SelectedItem.Cells[5].Text;
            txtEnderecoEmpresa.Text = dgEmpresasCadastradas.SelectedItem.Cells[6].Text;
            btnCadastrarEmpresa.Text = "Atualizar";
        }

        protected void dgEmpresasCadastradas_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            empresaDAO excluirempresa = new empresaDAO();
            string cof = dgEmpresasCadastradas.SelectedItem.Cells[2].Text;
            Empresa empresa = new Empresa(Convert.ToInt32(cof), txtCNPJ.Text, txtNomeEmpresa.Text, txtTelefone.Text, txtEnderecoEmpresa.Text);
            excluirempresa.DeletarEmpresa(empresa);
            AtualizaEmpresa();
            btnCadastrarEmpresa.Text = "Enviar";
            txtCNPJ.Text = "";
            txtNomeEmpresa.Text = "";
            txtEnderecoEmpresa.Text = "";
            txtTelefone.Text = "";

        }


    }
}
