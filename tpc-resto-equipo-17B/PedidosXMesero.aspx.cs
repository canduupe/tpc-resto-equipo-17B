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
    public partial class PedidosXMesero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Mesero> lista;
            MeseroNegocio negocio = new MeseroNegocio();

            lista = negocio.listar();
            dgvPxM.DataSource = lista;
            dgvPxM.DataBind();

        }

        protected void dgvPxM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Id = dgvPxM.SelectedDataKey.Value.ToString();
            Response.Redirect("PxM?IdMes=" + Id, false);

        }
    }
}