using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_resto_equipo_17B
{
    public partial class PedidosXMesa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MesaNegocio negoio = new MesaNegocio();
            dgvPxMesa.DataSource = negoio.listar();
            dgvPxMesa.DataBind();

           



        }

        protected void dgvPxMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvPxMesa.SelectedDataKey.Value.ToString();
            Response.Redirect("PxMesa.aspx?IdMesa=" + id, false);
        }
    }
}