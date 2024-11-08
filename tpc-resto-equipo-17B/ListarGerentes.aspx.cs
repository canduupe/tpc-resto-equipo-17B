using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_resto_equipo_17B
{
    public partial class ListarGerentes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                Response.Redirect("Error.aspx", false);
            }

            List<Gerente> listagerente;
            GerenteNegocio negocio = new GerenteNegocio();

            listagerente = negocio.listar();
            dgvGerentes.DataSource = listagerente;
            dgvGerentes.DataBind();
        }

        protected void dgvGerentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvGerentes.SelectedDataKey.Value.ToString();
            Response.Redirect("ABMGerentes.aspx?Id=" + id);
        }

        protected void btnAgregarGerente_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMGerentes.aspx", false);
        }
    }
}