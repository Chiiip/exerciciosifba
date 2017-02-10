using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace SiteNoticias
{
    public partial class formCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            AtualizarGrid();
        }

        CategoriaBD consulta = new CategoriaBD();

        protected void AtualizarGrid() {
            DataSet ds = consulta.TabelaCategoria();
            dgCategoria.DataSource = ds;
            dgCategoria.DataBind();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            CategoriaBD envio = new CategoriaBD();
            Categorias categoria = new Categorias();
            categoria.SetNomeCategoria(txtNome.Text);
            envio.IncluiCategoria(categoria);
            AtualizarGrid();
        }
    }
}