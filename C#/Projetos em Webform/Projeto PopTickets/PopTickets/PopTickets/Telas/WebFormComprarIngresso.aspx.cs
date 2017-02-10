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
    public partial class WebFormComprarIngresso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["logado"] == null)
            {
                Response.Redirect("~/Telas/WebFormLogin.aspx");
            }
            String id = Request.QueryString["id"];
            eventoDAO evento = new eventoDAO();
            dgIngresso.DataSource = evento.ListarSetores(Convert.ToInt32(id));
            dgIngresso.DataBind();
            DataSet result = evento.ExibirEvento(Convert.ToInt32(id));
            if (id != null)
            {
                lblNome.Text = result.Tables[0].Rows[0]["nome"].ToString();
            }
        }

        protected void dgCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNomeevento.Text ="Nome do Setor: " + dgIngresso.SelectedRow.Cells[2].Text;
            lblQuantidade.Text = "Insira aqui a quantidade que deseja comprar:";
            txtQuant.Visible = true;
            btnAdicionar.Visible = true;
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Carrinho carro = new Carrinho();
            carro = (Carrinho)HttpContext.Current.Session["carrinho"];
            for (int cont = 0; cont < Convert.ToInt32(txtQuant.Text); cont++)
            {
                Ingresso ingresso = new Ingresso();
                ingresso.GetSetor().SetCodSetor(Convert.ToInt32(dgIngresso.SelectedRow.Cells[1].Text));
                ingresso.GetSetor().SetValor(Convert.ToInt32(dgIngresso.SelectedRow.Cells[4].Text));
                ingresso.GetSetor().SetNome(dgIngresso.SelectedRow.Cells[2].Text);
                eventoDAO eventinho = new eventoDAO();
                DataSet result = eventinho.ExibirEvento(Convert.ToInt32(Request.QueryString["id"]));
                ingresso.GetSetor().GetEvento().SetNome(result.Tables[0].Rows[0]["nome"].ToString());
                ingresso.GetSetor().GetEvento().SetDataevento(Convert.ToDateTime(result.Tables[0].Rows[0]["dataevento"].ToString()));
                ingresso.SetAssento(0);
                ingresso.SetUsuario((Usuario) HttpContext.Current.Session["logado"]);
                carro.adicionarIngresso(ingresso);
            }
            Response.Redirect("~/Telas/WebFormCarrinho.aspx");
        }
    }
}