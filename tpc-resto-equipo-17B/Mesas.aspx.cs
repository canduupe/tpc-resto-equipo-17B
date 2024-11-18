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
    public partial class Mesas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                Response.Redirect("Error.aspx", false);
            }

            if (!IsPostBack)
            {
                List<Mesa> ListaMesa;
                MesaNegocio negocio = new MesaNegocio();
                ListaMesa = negocio.listar();   
                repeaterCards.DataSource = ListaMesa;
                repeaterCards.DataBind();
            }
        }

        protected void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMesa.aspx", false);
        }

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
            Response.Redirect("AsignarMesero.aspx?Id="  + valor, false);
        }
    }
}