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
    public partial class AgregarMesa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnAgregarM_Click(object sender, EventArgs e)
        {
            try
            {
                Mesa nuevo = new Mesa();
                MesaNegocio negocio = new MesaNegocio();

                nuevo.NumeroMesa = int.Parse(txtNumeroMesa.Text);
                nuevo.Disponible = 1;
                nuevo.Sector = txtSector.Text;
                
                negocio.agregarSP(nuevo);

                Response.Redirect("Mesas.aspx", false);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnCancelarM_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mesas.aspx", false);
        }
    }
}