using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_resto_equipo_17B
{
    public partial class Meseros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.SessionActiva(Session["Usuario"]))
                Response.Redirect("Error.aspx", false);

            if (!Helper.EsGerente(Session["Usuario"]))
            {
                btnListar.Visible = false;
            }
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaMeseros.aspx", false);
        }

        protected void btnPedidos_Click(object sender, EventArgs e)
        {
            Response.Redirect("TomarPedido.aspx", false);
        }

        protected void btnMesasAsig_Click(object sender, EventArgs e)
        {
            Response.Redirect("MesasMeseros.aspx", false);
        }
    }
}