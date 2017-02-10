using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PopTickets.Banco;
using PopTickets.Models;
using System.Data;
using System.Collections;
using Models;

namespace WebApplication5
{
    public partial class WebFormCarrinho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarPagina();
        }

        protected void CarregarPagina()
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

            Carrinho carro = new Carrinho();
            carro = (Carrinho)HttpContext.Current.Session["carrinho"];

            DataTable dt = new DataTable();
            ButtonColumn botao = new ButtonColumn();
            botao.CommandName = "removerIngresso";

            botao.Text = "Remover";

            dt.Columns.Add("Nome do Evento");
            dt.Columns.Add("Data");
            dt.Columns.Add("Nome do Setor");
            dt.Columns.Add("Valor");


            double soma = 0;

            ArrayList lista = new ArrayList();
            lista = carro.GetListaIngressos();
            for (int i = 0; i < lista.Count; i++)
            {
                dt.Rows.Add();
                Ingresso ingressomomento = new Ingresso();
                ingressomomento = (Ingresso)lista[i];
                dt.Rows[i]["Nome do Evento"] = ingressomomento.GetSetor().GetEvento().GetNome();
                dt.Rows[i]["Data"] = ingressomomento.GetSetor().GetEvento().GetDataevento();
                dt.Rows[i]["Nome do Setor"] = ingressomomento.GetSetor().GetNome();
                dt.Rows[i]["Valor"] = ingressomomento.GetSetor().GetValor();
                soma += ingressomomento.GetSetor().GetValor();
            }
            dgCarrinho.DataSource = dt;
            //dgCarrinho.Columns.Add(botao);
            dgCarrinho.DataBind();
            lblTotal.Text = "Total: R$ " + soma;
        }

        protected void btnFechar_Click(object sender, EventArgs e)
        {
            Carrinho carro = new Carrinho();
            carro = (Carrinho)HttpContext.Current.Session["carrinho"];
            ArrayList lista = new ArrayList();
            lista = carro.GetListaIngressos();
            String mododevenda = "";
            if (btnCredito.Checked) {
                mododevenda = "Cartão de Crédito";
            }
            else if (btnBoleto.Checked)
            {
                mododevenda = "Boleto Bancário";
            }
            else if (btnDebito.Checked)
            {
                mododevenda = "Cartão de Débito";
            }
            for (int cont = 0; cont < lista.Count; cont++)
            {
                Ingresso ingressomomento = new Ingresso();
                ingressomomento = (Ingresso)lista[cont];
                ingressomomento.SetMododevenda(mododevenda);
                ingressoDAO insert = new ingressoDAO();
                insert.CadastrarIngresso(ingressomomento);
            }
            carro.LimparListaIngressos();
            HttpContext.Current.Session["ingresso"] = carro;
            CarregarPagina();
            lblFechado.Text = "Compra realizada com sucesso!";
        }

        protected void dgCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dgCarrinho_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
           
        }

        protected void dgCarrinho_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Carrinho carro = new Carrinho();
            carro = (Carrinho)HttpContext.Current.Session["carrinho"];
            carro.GetListaIngressos().RemoveAt(dgCarrinho.SelectedIndex);
            CarregarPagina();
        }
    }
}