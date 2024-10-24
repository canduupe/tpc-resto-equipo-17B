using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;  


namespace tpc_resto_equipo_17B
{
    public partial class Articulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           ArticuloNegocio objListar = new ArticuloNegocio();
            dgvCarta.DataSource = objListar.ListarConSp();
           dgvCarta.DataBind();



        }
    }
}