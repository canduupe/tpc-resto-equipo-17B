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
                                 
                ArticuloNegocio objListar = new ArticuloNegocio();
                articuloLista= objListar.ListarConSp();
                dgvCarta.DataSource = articuloLista;
                dgvCarta.DataBind();
                  
        }
    }
}

