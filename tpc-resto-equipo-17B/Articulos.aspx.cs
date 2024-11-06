using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;


namespace tpc_resto_equipo_17B
{
    public partial class Articulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Articulo> articuloLista;

            if (!Helper.SessionActiva(Session["Usuario"]))
                Response.Redirect("Error.aspx", false);

            if (Session["usuario"] == null)
            {
                Session.Add("Error", "Debes Loguearte para ingresar");
                Response.Redirect("Default.aspx", false);
            }
            else
            {
                ArticuloNegocio objListar = new ArticuloNegocio();
                articuloLista= objListar.ListarConSp();
                dgvCarta.DataSource = articuloLista;
                dgvCarta.DataBind();
                

            }

            


        }
    }
}



/* esto tambien por las dudas, va en el load
  if (Session["usuario"] == null)
            {
                Session.Add("Error", "Debes Loguearte para ingresar");
                Response.Redirect("Default.aspx", false);
            }
            else
            {
                ArticuloNegocio objListar = new ArticuloNegocio();
                dgvCarta.DataSource = objListar.ListarConSp();
                dgvCarta.DataBind();
            }

*/