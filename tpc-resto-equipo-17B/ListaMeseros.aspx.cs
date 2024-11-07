using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;


namespace tpc_resto_equipo_17B
{
    public partial class ListaMeseros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                List<Mesero> lista;
                MeseroNegocio negocio = new MeseroNegocio();

                lista = negocio.listar();
                dgvMeseros.DataSource = lista;
                dgvMeseros.DataBind();

            }



        }
    }
}