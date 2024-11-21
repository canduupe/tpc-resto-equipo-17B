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
    public partial class Orden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                OrdenNegocio objListar = new OrdenNegocio();

                DgvOrden.DataSource = objListar.Listar();
                DgvOrden.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("ERROR", ex.ToString());
            }

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("TomarPedido.aspx", false);
        }

        protected void BtnCerrarPedido_Click(object sender, EventArgs e)
        {

        }

        protected void DgvOrden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}