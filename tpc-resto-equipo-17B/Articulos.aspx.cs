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
            try
            {
                List<Articulo> articuloLista;
                                 
                ArticuloNegocio objListar = new ArticuloNegocio();
                articuloLista= objListar.listar();
                dgvCarta.DataSource = articuloLista;
                dgvCarta.DataBind();
            }
            catch (Exception ex)
            {
               throw ex; 
            }

            if (!Helper.EsGerente(Session["Usuario"]))
            {
                AgregarArt.Visible = false;
                dgvCarta.Columns[6].Visible = false;
                dgvCarta.Columns[7].Visible = false;
            }
        }

        protected void AgregarArt_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarArticulo.aspx", false);
        }

        protected void dgvCarta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvCarta.SelectedDataKey.Value.ToString();
            Response.Redirect("AgregarArticulo.aspx?Id=" + id);
        }
    }
}

