using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace SiteNoticias
{
    public partial class CadastroNoticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            CarregarDataGrid();
            CarregarDropdown();

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            NoticiasBD envio = new NoticiasBD();
            Noticias noticia = new Noticias();
            noticia.SetTitulo(txtTitulo.Text);
            noticia.SetCodigoCategoria(Convert.ToInt32(listCategoria.SelectedValue.ToString()));
            noticia.SetDataNoticia(Convert.ToDateTime(txtData.Text));
            noticia.SetNoticia(txtNoticia.Text);
            envio.IncluiNoticia(noticia);
            CarregarDataGrid();
        }

        CategoriaBD consulta = new CategoriaBD();
        NoticiasBD consultanoticia = new NoticiasBD();

        protected void CarregarDropdown() {
            DataTable dt = consulta.ListaCategoria();
            listCategoria.DataTextField = "nomecategoria";
            listCategoria.DataValueField = "codigocategoria";
            listCategoria.DataSource = dt;
            listCategoria.DataBind();
        }

        protected void CarregarDataGrid() {
            DataSet ds = consultanoticia.TabelaNoticia();
            dgNoticias.DataSource = ds;
            dgNoticias.DataBind();
        }

        protected void calendario_SelectionChanged(object sender, EventArgs e)
        {
            txtData.Text = calendario.SelectedDate.ToString();
        }
    }
}