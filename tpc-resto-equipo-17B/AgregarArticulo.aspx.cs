using NEGOCIO;
using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_resto_equipo_17B
{
    public partial class AgregarArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                Response.Redirect("Error.aspx", false);
            }
            */

            if (!IsPostBack)
            {
                TipoArticuloNegocio negocio = new TipoArticuloNegocio();
                List<TipoArticulo> lista = negocio.listar();

                CBTipoArt.DataSource = lista;
                CBTipoArt.DataValueField = "Id";
                CBTipoArt.DataTextField = "Descripcion";
                CBTipoArt.DataBind();
            }
        }
    }
}