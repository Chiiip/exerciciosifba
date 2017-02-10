using Models;
using PopTickets.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PopTickets.Telas
{
    public partial class WebFormCadastroSetor : System.Web.UI.Page
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

            if (IsPostBack)
            {
                return;
            }

            CarregarDropdown();
            AtualizaSetor();

        }

            setorDAO cadastrosetor = new setorDAO();

        public void AtualizaSetor()
        {

            dgSetoresCadastrados.DataSource = cadastrosetor.ListarSetor();
            dgSetoresCadastrados.DataBind();
            txtValorSetor.Text = "";
            txtNomeSetor.Text = "";
            txtLotacaoSetor.Text = "";


        }


        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (btnCadastrar.Text == "Enviar")
            {
                setorDAO cadastrarsetor = new setorDAO();
                Setor setor = new Setor();
                setor.SetNome(txtNomeSetor.Text);
                setor.SetLotacao(Convert.ToInt32(txtLotacaoSetor.Text));
                setor.GetEvento().SetCodevento(Convert.ToInt32(ddlEventoSetor.SelectedValue.ToString()));
                setor.SetValor(Convert.ToDouble(txtValorSetor.Text));

                cadastrarsetor.CadastrarSetor(setor);
                AtualizaSetor();

            }
            else if (btnCadastrar.Text == "Atualizar")
            {

                setorDAO atualizarsetor = new setorDAO();
                string cof = dgSetoresCadastrados.SelectedItem.Cells[2].Text;
                Setor setor = new Setor();

                setor.SetCodSetor(Convert.ToInt32(cof));
                setor.SetNome(txtNomeSetor.Text);
                setor.SetLotacao(Convert.ToInt32(txtLotacaoSetor.Text));
                setor.GetEvento().SetCodevento(Convert.ToInt32(ddlEventoSetor.SelectedValue.ToString()));
                setor.SetValor(Convert.ToDouble(txtValorSetor.Text));

                atualizarsetor.AtualizarSetor(setor);
                AtualizaSetor();
                btnCadastrar.Text = "Enviar";

            }
        }

        protected void dgSetoresCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeSetor.Text = dgSetoresCadastrados.SelectedItem.Cells[3].Text;
            txtLotacaoSetor.Text = dgSetoresCadastrados.SelectedItem.Cells[4].Text;
            txtValorSetor.Text = dgSetoresCadastrados.SelectedItem.Cells[5].Text;

            btnCadastrar.Text = "Atualizar";

        }

        protected void dgSetoresCadastrados_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            setorDAO excluirsetor = new setorDAO();
            string cof = dgSetoresCadastrados.SelectedItem.Cells[2].Text;
            Setor setor = new Setor();

            setor.SetCodSetor(Convert.ToInt32(cof));
            setor.SetNome(txtNomeSetor.Text);
            setor.SetLotacao(Convert.ToInt32(txtLotacaoSetor.Text));
            setor.GetEvento().SetCodevento(Convert.ToInt32(ddlEventoSetor.SelectedValue.ToString()));
            setor.SetValor(Convert.ToDouble(txtValorSetor.Text));

            excluirsetor.DeletarSetor(setor);
            AtualizaSetor();
            btnCadastrar.Text = "Enviar";
        }

        protected void CarregarDropdown()
        {

            eventoDAO dropdownevento = new eventoDAO();

            DataTable dt = dropdownevento.ListaEvento();
            ddlEventoSetor.DataTextField = "Nome do Evento";
            ddlEventoSetor.DataValueField = "idevento";
            ddlEventoSetor.DataSource = dt;
            ddlEventoSetor.DataBind();

        }
    }
}