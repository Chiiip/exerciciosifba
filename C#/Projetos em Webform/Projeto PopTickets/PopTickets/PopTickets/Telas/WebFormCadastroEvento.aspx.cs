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
    public partial class WebFormCadastroEvento : System.Web.UI.Page
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

            AtualizaEvento();
        }

        eventoDAO eventoDAO = new eventoDAO();

        public void AtualizaEvento()
        {

            dgEventosCadastrados.DataSource = eventoDAO.ListarEvento();
            dgEventosCadastrados.DataBind();
            txtDataEvento.Text = "";
            txtEventosCadastrados.Text = "";
            txtNomeEvento.Text = "";
            txtTipo.Text = "";
        }



        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            eventoDAO cadastroevento = new eventoDAO();


            if (btnCadastrar.Text == "Enviar")
            {
                eventoDAO cadastrarevento = new eventoDAO();
                Evento evento = new Evento();

                evento.SetDataevento(Convert.ToDateTime(txtDataEvento.Text));
                evento.SetNome(txtNomeEvento.Text);
                evento.SetTipoEvento(txtTipo.Text);
                evento.GetEmpresa().SetIdEmpresa(Convert.ToInt32(ddlEmpresaEvento.SelectedValue.ToString()));
                evento.GetLocal().SetCodlocal(Convert.ToInt32(ddlLocalEvento.SelectedValue.ToString()));
                cadastrarevento.CadastrarEvento(evento);
                AtualizaEvento();

            }
            else if (btnCadastrar.Text == "Atualizar")
            {

                eventoDAO atualizarevento = new eventoDAO();
                string cof = dgEventosCadastrados.SelectedItem.Cells[2].Text;
                Evento evento = new Evento();

                evento.SetCodevento(Convert.ToInt32(cof));
                evento.SetDataevento(Convert.ToDateTime(txtDataEvento.Text));
                evento.SetNome(txtNomeEvento.Text);
                evento.SetTipoEvento(txtTipo.Text);
                evento.GetEmpresa().SetIdEmpresa(Convert.ToInt32(ddlEmpresaEvento.SelectedValue.ToString()));
                evento.GetLocal().SetCodlocal(Convert.ToInt32(ddlLocalEvento.SelectedValue.ToString()));


                atualizarevento.AtualizaEvento(evento);
                AtualizaEvento();
                btnCadastrar.Text = "Enviar";

            }
        }



        protected void CarregarDropdown()
        { 

            empresaDAO dropdownempresa = new empresaDAO();

            DataTable dt = dropdownempresa.ListaEmpresa();
            ddlEmpresaEvento.DataTextField = "Nome da Empresa";
            ddlEmpresaEvento.DataValueField = "idempresa";
            ddlEmpresaEvento.DataSource = dt;
            ddlEmpresaEvento.DataBind();

            localDAO dropdownlocal = new localDAO();

            DataTable dt2 = dropdownlocal.ListaLocal();
            ddlLocalEvento.DataTextField = "Nome do Local";
            ddlLocalEvento.DataValueField = "idlocal";
            ddlLocalEvento.DataSource = dt2;
            ddlLocalEvento.DataBind(); 
        }

        protected void dgEventosCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeEvento.Text = dgEventosCadastrados.SelectedItem.Cells[3].Text;
            txtDataEvento.Text = dgEventosCadastrados.SelectedItem.Cells[4].Text;
            /*     txtEMPRESA.Text = dgSetoresCadastrados.SelectedItem.Cells[5].Text;
                   txtLOCAL.Text=dgSetoresCadastrados.SelectedItem.Cells[6].Text;
            */
            txtTipo.Text = dgEventosCadastrados.SelectedItem.Cells[7].Text;

            btnCadastrar.Text = "Atualizar";
        }

        protected void dgEventosCadastrados_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            eventoDAO excluirevento = new eventoDAO();
            string cof = dgEventosCadastrados.SelectedItem.Cells[2].Text;
            Evento evento = new Evento();
            evento.SetCodevento(Convert.ToInt32(cof));
            excluirevento.DeletarEvento(evento);
            AtualizaEvento();

            btnCadastrar.Text = "Enviar";
        }
    }
}