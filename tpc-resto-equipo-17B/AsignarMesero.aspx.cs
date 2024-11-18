using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_resto_equipo_17B
{
    public partial class AsignarMesero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                Response.Redirect("Error.aspx", false);
            }

            List<Mesero> lista;
            MeseroNegocio negocio = new MeseroNegocio();

            lista = negocio.ListarActivos();
            dgvMeserosActivos.DataSource = lista;
            dgvMeserosActivos.DataBind();
        }

        protected void dgvMeserosActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Mesa mesa = new Mesa();
                mesa.IdMesa = int.Parse(Request.QueryString["Id"].ToString()); ;
                mesa.IdMesero = int.Parse(dgvMeserosActivos.SelectedDataKey.Value.ToString());
                mesa.Disponible = 0;

                MesaNegocio negocio = new MesaNegocio();
                negocio.AsignarMesero(mesa);

                Response.Redirect("Mesas.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("ERROR", ex.ToString());
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mesas.aspx", false);
        }
    }
}